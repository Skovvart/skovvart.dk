import posts from './_posts';

const contents = posts.map((post) => {
	return {
		title: post.title,
		slug: post.slug
	};
});

export const GET = async () => {
	return {
		body: contents
	};
};
