async function displayRoles() {
  let roles = await getRole();

  let rolesTable = document.getElementById("getRole");

  for (let role of roles) {
    const { idRole, nameRole } = role;

    const row = document.createElement("tr");

    const idRoleEl = document.createElement("td");
    const nameRoleEl = document.createElement("td");

    idRoleEl.classList.add("role-element");
    nameRoleEl.classList.add("role-element");

    idRoleEl.innerText = idRole;
    nameRoleEl.innerText = nameRole;

    row.append(idRoleEl, nameRoleEl);

    rolesTable.append(row);
  }
}

displayRoles();
