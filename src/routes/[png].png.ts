import type { RequestHandler } from './__types/[png].png';

export const GET: RequestHandler = async ({ params }) => {
	const { png } = params;
	let response = await fetch(`http://127.0.0.1:5173/build-fix-workaround/${png}.png`)
	if(!response.ok)
	return {
		status: 404
	}
	
	return {
		headers:{
			"content-type": "image/png"
		},
		body: response.body
	};
};
