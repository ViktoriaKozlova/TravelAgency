async function removeUser(event) {
  event.preventDefault();
  const form = event.target;
  const { idUser } = form.elements;
  await deleteUser(idUser.value);
  location.reload();
}

document
  .getElementById("delete-user-form")
  .addEventListener("submit", removeUser);
