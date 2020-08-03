import React, { Component } from "react";
import SchedulesFormik from "./SchedulesFormik";
import debug from "sabio-debug";
import * as schedulesService from "../../services/schedulesService";
import * as vendorServices from "../../services/vendorServices";
import * as locationServices from "../../services/locationsService";
import SchedulesCard from "./SchedulesCard";
import { toast } from "react-toastify";
import Pagination from "rc-pagination";
import { getDefaultLocale } from "react-datepicker";
import "rc-pagination/assets/index.css";
import SchedulesMinFormik from "./SchedulesMinFormik";
import { CardGroup, Modal, Container } from "reactstrap";
import PropTypes from "prop-types";

const _logger = debug.extend("Schedules");

export class Schedules extends Component {
  constructor(props) {
    super(props);
    this.state = {
      schedulesData: [],
      selectedSchedule: {},
      currentPage: 1,
      pageIndex: 0,
      pageSize: 12,
      total: 0,
      createdBy: this.props.currentUser.id,
      showModal: false,
      mappedSchedule: [],
      createdVendors: [],
      vendorIds: [],
      createdLocations: [],
      locationIds: [],
    };
  }

  handleOpenModal = () => {
    this.setState({ showModal: true });
  };

  handleCloseModal = () => {
    this.setState({ showModal: false });
  };

  componentDidMount() {
    _logger("componentDidMount...");
    this.getAllSchedules(
      this.state.createdBy,
      this.state.pageIndex,
      this.state.pageSize
    );
    this.getCreatedVendors(1000, 0);
    this.getCreatedLocations(0, 1000);
  }

  shouldComponentUpdate(prevProps, prevState) {
    _logger(prevState, prevProps, "--- shouldComponentUpdate---");
    if (prevState !== this.state.schedulesData) {
      return true;
    } else {
      return false;
    }
  }

  getCreatedLocations = (pageIndex, pageSize) => {
    locationServices
      .getLocationByCreatedBy(pageIndex, pageSize)
      .then(this.getLocationsSuccess)
      .catch(this.getLocationsError);
  };
  getLocationsSuccess = (response) => {
    _logger(response.item.pagedItems, "---GET LOCATIONS SUCCESS---");

    this.setState((prevState) => {
      let locationsArr = response.item.pagedItems;
      _logger(locationsArr, "---LOCATIONS ARRAY---");

      let mappedLocations = locationsArr.map(this.mapById);
      let mappedLocationIds = locationsArr.map(this.mapByLine);
      return {
        ...prevState,
        createdLocations: mappedLocations,
        locationIds: mappedLocationIds,
      };
    });
    _logger(" getAllSuccess ", this.state);
  };
  getLocationsError = (error) => {
    _logger(error);
    toast.error("There was an error retrieving locations...");
  };

  getCreatedVendors = (pageSize, pageIndex) => {
    vendorServices
      .getByCreatedBy(pageSize, pageIndex)
      .then(this.onVendorSuccess)
      .catch(this.onVendorError);
  };
  onVendorSuccess = (response) => {
    _logger(response.item.pagedItems, "---GET VENDOR SUCCESS---");

    this.setState((prevState) => {
      let vendorArr = response.item.pagedItems;
      _logger(vendorArr, "---VENDOR ARRAY---");

      let mappedVendor = vendorArr.map(this.mapById);
      let mappedVendorId = vendorArr.map(this.mapById);

      return {
        ...prevState,
        createdVendors: mappedVendor,
        vendorIds: mappedVendorId,
      };
    });
    _logger(" getAllSuccess ", this.state);
  };
  onVendorError = (error) => {
    _logger(error);
    toast.error("There was an error retrieving vendors...");
  };

  mapById = (anItem) => {
    return (
      <option value={parseInt(anItem.id)} key={anItem.id}>
        {anItem.name}
      </option>
    );
  };

  mapByLine = (anItem) => {
    return (
      <option value={parseInt(anItem.id)} key={anItem.id}>
        {anItem.lineOne}
      </option>
    );
  };

