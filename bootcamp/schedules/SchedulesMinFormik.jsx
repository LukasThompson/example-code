import React, { Component } from "react";
import { Formik, Field, Form, ErrorMessage } from "formik";
import debug from "sabio-debug";
import PropTypes from "prop-types";
import { toast } from "react-toastify";
import schedulesMinSchema from "../../schemas/schedulesMinSchema";
import * as scheduleService from "../../services/schedulesService";
import SchedulesCard from "../../components/schedules/SchedulesCard";
const _logger = debug.extend("Schedules");

export class SchedulesMinFormik extends Component {
  constructor(props) {
    super(props);
    this.state = {
      formData: {
        startTime: "",
        endTime: "",
        vendorId: 0,
      },
    };
  }

  mapSchedules = (schedule) => {
    _logger("Mapping schedules..." + schedule);
    return (
      <SchedulesCard
        schedule={schedule}
        key={schedule.id}
        handleDelete={this.props.handleDelete}
        onClick={this.props.onClick}
        currentUser={this.props.currentUser}
      />
    );
  };

  shouldComponentUpdate(nextProps) {
    let shouldUpdate = true;

    if (nextProps.createdVendors === this.props.createdVendors) {
      shouldUpdate = false;
    }
    return shouldUpdate;
  }

  onReset = () => {
    this.props.getAllSchedules(
      this.props.currentUser.id,
      this.props.pageIndex,
      this.props.pageSize
    );
  };

  onSubmit = (values) => {
    scheduleService
      .getSchedulesByCreatedByByVendor(
        this.props.pageSize,
        this.props.pageIndex,
        values.startTime,
        values.endTime,
        values.vendorId
      )
      .then(this.getScheduledVendorsSuccess)
      .catch(this.getScheduledVendorsError);
  };
  getScheduledVendorsSuccess = (response) => {
    let scheduleArr = response.item.pagedItems;
    let mappedSchedule = scheduleArr.map(this.mapSchedules);
    this.props.handleUpdateFromChild(mappedSchedule);
  };
  getScheduledVendorsError = () => {};

  onSubmitSucess = (response) => {
    _logger("update success", response);
    toast.success("Save Successful!");
  };
  onSubmitError = (error) => {
    _logger("Update failed: ", error);
    toast.error("There was an error saving data...");
  };

  render() {
    return (
      <div style={{ margin: "10px" }}>
        <Formik
          initialValues={this.state.formData}
          enableReinitialize={true}
          onSubmit={this.onSubmit}
          validationSchema={schedulesMinSchema}
        >
          {({ values }) => (
            <center>
              {_logger(values)}
              <div className="card mt-4 p-4" style={{ width: "100%" }}>
                <Form className="theme-form">
                  <div className="form-row">
                    <div className="col-md-3">
                      <div className="form-group">
                        <Field
                          name="vendorId"
                          component="select"
                          className="form-control"
                          value={values.vendorName}
                        >
                          <ErrorMessage name="vendorId" />
                          <option value="">Select Vendor</option>
                          {this.props.createdVendors}
                        </Field>
                      </div>
                    </div>
                    <div className="col-md-2">
                      <div className="form-group">
                        <Field
                          type="date"
                          name="startTime"
                          className="form-control"
                        />
                        <ErrorMessage name="startTime" />
                      </div>
                    </div>
                    <div className="col-md-2">
                      <div className="form-group">
                        <Field
                          type="date"
                          name="endTime"
                          className="form-control"
                        />
                        <ErrorMessage name="endTime" />
                      </div>
                    </div>
                    <div className="col-sm-2">
                      <button
                        type="submit"
                        className="btn social-btn btn-primary-gradien mb-2"
                      >
                        Get Schedules
                      </button>
                    </div>
                    <div className="col-sm-1">
                      <button
                        type="button"
                        className="btn social-btn btn-primary-gradien mb-1"
                        onClick={(e) => this.onReset(e)}
                      >
                        Reset
                      </button>
                    </div>
                    <div className="col-sm-2">
                      {this.props.currentUser.roles.includes("Admin") ||
                      this.props.currentUser.roles.includes("Vendor") ? (
                        <button
                          type="button"
                          className="btn social-btn btn-primary-gradien mb-2"
                          onClick={(e) => this.props.handleOpenModal(e)}
                        >
                          Add Schedule
                        </button>
                      ) : (
                        <span></span>
                      )}
                    </div>
                  </div>
                </Form>
              </div>
            </center>
          )}
        </Formik>
      </div>
    );
  }
}

SchedulesMinFormik.propTypes = {
  schedule: PropTypes.element,
  onCancel: PropTypes.element,
  createdVendors: PropTypes.shape({
    name: PropTypes.string,
    startTime: PropTypes.instanceOf(Date),
    endTime: PropTypes.instanceOf(Date),
    id: PropTypes.number,
  }),
  pageSize: PropTypes.number,
  pageIndex: PropTypes.number,
  handleOpenModal: PropTypes.func,
  handleUpdateFromChild: PropTypes.func,
  handleDelete: PropTypes.func,
  onClick: PropTypes.func,
  getAllSchedules: PropTypes.func,
  currentUser: PropTypes.shape({
    roles: PropTypes.array,
    id: PropTypes.number,
  }),
};

export default SchedulesMinFormik;
