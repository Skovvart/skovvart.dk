<script lang="ts">
	export let buttonText: string;
	export let url: string;
</script>

<a href={url} class="btn">{buttonText}</a>

<style lang="scss">
	@import '../styles/theme.scss';
	.btn {
		box-shadow: 0 0.5em 0.7em -0.5em var(--color-text);
		background-color: var(--color-primary);
		color: #{$color-light};
		border-radius: 0.35em;
		display: inline-block;
		cursor: pointer;

		font-weight: bold;
		padding: 0.7em 1.5em;
		text-decoration: none;

		&:hover {
			background-color: var(--color-secondary);
		}
		&:focus {
			border: 3px solid #{$color-light};
		}
		&:active {
			position: relative;
			top: 0.1em;
		}
	}
</style>
