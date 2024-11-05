using ProntuarioEletronico.Dominio.Contratos.Repositorios;
using ProntuarioEletronico.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ProntuarioEletronico.Infra.Repositorio
{
    internal class PacienteRepositorio : IPacienteRepositorio
    {
        //inicia a lista de pacientes
        private static List<Paciente> pacientes = new List<Paciente>();
        //inicia o contador do Id (Será automatico)
        private static int ultimoId = 0;
        public void CadastraPaciente(Paciente paciente)
        {
            paciente.Id = ultimoId++;
            pacientes.Add(paciente);
            Console.WriteLine($"Paciente {paciente.Nome} cadastrado com sucesso!");
        }

        public void DeletaPacienteId(int id)
        {
            //buscar paciente 
           Paciente pacienteParaDeletar = BuscaPorId(id);
            //se nao existe = nao existente
            if (pacienteParaDeletar == null)
            {
                Console.WriteLine("Nenhum paciente com esse Id.");
            }
            else
            {//se existe = deletar
               pacientes.Remove(pacienteParaDeletar);
                Console.WriteLine("Paciente removido com sucesso!");
            }
            
        }

        public List<Paciente> ListarPacientes()
        {
            return pacientes;
        }
        public Paciente BuscaPorId(int id)
        {
            return pacientes.FirstOrDefault(p => p.Id == id);
        }

        //public void BuscaPorNome(string nome)
        //{

        //}

        public void AtualizaPaciente(Paciente pacienteAtualizado)
        {
            //buscar paciente - ja fornece o Id junto com os dados atuais
            Paciente pacienteParaAtualizar = BuscaPorId(pacienteAtualizado.Id);
            //se nao existir
            if (pacienteParaAtualizar == null)
            { 
                Console.WriteLine("Não encontrado um paciente com esse Id");
            }
            //se existir
            else
            {
                pacienteParaAtualizar.Nome = pacienteAtualizado.Nome;                               
                pacienteParaAtualizar.DataNascimento = pacienteAtualizado.DataNascimento;
            }
        }
    }
}

