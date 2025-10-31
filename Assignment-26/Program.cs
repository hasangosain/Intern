using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Hosting;
using Microsoft.AspNetCore.Http;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// Enable serving static files (like index.html, style.css)
app.UseDefaultFiles();  // serves index.html by default
app.UseStaticFiles();

// Handle POST form submission
app.MapPost("/submit", async context =>
{
    var form = await context.Request.ReadFormAsync();

    var name = form["name"];
    var age = form["age"];
    var email = form["email"];
    var course = form["course"];

    string responseHtml = $@"
    <html>
        <head><title>Submitted Info</title></head>
        <body style='font-family:Arial; text-align:center; margin-top:50px;'>
            <h2>Student Information Submitted ✅</h2>
            <p><b>Name:</b> {name}</p>
            <p><b>Age:</b> {age}</p>
            <p><b>Email:</b> {email}</p>
            <p><b>Course:</b> {course}</p>
            <a href='/index.html'>Go Back</a>
        </body>
    </html>";

    context.Response.ContentType = "text/html";
    await context.Response.WriteAsync(responseHtml);
});

app.Run();
