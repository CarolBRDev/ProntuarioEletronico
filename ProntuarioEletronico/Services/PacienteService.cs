using ProntuarioEletronico.Dominio.Contratos.Repositorios;
using ProntuarioEletronico.Dominio.Contratos.Services;
using ProntuarioEletronico.Dominio.Entidades;
using System;
using System.Collections.Generic;

namespace ProntuarioEletronico.Service
{
    internal class PacienteService : IPacienteService
    {
        private readonly IPacienteRepositorio _pacienteRepositorio;

        public PacienteService(IPacienteRepositorio pacienteRepositorio)
        {
            _pacienteRepositorio = pacienteRepositorio;
        }

        public void CadastraPaciente(string nome, DateTime dataNascimento)
        {
            //verifica se o nome está em braco ou tem menos de 3 caracteres
            if (string.IsNullOrWhiteSpace(nome) || (nome.Length < 3))
            {
                Console.WriteLine("Nome inválido. O nome não pode estar em branco e deve conter ao menos três caracteres.");
                return;
            }

            //verifica se a data de nascimento não é uma data futura
            if (dataNascimento > DateTime.Now)
            {
                Console.WriteLine("A data de nascimento não pode ser uma data futura.");
                return;
            }

            //instancia um paciente
            var novoPaciente = new Paciente(nome, dataNascimento);                      

            //chama a função do repositorio para gravar o paciente na lista/banoc de dados
            _pacienteRepositorio.CadastraPaciente(novoPaciente);
        }

        public void DeletaPacienteId(int id)
        {
            if (id <= 0)
            {
                Console.WriteLine("Id inválido. O valor do Id precisa ser maior que 0.");
                return;
            }
            _pacienteRepositorio.DeletaPacienteId(id);
        }


        public List<Paciente> ListaPacientes()
        {
            return _pacienteRepositorio.ListaPacientes();
        }



        public Paciente BuscaPorId(int id)
        {
            if (id <= 0)
            {
                Console.WriteLine("Id inválido. O valor do Id precisa ser maior que 0.");
                return null;
            }

            return _pacienteRepositorio.BuscaPorId(id);
        }



        public void AtualizaPaciente(int id, string nome, DateTime dataNascimento)
        {

            if (id <= 0)
            {
                Console.WriteLine("Id inválido. O valor do Id precisa ser maior que 0.");
                return;
            }

            var pacienteAtualizado = new Paciente(id, nome, dataNascimento);
            _pacienteRepositorio.AtualizaPaciente(pacienteAtualizado);
        }





    }
}
