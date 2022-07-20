<div class="flex-wrapper">
	<slot />
</div>

<style lang="scss">
	.flex-wrapper {
		display: flex;
		flex-wrap: wrap;
		gap: 1em;

		:global(*) {
			flex: 1 1 15em;
			max-width: 100%;
		}
	}
</style>
