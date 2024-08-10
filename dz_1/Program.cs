using System.Text;

var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

app.Run(async context =>
{
    var path = context.Request.Path;
    var response = context.Response;
    response.ContentType = "text/html";
    if (path == "/") await context.Response.SendFileAsync("index.html");
    else if (path == "/cat1")
    {
        context.Response.Headers.ContentDisposition = "attachment; filename=cat.jpg";
        await context.Response.SendFileAsync("Images/cat11.jpg");
    }
    else if (path == "/cat2")
    {
        context.Response.Headers.ContentDisposition = "attachment; filename=cat.jpg";
        await context.Response.SendFileAsync("Images/cat12.jpg");
    }
    else if (path == "/cat3")
    {
        context.Response.Headers.ContentDisposition = "attachment; filename=cat.jpg";
        await context.Response.SendFileAsync("Images/cat13.jpg");
    }
});

app.Run();
