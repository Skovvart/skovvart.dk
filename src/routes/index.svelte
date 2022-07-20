<script lang="ts">
	// import Card from "../components/Card.svelte";
	// import FlexWrapper from "../components/FlexWrapper.svelte";
</script>

<svelte:head>
	<title>Skovvart.dk</title>
	<meta name="description" content="A lovely description about the site." />
</svelte:head>

<h1>Skovvart.dk</h1>
<!-- <Card pixumImageId={102} /> -->
<p>
	Hi there! I'm Nicolai and this is my personal site! <img
		src="nicolai.webp"
		alt="Nicolai Skovvart"
		width="200"
		height="200"
		class="profile"
	/>
</p>
<p>
	The site is primarily an online playground for me, and probably not of much interest to anyone
	else. But feel free to take a look around!
</p>
<p>If you are looking for the <a href="https://tv.skovvart.dk">TV-guide</a>, look no further.</p>

<!-- <FlexWrapper>
  <Card pixumImageId={1049} url="services/" title="Services, man. Services." />
  <Card pixumImageId={1080} url="contact/" title="Have you ever considered contacting people?" />
</FlexWrapper> -->
<style lang="scss">
	.profile {
		float: right;
	}
</style>
