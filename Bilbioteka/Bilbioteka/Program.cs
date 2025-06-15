using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using BibliotekaNet8.Dane;
using BibliotekaNet8.Formularze;

ApplicationConfiguration.Initialize();

var builder = Host.CreateApplicationBuilder(args);

builder.Configuration.AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

builder.Services.AddDbContext<BibliotekaContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("PolaczenieBiblioteka")));

using IHost host = builder.Build();
var services = host.Services;

Application.Run(ActivatorUtilities.CreateInstance<FormularzGlowny>(services));
