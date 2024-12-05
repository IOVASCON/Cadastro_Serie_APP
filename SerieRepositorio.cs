using System.Collections.Generic;

namespace CadastroSeries
{
    public class SerieRepositorio
    {
        private List<Serie> listaSerie = new List<Serie>();

        public List<Serie> Listar()
        {
            return listaSerie;
        }

        public void Inserir(Serie serie)
        {
            listaSerie.Add(serie);
        }

        public void Atualizar(int id, Serie serie)
        {
            listaSerie[id] = serie;
        }

        public void Excluir(int id)
        {
            listaSerie[id].Excluir();
        }

        public Serie RetornarPorId(int id)
        {
            return listaSerie[id];
        }
    }
}
