# Cadastro de Séries

Um aplicativo de console simples desenvolvido em C# e .NET, criado para gerenciar o cadastro de séries. Este projeto tem como objetivo praticar conceitos de Orientação a Objetos e manipulação de dados em memória.

## Funcionalidades

1. **Listar Séries:** Exibe todas as séries cadastradas no sistema.
2. **Inserir Nova Série** Permite adicionar uma nova série ao cadastro.
3. **Atualizar Série:** Altera os dados de uma série previamente cadastrada.
4. **Excluir Série:** Marca uma série como inativa (exclusão lógica).
5. **Visualizar Série:** Exibe os detalhes completos de uma série selecionada.

## Estrutura do Projeto

    Cadastro-serie-APP/
    ├── Classes/
    │   ├── Serie.cs               # Classe que representa uma série
    │   ├── SerieRepositorio.cs    # Repositório que gerencia as séries
    ├── Program.cs                 # Ponto de entrada do programa
    ├── CadastroSeries.csproj      # Arquivo de configuração do projeto
    ├── Outras_observacoes.md      # Observações gerais durante o desenvolvimento
    └── README.md                  # Documentação do projeto

## Tecnologias Utilizadas

    C#
    .NET 9.0
    Orientação a Objetos
    CLI do .NET

## Como Executar o Projeto

1. Certifique-se de ter o .NET SDK 9.0 (ou superior) instalado.
2. Clone este repositório para sua máquina local:

    git clone <URL_DO_REPOSITORIO>

3. Navegue até o diretório do projeto:

    cd Cadastro-serie-APP

4. Compile o projeto:

    dotnet build CadastroSeries.csproj

5. Execute o aplicativo:

    dotnet run

## Exemplo de Uso

Ao executar o programa, será exibido o seguinte menu:

Cadastro de Séries
Informe a opção desejada:
1 - Listar séries
2 - Inserir nova série
3 - Atualizar série
4 - Excluir série
5 - Visualizar série
X - Sair

## Observações

Este projeto é um exemplo básico, onde os dados são armazenados apenas em memória durante a execução do programa. Após o encerramento, os dados são descartados.

Fique à vontade para contribuir ou estender a funcionalidade para incluir persistência em banco de dados ou arquivos!
