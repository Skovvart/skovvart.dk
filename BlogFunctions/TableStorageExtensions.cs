using Microsoft.Azure.Cosmos.Table;
using System.Collections.Generic;

namespace BlogFunctions
{
    public static class TableStorageExtensions
    {
        public static async IAsyncEnumerable<T> GetEntitiesFromTable<T>(this CloudTable table) where T : ITableEntity, new() {
            TableQuerySegment<T> querySegment = null;
            var query = new TableQuery<T>();

            do {
                querySegment = await table.ExecuteQuerySegmentedAsync(query, querySegment?.ContinuationToken);
                foreach (var r in querySegment.Results)
                    yield return r;
            } while (querySegment.ContinuationToken != null);
        }
    }
}