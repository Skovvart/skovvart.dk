<script lang="ts">
  import ResponsiveContainer from "./ResponsiveContainer.svelte";
  import LinkButton from "./LinkButton.svelte";
  export let url: string = "about/";
  export let title: string = "Hi man";
  export let description: string =
    "Do you ever even feel as to know how why it be like?";
  export let callToAction: string = "Click my button, baby!";
  export let pixumImageId: Number = 149;
</script>

<style lang="scss">
  @import "../styles/theme.scss";
  .card {
    border: 0.1em solid var(--color-primary);
    border-radius: 1em;
    box-shadow: 0.1em 0.1em 0.01em 0.01em var(--color-secondary);
    overflow: hidden;
    padding: 1em 2em;
    margin-bottom: 1em;
    a:focus-within {
      .card__image {
        border: 3px solid #{$color-light};
      }
    }
    &__image {
      width: 100%;
    }
  }
</style>

<div class="card">
  <a href={url} aria-label={callToAction} rel="prefetch">
    <ResponsiveContainer ratio="3-2">
      <picture>
        <source
          type="image/webp"
          sizes="(min-width: 810px) 662px, calc(100vw - 8em)"
          srcset="https://picsum.photos/id/{pixumImageId}/1200/800.webp 1200w, https://picsum.photos/id/{pixumImageId}/600/400.webp 600w, https://picsum.photos/id/{pixumImageId}/300/200.webp 300w, https://picsum.photos/id/{pixumImageId}/200/133.webp 200w" />
        <source
          sizes="(min-width: 810px) 662px, calc(100vw - 8em)"
          srcset="https://picsum.photos/id/{pixumImageId}/600/400.jpg 600w, https://picsum.photos/id/{pixumImageId}/300/200.jpg 300w, https://picsum.photos/id/{pixumImageId}/200/133.jpg 200w" />
        <img
          src="https://picsum.photos/id/{pixumImageId}/600/400.jpg"
          alt=""
          class="card__image"
          loading="lazy"
          height="600"
          width="400" />
      </picture>
    </ResponsiveContainer>
  </a>
  <h2>{title}</h2>
  <p>{description}</p>
  <LinkButton {url} buttonText={callToAction} />
</div>
