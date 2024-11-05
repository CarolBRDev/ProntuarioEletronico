using Microsoft.Extensions.DependencyInjection;
using ProntuarioEletronico.Dominio.Contratos.Repositorios;
using ProntuarioEletronico.Dominio.Contratos.Services;

using ProntuarioEletronico.Infra.Repositorio;
using ProntuarioEletronico.Service;

namespace ProntuarioEletronico
{
    internal class Startup
    {
        public static void InjeteDependencias()
        {
            ServiceCollection services = new ServiceCollection();
            services.AddScoped<IPacienteRepositorio, PacienteRepositorio>();
            services.AddScoped<IPacienteService, PacienteService>();
            
        }
    }
}
