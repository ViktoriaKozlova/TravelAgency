async function addUser(event) {
  event.preventDefault();
  const form = event.target;
  const {
    idUser,
    numberRole,
    fullname,
    city,
    numbers,
    login,
    password,
    passportNumber,
  } = form.elements;
  await insertUser(
    idUser.value,
    numberRole.value,
    fullname.value,
    city.value,
    numbers.value,
    login.value,
    password.value,
    passportNumber.value
  );
  location.reload();
}

document.querySelector("#add-user-form").addEventListener("submit", addUser);
