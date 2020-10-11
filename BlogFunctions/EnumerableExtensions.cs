using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Microsoft.Azure.Cosmos.Table;
using System.Collections.Generic;
using BlogFunctions.Models;
using System;

namespace BlogFunctions
{

    public static class EnumerableExtensions
    {
        public static async IAsyncEnumerable<TOut> Map<TIn, TOut>(this IAsyncEnumerable<TIn> asyncEnumerable, Func<TIn, TOut> projector) {
            await foreach (var element in asyncEnumerable)
                yield return projector(element);
        }
    }
}