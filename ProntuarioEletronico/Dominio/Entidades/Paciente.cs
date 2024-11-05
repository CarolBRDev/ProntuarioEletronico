using System;

namespace ProntuarioEletronico.Dominio.Entidades
{
    internal class Paciente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public DateTime DataCadastro { get; set; }

        public Paciente(string nome, DateTime dataNascimento)
        {
            Nome = nome;
            DataNascimento = dataNascimento;
            DataCadastro = DateTime.Now;
        }
       




    }
}
