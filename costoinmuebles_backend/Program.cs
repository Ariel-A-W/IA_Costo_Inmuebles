using costoinmuebles_backend.Application.UsesCases.Casas;
using costoinmuebles_backend.Application.UsesCases.Localidades;
using costoinmuebles_backend.Application.UsesCases.TiposCasas;
using costoinmuebles_backend.Domain.Casas;
using costoinmuebles_backend.Domain.Localidades;
using costoinmuebles_backend.Domain.TiposCasas;
using costoinmuebles_backend.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddScoped<ILocalidad, LocalidadRepository>();
builder.Services.AddScoped<LocalidadesUseCase>();

builder.Services.AddScoped<ITipoCasa, TiposCasasRepository>();
builder.Services.AddScoped<TiposCasasUseCase>();

builder.Services.AddScoped<ICasa, CasasRepository>();
builder.Services.AddScoped<CasasUseCase>();

builder.Services.AddSwaggerGen(options =>
    options.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo
    {
        Title = "API Predicir Precio de una Vivienda",
        Version = "v1",
        Description = "Esta API permite predecir el costo de las viviendas haciendo uso de Inteligencia Artificial.",
        Contact = new Microsoft.OpenApi.Models.OpenApiContact
        {
            Name = "Ariel Alejandro Wagner",
            Email = "arqdev.arielalejandro@gmail.com",
            Url = new Uri("https://www.linkedin.com/in/ariel-alejandro-w-a4834075/"),
        },
        License = new Microsoft.OpenApi.Models.OpenApiLicense
        {
            Name = "MIT License",
            Url = new Uri("https://opensource.org/licenses/MIT"),
        }
    })
);

var app = builder.Build();

// Enable middleware to serve generated Swagger as a JSON endpoint
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// Configure the HTTP request pipeline.
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
