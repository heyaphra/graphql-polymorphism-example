using GraphiQl;
using GraphQL;
using GraphQL.Types;
using GraphqlPolymorphismExample.Data.Context;
using GraphqlPolymorphismExample.Types.Query;
using GraphqlPolymorphismExample.Types.Mutation;
using Microsoft.EntityFrameworkCore;

// For an example on secure local SQL connection string configuration, see: https://learn.microsoft.com/en-us/aspnet/core/security/app-secrets?view=aspnetcore-7.0&tabs=linux#string-replacement-with-secrets

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

// TODO: Add the GraphQL schema to the container.

// TODO: Add repository services to the container.

// TODO: Add GraphQL Interface types to the container.

// TODO: Add GraphQL Object types to the container.

// TODO: Add GraphQL Input types to the container.

// TODO: Add GraphQL Query types to the container.

// TODO:  Add GraphQL Mutations to the container.

// Add a GraphQL pipeline to the container and configure it to serialize our code-defined schema to JSON.
builder.Services.AddGraphQL(b => b.AddAutoSchema<ISchema>().AddSystemTextJson());

// Add our SQL Server connection to the container.
builder.Services.AddDbContext<AnimalsDbContext>(option =>
    option.UseSqlServer(builder.Configuration.GetConnectionString("AnimalsDbContextConnection")));

// Build it.
var app = builder.Build();

app.UseGraphiQl("/graphiql");

app.UseGraphQL<ISchema>();

// Uncomment below if you end up needing it. Remove it if not.
// app.MapControllers();

app.Run();