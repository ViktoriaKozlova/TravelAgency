async function getTypeTour() {
  const response = await fetch("https://localhost:7137/TypeTour", {
    method: "GET",
  });
  const result = await response.json();
  console.log(result);
  return result;
}
