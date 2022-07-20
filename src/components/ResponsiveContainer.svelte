<script lang="ts">
	export let ratio: '16-9' | '4-3' | '3-2' | '1-1';
</script>

<div class="responsive-container ratio-{ratio}">
	<slot />
</div>

<style lang="scss">
	.responsive-container {
		width: 100%;
		position: relative;
		height: 0;
		overflow: hidden;
	}

	.ratio-16-9 {
		padding-bottom: 56.25%; /* 9/16*100 */
	}

	.ratio-4-3 {
		padding-bottom: 75%; /* 3/4*100 */
	}

	.ratio-3-2 {
		padding-bottom: 66.67%; /* 2/3*100 */
	}

	.ratio-1-1 {
		padding-bottom: 100%;
	}
</style>
