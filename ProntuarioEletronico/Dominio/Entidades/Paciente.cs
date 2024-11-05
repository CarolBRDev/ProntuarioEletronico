using System;

namespace ProntuarioEletronico.Dominio.Entidades
{
    internal class Paciente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public DateTime DataCadastro { get; private set; }

        public Paciente(string nome, DateTime dataNascimento)
        {
            Nome = nome;
            DataNascimento = dataNascimento;
            DataCadastro = DateTime.Now;
        }
       
        //construtor para poder atualizar o paciente sem modificar a data de cadastro
        public Paciente (int id, string nome, DateTime dataNascimento) : this(nome, dataNascimento)
        {
            Id = id;            
        }



    }
}
