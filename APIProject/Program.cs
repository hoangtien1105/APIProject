var builder = WebApplication.CreateBuilder(args);

builder.WebHost.ConfigureKestrel(options =>
{
    options.ListenAnyIP(8080);
});

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

//Configure the HTTP request pipeline.
//if (app.Environment.IsDevelopment()) // mat day thang nao code default cai dong nay day
//{
    app.UseSwagger();
    app.UseSwaggerUI();
//}


app.UseAuthorization();

app.MapControllers();

app.Run();
