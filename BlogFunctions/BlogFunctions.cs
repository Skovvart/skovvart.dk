using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Microsoft.Azure.Cosmos.Table;
using System.Collections.Generic;
using BlogFunctions.Models;

namespace BlogFunctions
{
    public class BlogFunctions
    {
        [FunctionName(nameof(GetBlogPosts))]
        public IAsyncEnumerable<BlogPostReference> GetBlogPosts(
            [HttpTrigger(AuthorizationLevel.Function, "get", Route = "blogs")] HttpRequest req,
            [Table("Blog", "Entries")] CloudTable blogPostEntities
        ) => blogPostEntities.GetEntitiesFromTable<BlogPostEntity>().Map(e => new BlogPostReference(e));

        [FunctionName(nameof(GetBlogPost))]
        public BlogPost GetBlogPost(
            [HttpTrigger(AuthorizationLevel.Function, "get", Route = "blogs/{slug}")] HttpRequest req,
            string slug,
            [Table("Blog", "Entries", "{slug}")] BlogPostEntity blogPostEntity,
            ILogger log) {
            log.LogInformation(@"Blog post with slug ""{Slug}"" requested. The blog entry was found: {Success}", slug, blogPostEntity != null);
            return new BlogPost(blogPostEntity);
        }

        // Sample add: fetch("http://localhost:7071/api/blogs", { method: "POST", body: JSON.stringify({ "slug": "how-does-table-storage-work", "title": "How does table storage work?", "body": "<p>Who even knows, man?</p>" }) })
        [FunctionName(nameof(AddBlogPost))]
        [return: Table("Blog", "Entries")]
        public BlogPostEntity AddBlogPost([HttpTrigger(AuthorizationLevel.Function, "post", Route = "blogs")] BlogPost blogPost) => new BlogPostEntity(blogPost);
    }
}