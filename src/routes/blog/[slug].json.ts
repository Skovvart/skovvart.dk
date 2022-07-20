import posts from './_posts';
import type { RequestHandler } from './__types/[slug].json';

const lookup = new Map();
posts.forEach((post) => {
	lookup.set(post.slug, JSON.stringify(post));
});

export const GET: RequestHandler = async ({ params }) => {
	const { slug } = params;

	if (lookup.has(slug)) {
		return {
			body: lookup.get(slug)
		};
	} else {
		return {
			status: 404,
			body: {
				message: `Not found`
			}
		};
	}
};
