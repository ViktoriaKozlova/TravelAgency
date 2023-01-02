async function displayTours() {
  let tours = await getTour();

  let toursTable = document.getElementById("getTour");

  for (let tour of tours) {
    const {
      idTour,
      departureDate,
      arrivalDate,
      amountSeats,
      numberTypeTour,
      price,
      description,
      numberLocation,
      remark,
      numberTourOperator,
      number_status,
    } = tour;

    const row = document.createElement("tr");

    const idTourEl = document.createElement("td");
    const departureDateEl = document.createElement("td");
    const arrivalDateEl = document.createElement("td");
    const amountSeatsEl = document.createElement("td");
    const numberTypeTourEl = document.createElement("td");
    const priceEl = document.createElement("td");
    const descriptionEl = document.createElement("td");
    const numberLocationEl = document.createElement("td");
    const remarkEl = document.createElement("td");
    const numberTourOperatorEl = document.createElement("td");
    const number_statusEl = document.createElement("td");

    idTourEl.classList.add("tour-element");
    departureDateEl.classList.add("tour-element");
    arrivalDateEl.classList.add("tour-element");
    amountSeatsEl.classList.add("tour-element");
    numberTypeTourEl.classList.add("tour-element");
    priceEl.classList.add("tour-element");
    descriptionEl.classList.add("tour-element");
    numberLocationEl.classList.add("tour-element");
    remarkEl.classList.add("tour-element");
    numberTourOperatorEl.classList.add("tour-element");
    number_statusEl.classList.add("tour-element");

    idTourEl.innerText = idTour;
    departureDateEl.innerText = departureDate;
    arrivalDateEl.innerText = arrivalDate;
    amountSeatsEl.innerText = amountSeats;
    numberTypeTourEl.innerText = numberTypeTour;
    priceEl.innerText = price;
    descriptionEl.innerText = description;
    numberLocationEl.innerText = numberLocation;
    remarkEl.innerText = remark;
    numberTourOperatorEl.innerText = numberTourOperator;
    number_statusEl.innerText = number_status;

    row.append(
      idTourEl,
      departureDateEl,
      arrivalDateEl,
      amountSeatsEl,
      numberTypeTourEl,
      priceEl,
      descriptionEl,
      numberLocationEl,
      remarkEl,
      numberTourOperatorEl,
      number_statusEl
    );

    toursTable.append(row);
  }
}

displayTours();
