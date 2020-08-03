import React, { Component } from "react";
import * as schedulesService from "../../services/schedulesService";
import { Formik, Field, Form, ErrorMessage } from "formik";
import debug from "sabio-debug";
import PropTypes from "prop-types";
import { toast } from "react-toastify";
import schedulesSchema from "../../schemas/schedulesSchema";
import moment from "moment";

const _logger = debug.extend("Schedules");

export class SchedulesFormik extends Component {
  constructor(props) {
    super(props);
    if (props.selectedSchedule === null) {
      this.state = {
        formData: {
          id: 0,
          vendorId: 0,
          locationId: 0,
          startTime: "",
          endTime: "",
        },
      };
    } else {
      this.state = {
        formData: {
          id: props.selectedSchedule.id,
          vendorId: props.selectedSchedule.vendorId,
          locationId: props.selectedSchedule.locationId,
          startTime: props.selectedSchedule.startDate,
          endTime: props.selectedSchedule.endDate,
        },
      };
    }
  }

  shouldComponentUpdate(nextProps) {
    let shouldUpdate = true;

    if (nextProps.selectedSchedule === this.props.selectedSchedule) {
      shouldUpdate = false;
    }
    return shouldUpdate;
  }

  onSave = (formValues) => {
    this.setFormValues(formValues);

    _logger(formValues, "---NEW FORM VALUES---");

    if (formValues.id === null || formValues.id === "") {
      formValues.id = 0;
    }

    if (formValues.id > 0) {
      schedulesService
        .updateSchedule(formValues.id, formValues)
        .then(this.onSaveSuccess)
        .catch(this.onSaveError);
    } else {
      schedulesService
        .addSchedule(formValues)
        .then(this.onSaveSuccess)
        .catch(this.onSaveError);
    }
  };
  onSaveSuccess = (response) => {
    _logger("update success", response);
    toast.success("Save Successful!");
  };
  onSaveError = (error) => {
    _logger("Update failed: ", error);
    toast.error("There was an error saving data...");
  };

  setFormValues = (formValues) => {
    formValues.id = parseInt(formValues.id);
    formValues.vendorId = parseInt(formValues.vendorId);
    formValues.locationId = parseInt(formValues.locationId);

    formValues.startTime = moment(formValues.startTime).format(
      "YYYY-MM-DDTHH:mm:ss"
    );
    formValues.endTime = moment(formValues.endTime).format(
      "YYYY-MM-DDTHH:mm:ss"
    );
  };

  render() {
    return (
      <div style={{ margin: "10px" }}>
        <Formik
          initialValues={this.state.formData}
          enableReinitialize={true}
          onSubmit={this.onSave}
          validationSchema={schedulesSchema}
        >
          {({ values, resetForm }) => (
            <center>
              {_logger(values)}
              <div className="card mt-4 p-4" style={{ width: 750 }}>
                <Form className="theme-form">
                  <div className="form-row">
                    <div className="col-md-5">
                      <div className="form-group">
                        <label className="col-form-label">Vendor</label>
                        <Field
                          name="vendorId"
                          component="select"
                          className="form-control"
                          value={values.vendorId}
                        >
                          <ErrorMessage name="vendorId" />
                          <option value="">--</option>
                          {this.props.vendorIds}
                        </Field>
                      </div>
                    </div>
                    <div className="col-md-7">
                      <div className="form-group">
                        <label className="col-form-label">Location</label>
                        <Field
                          name="locationId"
                          component="select"
                          className="form-control"
                          value={values.locationId}
                        >
                          <ErrorMessage name="locationId" />
                          <option value="">--</option>
                          {this.props.locationIds}
                        </Field>
                      </div>
                    </div>
                  </div>

                  <div className="form-row">
                    <div className="col-md-6">
                      <div className="form-group">
                        <label className="col-form-label">Start Date</label>
                        <Field
                          type="datetime-local"
                          name="startTime"
                          className="form-control"
                          values={values.startTime}
                        />
                        <ErrorMessage name="startTime" />
                      </div>
                    </div>
                    <div className="col-md-6">
                      <div className="form-group">
                        <label className="col-form-label">End Date</label>
                        <Field
                          type="datetime-local"
                          name="endTime"
                          className="form-control"
                          values={values.endTime}
                        />
                        <ErrorMessage name="endTime" />
                      </div>
                    </div>
                  </div>

                  <div className="social mt-3">
                    <div className="form-row">
                      <div className="col-sm-4">
                        <button
                          type="submit"
                          className="btn social-btn btn-primary-gradien mb-2"
                        >
                          Save
                        </button>
                      </div>
                      <div className="col-sm-4">
                        <button
                          className="btn social-btn btn-secondary-gradien mb-2"
                          type="reset"
                          onClick={resetForm}
                        >
                          Clear
                        </button>
                      </div>
                      <div className="col-sm-4">
                        <button
                          className="btn social-btn btn-secondary-gradien mb-2"
                          type="reset"
                          onClick={(e) => this.props.handleCloseModal(e)}
                        >
                          Cancel
                        </button>
                      </div>
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

SchedulesFormik.propTypes = {
  schedule: PropTypes.element,
  onCancel: PropTypes.element,
  selectedSchedule: PropTypes.shape({
    id: PropTypes.number,
    vendorId: PropTypes.number,
    locationId: PropTypes.number,
    startDate: PropTypes.instanceOf(Date),
    endDate: PropTypes.instanceOf(Date),
  }),
  handleCloseModal: PropTypes.func,
  vendorIds: PropTypes.array,
  locationIds: PropTypes.array,
};

export default SchedulesFormik;
