<script lang="ts">
</script>

<main class="main">
	<slot />
</main>

<style lang="scss">
	@import '../styles/theme.scss';
	.main {
		width: 45em;
		max-width: 100%;
		background-color: var(--color-background);
		padding: 0.5em 2em;
		color: var(--color-text);
	}
</style>
