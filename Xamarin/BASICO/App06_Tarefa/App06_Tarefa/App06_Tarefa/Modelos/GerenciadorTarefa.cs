﻿using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace App06_Tarefa.Modelos
{
    public class GerenciadorTarefa
    {
        private List<Tarefa> Lista { get; set; }

        public void Salvar(Tarefa tarefa)
        {
            Lista = Listagem();
            Lista.Add(tarefa);

            SalvarNoProperties(Lista);
        }

        public void Deletar(int index)
        {
            Lista = Listagem();
            Lista.RemoveAt(index);

            SalvarNoProperties(Lista);
        }

        public void Finalizar(int index, Tarefa tarefa)
        {
            Lista = Listagem();
            Lista.RemoveAt(index);

            tarefa.DataFinalizacao = DateTime.UtcNow;
            Lista.Add(tarefa);

            SalvarNoProperties(Lista);
        }


        public List<Tarefa> Listagem()
        {
            return ListagemNoProperties();
        }

        private void SalvarNoProperties(List<Tarefa> Lista)
        {
            if (App.Current.Properties.ContainsKey("Tarefas"))
            {
                App.Current.Properties.Remove("Tarefas");
            }

            string jsonVal = JsonConvert.SerializeObject(Lista);

            App.Current.Properties.Add("Tarefas", jsonVal);
        }

        private List<Tarefa> ListagemNoProperties()
        {
            if (App.Current.Properties.ContainsKey("Tarefas"))
            {
                string jsonVal = (string)App.Current.Properties["Tarefas"];
                List<Tarefa> Lista = JsonConvert.DeserializeObject<List<Tarefa>>(jsonVal);

                //return (List<Tarefa>)App.Current.Properties["Tarefas"];
                return Lista;
            }

            return new List<Tarefa>();
        }
    }
}
