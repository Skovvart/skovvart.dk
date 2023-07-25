<script lang="ts">
	import { onMount } from 'svelte';
	export let topElementQuerySelector = '.header__logo';

	let showButton = false;

	function scrollToTop() {
		var currentScroll = document.documentElement.scrollTop || document.body.scrollTop;
		if (currentScroll > 0) {
			window.requestAnimationFrame(scrollToTop);
			window.scrollTo(0, currentScroll - currentScroll / 5);
		}
		(document.activeElement as HTMLButtonElement)?.blur();
	}

	onMount(() => {
		const onHeaderIntersectionChange: IntersectionObserverCallback = (entries) => {
			entries.forEach((entry) => (showButton = !entry.isIntersecting));
		};

		const options = {
			threshold: 1.0,
			rootMargin: '100%'
		};
		const headerObserver = new IntersectionObserver(onHeaderIntersectionChange, options);
		const topElement = document.querySelector(topElementQuerySelector);
		if (topElement) headerObserver.observe(topElement);
	});
</script>

<button
	class="scroll-to-top"
	class:scroll-to-top--active={showButton}
	title="Scroll to top"
	on:click={scrollToTop}
>
	<svg xmlns="http://www.w3.org/2000/svg" viewBox="0 0 640 640">
		<path d="M85 315L335 85L550 315L640 315L330 0L0 315L85 315Z" />
	</svg>
</button>

<style lang="scss">
	.scroll-to-top {
		width: 2em;
		height: 2em;
		background-color: rgba(#000, 0.25);
		border-radius: 5em;
		overflow: hidden;

		padding: 0.5em;
		cursor: pointer;
		box-shadow: 0.1em 0.1em 0.1em 0.1em rgba(#000, 0.3);

		position: fixed;
		bottom: 0.5em;
		right: 0.5em;

		will-change: transform;
		transform: translateX(2.5em);
		opacity: 0;
		transition: opacity 1s ease-in, transform 0.3s ease-in-out;

		border: none;
		font: inherit;

		&--active {
			transform: translateX(0);
			opacity: 100;
		}
		&:hover,
		&:focus {
			background-color: rgba(#000, 0.5);
		}

		svg {
			transform: translateY(2px);
			path {
				fill: white;
			}
		}
	}
</style>
