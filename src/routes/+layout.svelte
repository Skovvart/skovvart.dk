<script lang="ts">
	import Header from './Header.svelte';
	import Main from './Main.svelte';

	import ScrollToTop from './ScrollToTop.svelte';
	import Footer from './Footer.svelte';
	import "$lib/styles/site.scss"
</script>

<Header />
<Main>
	<slot />
</Main>
<ScrollToTop />
<Footer />
