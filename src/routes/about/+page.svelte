<script lang="ts">
	import nicolai from '$lib/images/nicolai.webp';
</script>

<svelte:head>
	<title>About | skovvart.dk</title>
	<meta name="description" content="About Nicolai Skovvart and Skovvart.dk" />
</svelte:head>

<h1>About</h1>

<p>
	Hi there! I'm Nicolai! <img
		src={nicolai}
		alt="Nicolai Skovvart"
		width="200"
		height="200"
		class="profile"
	/>
</p>
<p>
	I am Head of Software Engineering at the IT consulting firm Immeo, focusing on improving our technical solutions across customers and projects.
</p>
<p>
	This site is my personal playground, primarily used for small web-experiments in the .NET and web
	space (i.e., the site itself (based on sapper) and the TV-guide which is straight svelte - both
	can be found on my GitHub). As the site is not for mainstream use, I have fairly low interest in
	supporting anything but the latest modern browsers (but feel free to submit pull requests if you
	are that kind of person).
</p>
<p>
	Some times I have ambitions for blogging, but as the front-page and blogging page will tell you, I
	never really seem to get around to it. Maybe some day.
</p>

<p>Some links to some of my stuff below.</p>
<ul>
	<li>
		<a
			href="https://www.linkedin.com/in/nicolai-skovvart/"
			target="_blank"
			rel="noopener noreferrer">LinkedIn</a
		>
	</li>
	<li>
		<a href="https://www.facebook.com/skovvart" target="_blank" rel="noopener noreferrer"
			>FaceBook</a
		>
	</li>
	<li>
		<a href="https://github.com/Skovvart/" target="_blank" rel="noopener noreferrer">GitHub</a>
	</li>
	<li>
		<a
			href="https://www.youracclaim.com/users/nicolai.skovvart/badges?sort=-state_updated_at&page=1"
			target="_blank"
			rel="noopener noreferrer">Microsoft Certifications</a
		>
	</li>
</ul>

<style lang="scss">
	.profile {
		float: right;
	}
</style>
