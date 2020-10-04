<script lang="ts">
  //   import Nav from "../components/Nav.svelte";
  import Header from "../components/Header.svelte";
  import Main from "../components/Main.svelte";

  import ScrollToTop from "../components/ScrollToTop.svelte";
  import Footer from "../components/Footer.svelte";
  export let segment: string;
</script>

<style lang="scss" global>
  @import "../styles/site.scss";
</style>

<Header {segment} />
<Main>
  <slot />
</Main>
<ScrollToTop />
<Footer />
