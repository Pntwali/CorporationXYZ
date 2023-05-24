## The purpose of the presentation layer

is to provide the entry point to our
system so that consumers can interact with the data. We can implement
this layer in many ways, for example creating a REST API, gRPC, etc.
However, we are going to do something different from what you are
normally used to when creating Web APIs. By convention, controllers are
defined in the Controllers folder inside the main project.
Why is this a problem?
Because ASP.NET Core uses Dependency Injection everywhere, we need
to have a reference to all of the projects in the solution from the main
project. This allows us to configure our services inside the Program class.
While this is exactly what we want to do, it introduces a big design flaw.
What’s preventing our controllers from injecting anything they want inside
the constructor?
So how can we impose some more strict rules about what controllers

## DataTransferObjects

Instead of a regular class, we are using a record for DTO. This specific 
record type is known as a Positional record.
A Record type provides us an easier way to create an immutable 
reference type in .NET. This means that the Record’s instance property 
values cannot change after its initialization. The data are passed by value 
and the equality between two Records is verified by comparing the value 
of their properties.
Records can be a valid alternative to classes when we have to send or 
receive data. The very purpose of a DTO is to transfer data from one part 
of the code to another, and immutability in many cases is useful. 

## autoMapper

AutoMapper is a library that helps us with mapping objects in our 
applications. By using this library, we are going to remove the code for 
manual mapping — thus making the action readable and maintainable.

## Exception Handling

Exception handling helps us deal with the unexpected behavior of our 
system. To handle exceptions, we use the try-catch block in our code 
as well as the finally keyword to clean up our resources afterward.
Even though there is nothing wrong with the try-catch blocks in our 
Actions and methods in the Web API project, we can extract all the 
exception handling logic into a single centralized place. By doing that, we 
make our actions cleaner, more readable, and the error handling process 
more maintainable. 

## Handling Invalid Requests in a Service Layer

the result returned from the repository could be null, and this is 
something we have to handle. We want to return the NotFound response 
to the client but without involving our controller’s actions. We are going to 
keep them nice and clean as they already are.
So, what we are going to do is to create custom exceptions that we can 
call from the service methods and interrupt the flow. Then our error 
handling middleware can catch the exception, process the response, and 
return it to the client. This is a great way of handling invalid requests 
inside a service layer without having additional checks in our controllers.


## Content negotiation is one of the quality-of-life improvements we can add 
 content negotiation lets you choose or rather “negotiate” the 
content you want to get in a response to the REST API request.

## Restricting Media Types

Currently, it – the server - will default to a JSON type.
But we can restrict this behavior by adding one line to the configuration:
` builder.Services.AddControllers(config => {
config.RespectBrowserAcceptHeader = true;
config.ReturnHttpNotAcceptable = true;
}).AddXmlDataContractSerializerFormatters()
.AddApplicationPart(typeof(CompanyEmployees.Presentation.AssemblyReference).Assembly); `

## Model Binding

Our ArrayModelBinder will be triggered before an action executes. It 
will convert the sent string parameter to the IEnumerable<Guid> type, 
and then the action will be executed

## Asp.NET Core Identity

is the membership system for web applications that 
includes membership, login, and user data. It provides a rich set of 
services that help us with creating users, hashing their passwords, 
creating a database model, and the authentication overall.
That said, let’s start with the integration process.

## refresh token end-point

It is a good practice to have a separate endpoint for the refresh token 
action