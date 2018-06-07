using Biblioteca.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Biblioteca.Helpers
{
    public static class Calcula
    {
        public static decimal ValorEmprestimoLivro(Emprestimo emprestimo)
        {
            decimal valorEmprestimo = 1m;
            if(DateTime.Compare(emprestimo.DataDeEntregaDoLivro, emprestimo.DataDevolucao) > 0)
            {
                valorEmprestimo += MultaAtrasoDevolucao(emprestimo.DataDeEntregaDoLivro, emprestimo.DataDevolucao);
            }
            return valorEmprestimo;
        }

        private static decimal MultaAtrasoDevolucao(DateTime dataDeEntregaDoLivro, DateTime dataDevolucao)
        {
            var numeroDias = (dataDeEntregaDoLivro - dataDevolucao).TotalDays;
            int valorPorDia = 2;
            return Convert.ToDecimal(numeroDias * valorPorDia);
        }
    }
}