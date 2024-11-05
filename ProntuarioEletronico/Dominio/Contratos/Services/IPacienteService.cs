using ProntuarioEletronico.Dominio.Contratos.Repositorios;
using ProntuarioEletronico.Dominio.Entidades;
using ProntuarioEletronico.Service;
using System;
using System.Collections.Generic;

namespace ProntuarioEletronico.Dominio.Contratos.Services
{
    internal interface IPacienteService
    {
        //na interface devem ficar os metodos que a classe deve ter, mas a lógica dos metodos fica na classe service, neste caso.
        //aqui fica a logica de negocio, validaçoes, cálculos, entre outros

        void CadastraPaciente(string nome, DateTime dataNascimento);
        void DeletaPacienteId(int id);
        List<Paciente> ListaPacientes();
        Paciente BuscaPorId(int id);
        void AtualizaPaciente(int id, string nome, DateTime dataNascimento);

    }
}
