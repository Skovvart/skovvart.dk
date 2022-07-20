import type { RequestHandler } from './__types/favicon.ico';

export const GET: RequestHandler = async () => {
	let response = await fetch(`http://127.0.0.1:5173/build-fix-workaround/favicon.ico`)
	if(!response.ok)
	return {
		status: 404
	}
	
	return {
		headers:{
			"content-type": "image/x-icon"
		},
		body: response.body
	};
};
