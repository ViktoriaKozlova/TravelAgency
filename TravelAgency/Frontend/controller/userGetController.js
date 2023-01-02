async function displayUsers() {
  let users = await getUser();

  let usersTable = document.getElementById("getUser");

  for (let user of users) {
    const {
      idUser,
      numberRole,
      fullname,
      city,
      numbers,
      login,
      password,
      passportNumber,
    } = user;

    const row = document.createElement("tr");

    const IdUserEl = document.createElement("td");
    const NumberRoleEl = document.createElement("td");
    const FullnameEl = document.createElement("td");
    const CityEl = document.createElement("td");
    const NumbersEl = document.createElement("td");
    const LoginEl = document.createElement("td");
    const PasswordEl = document.createElement("td");
    const PassportNumberEl = document.createElement("td");

    IdUserEl.classList.add("user-element");
    NumberRoleEl.classList.add("user-element");
    FullnameEl.classList.add("user-element");
    CityEl.classList.add("user-element");
    NumbersEl.classList.add("user-element");
    LoginEl.classList.add("user-element");
    PasswordEl.classList.add("user-element");
    PassportNumberEl.classList.add("user-element");

    IdUserEl.innerText = idUser;
    NumberRoleEl.innerText = numberRole;
    FullnameEl.innerText = fullname;
    CityEl.innerText = city;
    NumbersEl.innerText = numbers;
    LoginEl.innerText = login;
    PasswordEl.innerText = password;
    PassportNumberEl.innerText = passportNumber;

    row.append(
      IdUserEl,
      NumberRoleEl,
      FullnameEl,
      CityEl,
      NumbersEl,
      LoginEl,
      PasswordEl,
      PassportNumberEl
    );

    usersTable.append(row);
    console.log(row);
  }
}

displayUsers();
