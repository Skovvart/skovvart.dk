import fetch from "node-fetch";

export async function get(req, res) {
  const fetchResponse = await fetch(`http://localhost:7071/api/blogs`);
  const posts = await fetchResponse.json();
  res.writeHead(200, {
    "Content-Type": "application/json",
  });

  res.end(JSON.stringify(posts));
}
