using Friable_mongo.Models;
using Friable_mongo.Services;
using Microsoft.EntityFrameworkCore;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.Configure<FriableDatabaseSettings>(
    builder.Configuration.GetSection("FriableDatabase"));

builder.Services.AddSingleton<ManifestService>();
builder.Services.AddSingleton<CollectionService>();
builder.Services.AddSingleton<AnnotationService>();
builder.Services.AddTransient<IAzureStorage,AzureStorage>();
builder.Services.AddTransient<IRegistrationRepository,RegistrationRepository>();

builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseLazyLoadingProxies().UseSqlServer(builder.Configuration.GetConnectionString("conn")));

builder.Services.AddAutoMapper(typeof(AutoMappingConfig));


builder.Services.AddControllers().AddJsonOptions(
        options => {  options.JsonSerializerOptions.DefaultIgnoreCondition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull; });
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseSwagger();


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors(builder =>
{
    builder
    .AllowAnyOrigin()
    .AllowAnyMethod()
    .AllowAnyHeader();
});

app.UseAuthorization();

app.MapControllers();

app.Run();
