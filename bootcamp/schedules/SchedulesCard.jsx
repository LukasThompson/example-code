import React from "react";
import PropTypes from "prop-types";
import moment from "moment";
const GOOGLE_APIKEY = process.env.REACT_APP_GOOGLE_APIKEY;

const SchedulesCard = (props) => {
  const handleDelete = () => {
    props.handleDelete(props.schedule);
  };

  var zoom = 16;
  var mapUrl = `https://maps.googleapis.com/maps/api/staticmap?center=${props.schedule.location.lineOne},${props.schedule.location.city},${props.schedule.location.state}&zoom=${zoom}&size=200x200&maptype=roadmap&markers=color:blue%7Clabel:S%7C${props.schedule.location.latitude},${props.schedule.location.longitude}&markers=color:green%7Clabel:G%7C40.711614,-74.012318&markers=color:red%7Clabel:C%7C40.718217,-73.998284&key=`;
  var mapSrc = mapUrl + GOOGLE_APIKEY;
  // var streetMapUrl = `https://maps.googleapis.com/maps/api/streetview?size=200x200&location=${props.schedule.location.latitude},${props.schedule.location.longitude}&fov=80&heading=70&pitch=0&key=${GOOGLE_APIKEY}`;

  return (
    <div className="col-xl-3 col-sm-6">
      <div className="card" height="500px">
        <div className="product-box">
          <div className="product-details">
            <img
              src={mapSrc}
              height="200px"
              width="100%"
              alt="street view"
              onClick={(e) => props.onClick(props.schedule, e)}
            />
            <h6>{props.schedule.vendorName}</h6>
            <p>
              {props.schedule.location.lineOne}, {props.schedule.location.city},{" "}
              {props.schedule.location.states.code}
            </p>
            <p>
              {moment(props.schedule.startTime).format(
                "ddd, MMM DD, YYYY - hh:mm a"
              )}
              <br />
              {moment(props.schedule.endTime).format(
                "ddd, MMM DD, YYYY - hh:mm a"
              )}
            </p>
            {props.currentUser.roles.includes("Admin") ||
            props.currentUser.roles.includes("Vendor") ? (
              <>
                <button
                  className="btn social-btn btn-primary-gradien mb-2"
                  size="sm"
                  onClick={(e) => props.onClick(props.schedule, e)}
                  style={{ margin: "2px" }}
                >
                  Edit
                </button>
                <button
                  className="btn social-btn btn-primary-gradien mb-2"
                  size="sm"
                  onClick={handleDelete}
                  style={{ margin: "2px" }}
                >
                  Delete
                </button>
              </>
            ) : (
              <span></span>
            )}
          </div>
        </div>
      </div>
    </div>
  );
};

SchedulesCard.propTypes = {
  schedule: PropTypes.shape({
    id: PropTypes.number,
    vendorName: PropTypes.string,
    startTime: PropTypes.string,
    endTime: PropTypes.string,
    location: PropTypes.shape({
      lineOne: PropTypes.string,
      city: PropTypes.string,
      latitude: PropTypes.number,
      longitude: PropTypes.number,
      states: PropTypes.shape({
        code: PropTypes.string,
      }),
    }),
  }),
  handleDelete: PropTypes.func,
  onClick: PropTypes.func,
  handleOpenModal: PropTypes.func,
  currentUser: PropTypes.shape({
    roles: PropTypes.array,
  }),
};

export default SchedulesCard;
