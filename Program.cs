using System;
using CadastroSeries; // Inclua isso para acessar a classe SerieRepositorio

namespace CadastroSeries
{
    class Program
    {
        static SerieRepositorio repositorio = new SerieRepositorio();

        static void Main(string[] args)
        {
            string opcaoUsuario = ObterOpcaoUsuario();

            while (opcaoUsuario.ToUpper() != "X")
            {
                switch (opcaoUsuario)
                {
                    case "1":
                        ListarSeries();
                        break;
                    case "2":
                        InserirSerie();
                        break;
                    case "3":
                        AtualizarSerie();
                        break;
                    case "4":
                        ExcluirSerie();
                        break;
                    case "5":
                        VisualizarSerie();
                        break;
                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }

                opcaoUsuario = ObterOpcaoUsuario();
            }

            Console.WriteLine("Obrigado por utilizar o sistema!");
        }

        private static void ListarSeries()
        {
            Console.WriteLine("Listar séries");

            var lista = repositorio.Listar();

            if (lista.Count == 0)
            {
                Console.WriteLine("Nenhuma série cadastrada.");
                return;
            }

            foreach (var serie in lista)
            {
                Console.WriteLine($"ID: {serie.Id} - Título: {serie.Titulo} {(serie.Ativo ? "" : "(Excluída)")}");
            }
        }

        private static void InserirSerie()
        {
            Console.WriteLine("Inserir nova série");

            Console.Write("Digite o título: ");
            string titulo = Console.ReadLine() ?? "";

            Console.Write("Digite o gênero: ");
            string genero = Console.ReadLine() ?? "";

            Console.Write("Digite a descrição: ");
            string descricao = Console.ReadLine() ?? "";

            Console.Write("Digite o ano: ");
            int ano = int.Parse(Console.ReadLine() ?? "0");

            Serie novaSerie = new Serie(repositorio.Listar().Count, titulo, genero, descricao, ano);

            repositorio.Inserir(novaSerie);
        }

        private static void AtualizarSerie()
        {
            Console.Write("Digite o ID da série: ");
            int id = int.Parse(Console.ReadLine() ?? "0");

            Console.Write("Digite o título: ");
            string titulo = Console.ReadLine() ?? "";

            Console.Write("Digite o gênero: ");
            string genero = Console.ReadLine() ?? "";

            Console.Write("Digite a descrição: ");
            string descricao = Console.ReadLine() ?? "";

            Console.Write("Digite o ano: ");
            int ano = int.Parse(Console.ReadLine() ?? "0");

            Serie novaSerie = new Serie(id, titulo, genero, descricao, ano);

            repositorio.Atualizar(id, novaSerie);
        }

        private static void ExcluirSerie()
        {
            Console.Write("Digite o ID da série: ");
            int id = int.Parse(Console.ReadLine() ?? "0");

            repositorio.Excluir(id);
        }

        private static void VisualizarSerie()
        {
            Console.Write("Digite o ID da série: ");
            int id = int.Parse(Console.ReadLine() ?? "0");

            var serie = repositorio.RetornarPorId(id);

            Console.WriteLine(serie);
        }

        private static string ObterOpcaoUsuario()
        {
            Console.WriteLine();
            Console.WriteLine("Cadastro de Séries");
            Console.WriteLine("Informe a opção desejada:");

            Console.WriteLine("1 - Listar séries");
            Console.WriteLine("2 - Inserir nova série");
            Console.WriteLine("3 - Atualizar série");
            Console.WriteLine("4 - Excluir série");
            Console.WriteLine("5 - Visualizar série");
            Console.WriteLine("X - Sair");

            string opcaoUsuario = Console.ReadLine() ?? "";
            Console.WriteLine();
            return opcaoUsuario;
        }
    }
}
