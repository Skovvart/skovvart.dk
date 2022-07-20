<script context="module" lang="ts">
	import type { Load } from './__types/[slug]';
	type Post = { slug: string; title: string; html: string };
	export const load: Load = async ({ params: { slug }, fetch }) => {
		const res = await fetch(`/blog/${slug}.json`);
		const data: Post = await res.json();

		if (res.status === 200) {
			return { props: { post: data } };
		}
		return { props: { post: [] } };
	};
</script>

<script lang="ts">
	export let post: Post;
</script>

<svelte:head>
	<title>{post.title}</title>
	<meta name="description" content={post.title} />
</svelte:head>

<h1>{post.title}</h1>

<div class="content">
	{@html post.html}
</div>

<style>
	.content :global(pre) {
		color: var(--color-text-inverted);
		background-color: var(--color-background-inverted);
		box-shadow: inset 1px 1px 5px rgba(0, 0, 0, 0.05);
		padding: 0.5em;
		border-radius: 2px;
		overflow-x: auto;
	}

	.content :global(pre) :global(code) {
		background-color: transparent;
		padding: 0;
	}

	.content :global(ul) {
		line-height: 1.5;
	}

	.content :global(li) {
		margin: 0 0 0.5em 0;
	}
</style>
