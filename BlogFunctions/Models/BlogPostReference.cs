namespace BlogFunctions.Models
{
    public class BlogPostReference
    {
        public string Slug { get; }
        public string Title { get; }

        public BlogPostReference(BlogPostEntity blogPostEntity) : this(blogPostEntity.RowKey, blogPostEntity.Title) {
        }

        public BlogPostReference(string slug, string title) {
            Slug = slug;
            Title = title;
        }
    }
}