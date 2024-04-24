using FluentValidation.AspNetCore;

using Microsoft.Extensions.DependencyModel;

using Snake.API.Data.Abstraction;

using System.Reflection;

internal class Program
{
    private static Assembly[] assemblies;
    private static void Main(string[] args)
    {
        assemblies = LoadAppDependencies();
        var builder = WebApplication.CreateBuilder(args);

        builder.Services.AddFluentValidation(options =>
        {
            options.RegisterValidatorsFromAssemblies(assemblies);
        });

        builder.Services.AddMediatR(options =>
        {
            options.RegisterServicesFromAssemblies(assemblies);
        });

        builder.Services.Scan(scan => scan.FromAssemblies(assemblies)
        .AddClasses(type =>
            type.AssignableTo(typeof(IRepository<>)))
                .AsImplementedInterfaces().WithScopedLifetime()      
        );
        // Add services to the container.

        builder.Services.AddControllers();
        // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();

        var app = builder.Build();

        // Configure the HTTP request pipeline.
        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        app.UseHttpsRedirection();

        app.UseAuthorization();

        app.MapControllers();

        app.Run();
    }

    private static Assembly[] LoadAppDependencies()
    {
        var context = DependencyContext.Default;

        return context.RuntimeLibraries.SelectMany(library =>
                library.GetDefaultAssemblyNames(context))
            .Where(assembly => assembly.FullName.Contains("Snake.API"))
            .Select(Assembly.Load)
            .ToArray();
    }
}