async function updateUser(event) {
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
  await newversionUser(
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
document
  .getElementById("update-user-form")
  .addEventListener("submit", updateUser);
