using System;
using GraphQL.Types;

namespace MovieReviews.GraphQL
{
    public class MovieReviewSchema : Schema
    {
        // ReSharper disable once SuggestBaseTypeForParameter
        public MovieReviewSchema(QueryObject query, MutationObject mutation, IServiceProvider sp) : base(sp)
        {
            Query = query;
            Mutation = mutation;
        }
    }
}