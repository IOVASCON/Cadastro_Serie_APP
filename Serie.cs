using System;

namespace CadastroSeries
{
    public class Serie
    {
        // Atributos da série
        public int Id { get; private set; }
        public string Titulo { get; private set; }
        public string Genero { get; private set; }
        public string Descricao { get; private set; }
        public int Ano { get; private set; }
        public bool Ativo { get; private set; }

        // Construtor
        public Serie(int id, string titulo, string genero, string descricao, int ano)
        {
            Id = id;
            Titulo = titulo;
            Genero = genero;
            Descricao = descricao;
            Ano = ano;
            Ativo = true;
        }

        // Métodos
        public void Excluir()
        {
            Ativo = false;
        }

        public override string ToString()
        {
            return $"ID: {Id}\nTítulo: {Titulo}\nGênero: {Genero}\nDescrição: {Descricao}\nAno: {Ano}\nAtivo: {Ativo}";
        }
    }
}
