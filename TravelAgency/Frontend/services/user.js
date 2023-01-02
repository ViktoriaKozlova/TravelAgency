async function getUser() {
  const response = await fetch("https://localhost:7137/User", {
    method: "GET",
  });
  const result = await response.json();

  return result;
}

async function insertUser(
  IdUser,
  NumberRole,
  Fullname,
  City,
  Numbers,
  Login,
  Password,
  PassportNumber
) {
  try {
    const body = JSON.stringify({
      IdUser,
      NumberRole,
      Fullname,
      City,
      Numbers,
      Login,
      Password,
      PassportNumber,
    });
    const response = await fetch("https://localhost:7137/User", {
      method: "POST",
      body,
      headers: { "Content-Type": "application/json" },
    });
    if (!response.ok) {
      throw new Error("Error");
    }
    console.log(" added!");
  } catch (error) {
    console.log(error.message);
  }
}

async function newversionUser(
  IdUser,
  NumberRole,
  Fullname,
  City,
  Numbers,
  Login,
  Password,
  PassportNumber
) {
  try {
    const body = JSON.stringify({
      IdUser,
      NumberRole,
      Fullname,
      City,
      Numbers,
      Login,
      Password,
      PassportNumber,
    });
    const response = await fetch("https://localhost:7137/User", {
      method: "PUT",
      body,
      headers: { "Content-Type": "application/json" },
    });
    if (!response.ok) {
      throw new Error("Error");
    }
  } catch (error) {
    console.log(error.message);
  }
}

async function deleteUser(id) {
  try {
    const response = await fetch(`https://localhost:7137/User/${id}`, {
      method: "DELETE",
    });
    if (!response.ok) {
      throw new Error("Error");
    }
  } catch (error) {
    console.log(error.message);
  }
}
