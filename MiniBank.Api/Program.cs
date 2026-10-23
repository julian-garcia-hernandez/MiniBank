var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

//GET /accounts is an endpoint
//GET is the HTTP method
///accounts is the URL path which identifies the resource being requested.
//Now we know that an endpoint requires both an HTTP method a URL path
//Together they tell the backend which operation the client wants to perform.
//POST /accounts would CREATE a new account


//Notes on REST
//REST is an architectural style
//architectural style deals with the high-level structure of a software system and
//the importants decisions about how its parts are organized and interact.
//REST is an architectural style 
//We'll talk about it in the context of web APIs
//

