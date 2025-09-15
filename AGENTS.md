# AGENTS.md

## Build, Lint, and Test Commands
This repository is a static website and does not include a build system, linter, or test framework. However, here are some general recommendations:

- **HTML Validation**: Use [W3C Validator](https://validator.w3.org/) to ensure HTML files are valid.
- **CSS Validation**: Use [W3C CSS Validator](https://jigsaw.w3.org/css-validator/) to check CSS files.
- **Accessibility Testing**: Use tools like [Lighthouse](https://developers.google.com/web/tools/lighthouse/) or [axe](https://www.deque.com/axe/) to ensure accessibility.

## Code Style Guidelines

### General
- Follow semantic HTML principles.
- Use descriptive `alt` attributes for images.
- Ensure proper meta tags for SEO and social sharing.

### Formatting
- Indent using 4 spaces.
- Use lowercase for all HTML tags and attributes.
- Close all self-closing tags (e.g., `<img />`).

### CSS
- Use CSS variables for theming (e.g., `--background-color`).
- Group related styles together.
- Avoid inline styles unless necessary.

### Naming Conventions
- Use `kebab-case` for CSS class names (e.g., `.card`, `.social-links`).
- Use meaningful and descriptive names for classes and IDs.

### Error Handling
- Include a `404.html` page for handling missing pages.
- Use meta refresh or JavaScript redirects sparingly.

### Imports
- Use relative paths for assets (e.g., `./favicon.svg`).
- Prefer modern image formats like WebP for performance.

### Accessibility
- Ensure all interactive elements are keyboard-navigable.
- Use ARIA roles where necessary.

### Comments
- Add comments to explain non-obvious code, especially for animations or complex styles.

## Notes for Agents
- This repository is primarily HTML and CSS. Ensure any changes maintain the simplicity and performance of the site.
- Validate all changes using the tools mentioned above before committing.