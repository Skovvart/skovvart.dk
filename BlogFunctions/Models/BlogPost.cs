namespace BlogFunctions.Models
{
    public class BlogPost
    {
        public string Slug { get; set;  }
        public string Title { get; set; }
        public string Body { get; set; }

        public BlogPost(BlogPostEntity blogPostEntity) : this(blogPostEntity.RowKey, blogPostEntity.Title, blogPostEntity.Body) {
        }

        public BlogPost() {} // For JSON serialization

        public BlogPost(string slug, string title, string body) {
            Slug = slug;
            Title = title;
            Body = body;
        }
    }
}