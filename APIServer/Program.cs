WebApplication app = WebApplication.Create();
app.Urls.Add("https://localhost:3000");
app.Urls.Add("https://*:3000");
app.Urls.Add("http://10.151.169.125:3000");

app.MapGet("/", Answer);

app.MapGet("/a/", () => 
{
    return "b";
});

app.Run();


static string Answer()
{
    return "c";
}