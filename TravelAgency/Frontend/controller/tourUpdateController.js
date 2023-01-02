async function updateTour(event) {
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
  await newversionTour(
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

  location.reload();
}
document
  .getElementById("update-tour-form")
  .addEventListener("submit", updateTour);
