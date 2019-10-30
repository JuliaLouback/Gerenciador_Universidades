﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Universidade.Arquivo;
using Universidade.Entidades;

namespace Universidade.DAO
{
    class DaoFuncionario
    {
        private static List<Funcionario> listaFuncionarios = new List<Funcionario>();
        Arquivos arquivos = new Arquivos();

        public void addFuncionario(Funcionario funcionario)
        {
            listaFuncionarios.Add(funcionario);
            arquivos.SalvarFuncionario(listaFuncionarios);
        }

        public void lerFuncionarios(List<Funcionario> funcionarios)
        {
            listaFuncionarios = funcionarios;
            arquivos.SalvarFuncionario(listaFuncionarios);
        }

        public List<Funcionario> listarFuncionarios()
        {
            return listaFuncionarios;
        }

        public void excluirFuncionario(int item)
        {
            listaFuncionarios.RemoveAll(x => x.NR == item);
            arquivos.SalvarFuncionario(listaFuncionarios);
        }

        public Funcionario procurarFuncionario(int item)
        {
            Funcionario funcionario = listaFuncionarios.Find(x => x.NR == item);
            return funcionario;
        }
        public Funcionario procurarFuncionarioNome(string item)
        {
            Funcionario funcionario = listaFuncionarios.Find(x => x.Nome == item);
            return funcionario;
        }

    }
}
