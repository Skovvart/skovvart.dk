import fetch from "node-fetch";

export async function get(req, res, next) {
  // the `slug` parameter is available because
  // this file is called [slug].json.js
  const { slug } = req.params;
  const fetchResponse = await fetch(`http://localhost:7071/api/blogs/${slug}`);

  if (fetchResponse.status === 200) {
    res.writeHead(200, {
      "Content-Type": "application/json",
    });

    res.end(JSON.stringify(await fetchResponse.json()));
  } else {
    res.writeHead(404, {
      "Content-Type": "application/json",
    });

    res.end(
      JSON.stringify({
        message: `Not found`,
      })
    );
  }
}
