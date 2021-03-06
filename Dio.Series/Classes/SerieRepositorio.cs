using Dio.Series.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dio.Series.Classes
{
    public class SerieRepositorio : IRepositorio<Serie>
        // o T da interface será substituida pela classe Serie
    {
        private List<Serie> ListaSerie = new List<Serie>();

        public void Atualizar(int id, Serie objeto)
        {
            ListaSerie[id] = objeto;
        }

        public void Exclui(int id)
        {
            ListaSerie[id].Excluir();
        }

        public void Insere(Serie objeto)
        {
            ListaSerie.Add(objeto);
        }

        public List<Serie> Lista()
        {
            return ListaSerie;
        }

        public int ProximoId()
        {
            return ListaSerie.Count;
        }

        public Serie RetornaPorId(int id)
        {
            return ListaSerie[id];
        }
    }
}
