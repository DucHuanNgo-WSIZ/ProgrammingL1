using ReserverApi.DataAccess;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
builder.Services.AddSingleton(options => DataMock.GetContextWithData());
var app = builder.Build();

app.UseCors(cp =>
{
    cp.AllowAnyHeader();
    cp.AllowAnyMethod();
    cp.AllowAnyOrigin();
});


app.MapControllers();

app.Run();
