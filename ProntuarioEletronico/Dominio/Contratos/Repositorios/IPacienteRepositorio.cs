﻿using ProntuarioEletronico.Dominio.Entidades;
using System;
using System.Collections.Generic;

namespace ProntuarioEletronico.Dominio.Contratos.Repositorios
{
    internal interface IPacienteRepositorio
    {
        //na interface ficam os metodos que a classe deve possuir, mas a logica dos metodos fica na classe Repositorio, nesse caso
        //aqui ficam os processos relacionados aos dados (CRUD)

        void CadastraPaciente(Paciente paciente);
        void DeletaPacienteId(int id);
        List<Paciente> ListaPacientes();
        Paciente BuscaPorId(int id);
        void AtualizaPaciente(Paciente pacienteAtualizado);



    }     
}
