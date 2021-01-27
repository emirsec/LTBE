using Abp.Dependency;
using GraphQL.Types;
using GraphQL.Utilities;
using Lockthreat.Queries.Container;
using System;

namespace Lockthreat.Schemas
{
    public class MainSchema : Schema, ITransientDependency
    {
        public MainSchema(IServiceProvider provider) :
            base(provider)
        {
            Query = provider.GetRequiredService<QueryContainer>();
        }
    }
}