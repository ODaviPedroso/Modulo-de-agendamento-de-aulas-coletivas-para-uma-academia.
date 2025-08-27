using Aplicacao.Aplicacoes.Agendamentos;
using Aplicacao.Aplicacoes.Alunos;
using Aplicacao.Aplicacoes.Aulas;
using Microsoft.Extensions.DependencyInjection;
using AutoMapper;
using System.Reflection;

namespace Aplicacao
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddAutoMapper(cfg =>
            {
                cfg.AddMaps(Assembly.GetExecutingAssembly());
            });

            services.AddScoped<IAplicAluno, AplicAluno>();
            services.AddScoped<IAplicAula, AplicAula>();
            services.AddScoped<IAplicAgendamento, AplicAgendamento>();

            return services;
        }
    }
}
