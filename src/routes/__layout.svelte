<script lang="ts">
	import Header from '../components/Header.svelte';
	import Main from '../components/Main.svelte';

	import ScrollToTop from '../components/ScrollToTop.svelte';
	import Footer from '../components/Footer.svelte';
</script>

<Header />
<Main>
	<slot />
</Main>
<ScrollToTop />
<Footer />

<style lang="scss" global>
	@import '../styles/site.scss';
</style>
