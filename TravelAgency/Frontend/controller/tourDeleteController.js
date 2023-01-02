async function removeTour(event) {
  event.preventDefault();
  const form = event.target;
  const { IdTour } = form.elements;
  await deleteTour(IdTour.value);
  location.reload();
}

document
  .getElementById("delete-tour-form")
  .addEventListener("submit", removeTour);
