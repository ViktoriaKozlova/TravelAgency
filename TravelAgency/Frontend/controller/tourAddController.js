async function addTour(event) {
  event.preventDefault();
  const form = event.target;
  const {
    IdTour,
    DepartureDate,
    ArrivalDate,
    AmountSeats,
    NumberTypeTour,
    Price,
    Description,
    NumberLocation,
    Remark,
    NumberTourOperator,
    number_status,
  } = form.elements;
  await insertTour(
    IdTour.value,
    DepartureDate.value,
    ArrivalDate.value,
    AmountSeats.value,
    NumberTypeTour.value,
    Price.value,
    Description.value,
    NumberLocation.value,
    Remark.value,
    NumberTourOperator.value,
    number_status.value
  );
}

document.querySelector("#add-tour-form").addEventListener("submit", addTour);
