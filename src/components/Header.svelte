<script lang="ts">
	import { page } from '$app/stores';
	$: segment = $page.url.pathname;
</script>

<header class="header">
	<a href="/" class="header__logo" aria-label="Navigate back to the start page" sveltekit:prefetch>
		<svg xmlns="http://www.w3.org/2000/svg" viewBox="0 0 512 512">
			<path
				d="M510.432 249.597L388.297 38.537c-2.096-3.631-5.967-5.378-10.159-5.378H133.861c-4.192 0-8.063 1.747-10.159 5.378L1.567 249.841c-2.09 3.631-2.09 7.976 0 11.607l122.135 211.535c2.096 3.632 5.967 5.858 10.159 5.858h244.276c4.192 0 8.063-2.288 10.159-5.919l122.135-211.569c2.092-3.631 2.092-8.125.001-11.756zM371.369 455.384H140.63L25.27 256.003 140.63 56.616h230.738l115.36 199.387-115.359 199.381z"
			/>
		</svg>
		<span class="header__logo-text">Skovvart</span>
	</a>
	<nav class="header-navigation">
		<!-- <a
			aria-current={segment.startsWith('/blog') ? 'page' : undefined}
			class="header-navigation__item"
			href="/blog/"
			sveltekit:prefetch
		>
			Blog
		</a> -->
		<a
			aria-current={segment === '/about' ? 'page' : undefined}
			class="header-navigation__item"
			href="/about/"
			sveltekit:prefetch
		>
			About
		</a>
		<a
			aria-current={segment === '/services' ? 'page' : undefined}
			class="header-navigation__item"
			href="/services/"
			sveltekit:prefetch
		>
			Services
		</a>
		<a class="header-navigation__item" href="https://tv.skovvart.dk">TV-guide</a>
	</nav>
</header>

<style lang="scss">
	@import '../styles/theme.scss';
	.header {
		width: 100%;
		display: flex;
		justify-content: space-between;
		place-items: center;
		padding: 2em 3em;
		&__logo {
			display: flex;
			place-items: center;
			justify-content: center;
			flex-wrap: wrap;

			&:focus {
				outline: 3px solid #{$color-light};
			}

			&-text {
				color: #{$color-light};
				margin-right: 1em;
				font-size: 1.5em;
				font-family: 'Roboto Slab', serif;
				text-transform: uppercase;
			}
			&:focus-within,
			&:hover {
				svg {
					transform: rotate(180deg);
				}
			}
			svg {
				margin-right: 1em;
				height: 50px;
				width: 50px;
				fill: #{$color-light};

				transition: transform 0.3s ease-in-out;
			}
		}
	}

	.header-navigation {
		display: flex;
		justify-content: space-between;
		flex-direction: row;
		flex-wrap: wrap;
		flex-basis: 50%;
		&__item {
			color: #{$color-light};
			padding: 0.5em 0.5em;
			border-bottom: 3px solid transparent;
			&[aria-current] {
				border-bottom: 3px solid var(--color-secondary);
			}
			&:hover {
				border-bottom: 3px solid #{$color-light};
			}
			&:focus {
				outline: 3px solid #{$color-light};
			}
			&:active {
				position: relative;
				top: 0.1em;
			}
		}
	}
</style>