  getAllSchedules = (createdBy, pageIndex, pageSize) => {
    schedulesService
      .getAllSchedules(createdBy, pageIndex, pageSize)
      .then(this.onGetSuccess)
      .catch(this.onGetError);
  };
  onGetSuccess = (response) => {
    _logger(response.item.pagedItems, "---GET SCHEDULES SUCCESS---");

    this.setState((prevState) => {
      let scheduleArr = response.item.pagedItems;
      let mappedSchedule = scheduleArr.map(this.mapSchedules);
      return {
        ...prevState,
        schedulesData: mappedSchedule,
        total: response.item.totalCount,
        pageIndex: response.item.pageIndex,
      };
    });
    _logger(" getAllSuccess ", this.state);
  };
  onGetError = (error) => {
    _logger(error);
    toast.error("There was an error retrieving schedules...");
  };

  onChange = (page, pageSize) => {
    schedulesService
      .getAllSchedules(this.state.createdBy, page - 1, pageSize)
      .then(this.onGetSuccess)
      .catch(this.onGetError);

    this.setState({ currentPage: page });
  };

  mapSchedules = (schedule) => {
    _logger("Mapping schedules..." + schedule);
    return (
      <SchedulesCard
        schedule={schedule}
        key={schedule.id}
        handleDelete={this.deleteHandler}
        onClick={this.onSelectItem}
        currentUser={this.props.currentUser}
      />
    );
  };

  deleteHandler = (schedule) => {
    _logger("deleteHandler", schedule.id);

    schedulesService
      .deleteSchedule(schedule.id)
      .then(this.onDeleteSuccess(schedule))
      .catch(this.onDeleteError);
  };

  onDeleteSuccess = (schedule) => {
    _logger("Deleted successfully");
    toast.success("Schedule deleted successfully!");

    this.setState((prevState) => {
      const indexOfSchedules = prevState.schedulesData.findIndex(
        (singleSchedule) => singleSchedule.props.schedule.id === schedule.id
      );

      _logger(indexOfSchedules);
      const updatedSchedule = [...prevState.schedulesData];

      if (indexOfSchedules >= 0) {
        updatedSchedule.splice(indexOfSchedules, 1);
      }
      return {
        ...prevState,
        schedulesData: updatedSchedule,
      };
    });
  };
  onDeleteError = () => {
    _logger("Delete Failed!");
    toast.error("There was an error deleting the schedule...");
  };

  onSelectItem = (schedule, event) => {
    _logger({ schedule });

    this.setState(() => {
      return { selectedSchedule: schedule };
    });
    this.handleOpenModal();
  };

  handleUpdateFromChild = (mappedSchedule) => {
    this.setState(() => {
      return { schedulesData: mappedSchedule };
    });
  };
  render() {
    _logger("rendering...");
    return (
      <>
        <br />
        <Container>
          <SchedulesMinFormik
            createdVendors={this.state.createdVendors}
            vendorIds={this.state.vendorIds}
            handleOpenModal={this.handleOpenModal}
            pageSize={this.state.pageSize}
            pageIndex={this.state.pageIndex}
            schedulesData={this.state.schedulesData}
            handleUpdateFromChild={this.handleUpdateFromChild}
            handleDelete={this.deleteHandler}
            onClick={this.onSelectItem}
            currentUser={this.props.currentUser}
            getAllSchedules={this.getAllSchedules}
          />
        </Container>
        <Modal isOpen={this.state.showModal} size="lg">
          <SchedulesFormik
            schedules={this.state.schedulesData}
            vendorIds={this.state.vendorIds}
            locationIds={this.state.locationIds}
            createdLocations={this.state.createdLocations}
            selectedSchedule={this.state.selectedSchedule}
            handleCloseModal={this.handleCloseModal}
          />
        </Modal>
        <Container>
          <CardGroup>{this.state.schedulesData}</CardGroup>
          <Pagination
            defaultCurrent="1"
            current={this.state.currentPage}
            total={this.state.total}
            defaultPageSize="12"
            pageSize={this.state.pageSize}
            prevIcon="Prev"
            nextIcon="Next"
            onChange={this.onChange}
            locale={getDefaultLocale}
          />
        </Container>
      </>
    );
  }
}

Schedules.propTypes = {
  currentUser: PropTypes.shape({
    id: PropTypes.number,
  }),
};
export default Schedules;
