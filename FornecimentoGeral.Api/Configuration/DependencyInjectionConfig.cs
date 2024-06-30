using DevIO.Business.Intefaces;
using FornecimentoGeral.Business.Interfaces;
using FornecimentoGeral.Business.Notificacoes;
using FornecimentoGeral.Business.Services;
using FornecimentoGeral.Data.Context;
using FornecimentoGeral.Data.Repository;

namespace FornecimentoGeral.Api.Configuration
{
    public static class DependencyInjectionConfig
    {
        public static IServiceCollection ResolverDependencias(this IServiceCollection services)
        {
            services.AddScoped<ContextDb>();
            services.AddScoped<IFornecedorRepository, FornecedorRepository>();
            services.AddScoped<IFornecedorService, FornecedorService>();
            services.AddScoped<IEnderecoRepository, EnderecoRepository>();
            services.AddScoped<INotificador, Notificador>();

            return services;
        }
    }
}
