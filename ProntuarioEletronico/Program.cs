using Microsoft.Extensions.DependencyInjection;
using ProntuarioEletronico.Dominio.Contratos.Services;
using System;

namespace ProntuarioEletronico
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var serviceProvider = Startup.InjeteDependencias();

            var pacienteService = serviceProvider.GetService<IPacienteService>();


            pacienteService.CadastraPaciente("Caroline Beatrice Ramos", new DateTime(1986, 5, 1));
            pacienteService.CadastraPaciente("Giovanni Giachini", new DateTime(1988, 11, 9));
            pacienteService.CadastraPaciente("Beatriz Ramos Giachini", new DateTime(2021, 12, 18));
            pacienteService.CadastraPaciente("Maria Antonia", new DateTime(1970, 2, 3));

            var pacientes = pacienteService.ListaPacientes();
            foreach (var paciente in pacientes)
            {
                Console.WriteLine($"Id: {paciente.Id}, Nome: {paciente.Nome}, Data de Nascimento: {paciente.DataNascimento}.");
            }

            var buscarPaciente = pacienteService.BuscaPorId(1);

            pacienteService.DeletaPacienteId(4);

            var pacientesPosDeletar = pacienteService.ListaPacientes();
            foreach (var paciente in pacientes)
            {
                Console.WriteLine($"Id: {paciente.Id}, Nome: {paciente.Nome}, Data de Nascimento: {paciente.DataNascimento}.");
            }


            //o que eu gostaria de fazer e ainda falta: montar menu, conferir que nao temos pacientes repetidos, quando excluir um nome, rearrumar a ordem ou acrescentar o proximo paciente no primeiro id vago, criar buca por nome, montar menu que quando algum dado nao estiver correto ele retorne para onde estava (como se ao cadastrar paciente o nome estiver em branco ou data de nascimento muito antiga ou no futuro, ele avisar e solicitar novamente o dado que estava incorreto)
        }
    }
}
