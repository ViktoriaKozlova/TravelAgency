async function getStatus() {
  const response = await fetch("https://localhost:7137/Status", {
    method: "GET",
  });
  const result = await response.json();
  console.log(result);
  return result;
}
