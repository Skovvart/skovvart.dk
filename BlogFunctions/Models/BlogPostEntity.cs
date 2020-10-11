using Microsoft.Azure.Cosmos.Table;

namespace BlogFunctions.Models
{
    public class BlogPostEntity : TableEntity
    {
        public string Title { get; set; }
        public string Body { get; set; }

        public BlogPostEntity() {
        }

        public BlogPostEntity(BlogPost blogPost) {
            PartitionKey = "Entries";
            RowKey = blogPost.Slug;

            Title = blogPost.Title;
            Body = blogPost.Body;
        }
    }
}