import type { RequestHandler } from './__types/manifest.json';

export const GET: RequestHandler = async () => {
	let response = await fetch(`http://127.0.0.1:5173/build-fix-workaround/manifest.json`)
	if(!response.ok)
	return {
		status: 404
	}
	
	return {
		headers:{
			"content-type": "application/json"
		},
		body: response.body
	};
};
