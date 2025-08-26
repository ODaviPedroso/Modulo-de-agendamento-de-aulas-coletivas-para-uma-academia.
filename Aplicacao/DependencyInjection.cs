using Aplicacao.Aplicacoes.Alunos;
using Microsoft.Extensions.DependencyInjection;

namespace Aplicacao
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddScoped<IAplicAluno, AplicAluno>();
            return services;
        }
    }
}
