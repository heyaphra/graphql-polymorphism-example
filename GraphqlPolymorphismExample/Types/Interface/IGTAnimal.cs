using GraphQL.Types;
using GraphqlPolymorphismExample.Data.Models;

namespace GraphqlPolymorphismExample.Types.Interface;

public class IGTAnimal : InterfaceGraphType<Animal>
{
    // TODO: Implement IGTAnimal
}

// For implementing an InterfaceGraphType, see: https://graphql-dotnet.github.io/docs/getting-started/interfaces/
// IsTypeOf is a great way of registering an InterfaceGraphType to an ObjectGraphType!
// Also see: https://www.salsify.com/blog/engineering/polymorphism-in-graphql#handling-polymorphic-responses