async function getRole() {
  const response = await fetch("https://localhost:7137/Role", {
    method: "GET",
  });
  const result = await response.json();
  console.log(result);
  return result;
}
