async function displayTypeTours() {
  let typeTours = await getTypeTour();

  let typeToursTable = document.getElementById("getTypeTour");

  for (let typeTour of typeTours) {
    const { idTepyTour, name } = typeTour;

    const row = document.createElement("tr");

    const idTepyTourEl = document.createElement("td");
    const nameEl = document.createElement("td");

    idTepyTourEl.classList.add("typeTour-element");
    nameEl.classList.add("typeTour-element");

    idTepyTourEl.innerText = idTepyTour;
    nameEl.innerText = name;

    row.append(idTepyTourEl, nameEl);

    typeToursTable.append(row);
  }
}

displayTypeTours();
