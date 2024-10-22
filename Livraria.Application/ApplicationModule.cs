using Livraria.Application.Services;
using Livraria.Application.Services.Implementation;
using Microsoft.Extensions.DependencyInjection;

namespace Livraria.Application
{
    public static class ApplicationModule
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services
                .AddServices();
            return services;
        }

        private static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddScoped<ILivroService, LivroService>();
            services.AddScoped<IPedidoService, PedidoService>();
            services.AddScoped<IClienteService, ClienteService>();
            services.AddScoped<IAutorService, AutorService>();

            return services;
        }


    }
}
