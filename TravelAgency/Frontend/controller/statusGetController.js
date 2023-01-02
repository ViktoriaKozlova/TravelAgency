async function displayStatuses() {
  let statuses = await getStatus();

  let statusesTable = document.getElementById("getStatus");

  for (let status of statuses) {
    const { idStatus, nameStatus } = status;

    const row = document.createElement("tr");

    const idStatusEl = document.createElement("td");
    const nameStatusEl = document.createElement("td");

    idStatusEl.classList.add("status-element");
    nameStatusEl.classList.add("status-element");

    idStatusEl.innerText = idStatus;
    nameStatusEl.innerText = nameStatus;

    row.append(idStatusEl, nameStatusEl);

    statusesTable.append(row);
  }
}

displayStatuses();
