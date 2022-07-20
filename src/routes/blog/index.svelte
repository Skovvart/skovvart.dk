<script context="module" lang="ts">
	import type { Load } from './__types';
	type PostReference = { slug: string; title: string };
	export const load: Load = async ({ fetch }) => {
		const r = await fetch(`/blog.json`);
		const posts: PostReference[] = await r.json();
		return { props: { posts } };
	};
</script>

<script lang="ts">
	export let posts: PostReference[];
</script>

<svelte:head>
	<title>Blog</title>
	<meta name="description" content="A lovely description about the blog." />
</svelte:head>

<h1>Recent posts</h1>

<ul>
	{#each posts as post}
		<!-- we're using the non-standard `rel=prefetch` attribute to
				tell Sapper to load the data for the page as soon as
				the user hovers over the link or taps it, instead of
				waiting for the 'click' event -->
		<li><a href="/blog/{post.slug}/" sveltekit:prefetch>{post.title}</a></li>
	{/each}
</ul>

<style>
	ul {
		margin: 0 0 1em 0;
		line-height: 1.5;
	}
</style>
