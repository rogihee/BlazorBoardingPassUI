using BoardingPassShared.Converters;
using BoardingPassShared.Helpers;
using BoardingPassShared.Models;
using BoardingPassShared.Services;
using Microsoft.AspNetCore.Http.Json;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddCors(setup =>
{
    setup.AddDefaultPolicy(policy => policy.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod());
});

// this is not working in Minimal Api's, dunno why
// builder.Services.ConfigureOptions<ConfigureJsonOptions>();
builder.Services.Configure<JsonOptions>(options => 
    {
        options.SerializerOptions.Converters.Add(new DateOnlyJsonConverter());
        options.SerializerOptions.Converters.Add(new TimeOnlyJsonConverter());
    });

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseCors();
app.UseHttpsRedirection();

var fakeService = new FakeBoardingPassService();

app.MapGet("boardingpass/{id}", (Guid id) => 
        id == BoardingPass.TestId ? fakeService.GetBoardingPass(id) : null);

app.Run();