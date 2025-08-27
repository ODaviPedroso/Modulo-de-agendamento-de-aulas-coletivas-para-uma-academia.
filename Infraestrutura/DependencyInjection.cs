using Dominio.Agendamentos;
using Dominio.Alunos;
using Dominio.Aulas;
using Dominio.Comuns;
using Infraestrutura.Data;
using Infraestrutura.Repositorio;
using Infraestrutura.Repositorio.Agendamentos;
using Infraestrutura.Repositorio.Alunos;
using Infraestrutura.Repositorio.Aulas;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestrutura
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("DefaultConnection");

            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseNpgsql(connectionString));

            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));

            services.AddScoped<IRepAluno, RepAluno>();
            services.AddScoped<IRepAula, RepAula>();
            services.AddScoped<IRepAgendamento, RepAgendamento>();

            return services;
        }
    }
}
