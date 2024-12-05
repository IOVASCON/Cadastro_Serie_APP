# Outras Observações

Este arquivo será utilizado para adicionar notas e pontos importantes durante o desenvolvimento.

## Objetivo

O projeto será desenvolvido usando .NET, especificamente um aplicativo de console para criar um cadastro de séries. A linguagem base do .NET nesse caso será o C#. Isso é indicado tanto pela presença da tag C# na imagem quanto pela referência ao uso de orientação a objetos, que é um ponto forte da linguagem.

Um cadastro de séries é um sistema simples usado para armazenar, gerenciar e organizar informações sobre séries de TV ou outros tipos de produções seriadas. Ele é comumente utilizado como exemplo em projetos de aprendizado para praticar conceitos de programação, como orientação a objetos e manipulação de dados.

### **Estrutura Básica de um Cadastro de Séries**

O cadastro de séries normalmente tem as seguintes funcionalidades:

1. **Adicionar Série:** Permite ao usuário inserir informações de uma nova série, como título, gênero, descrição, ano de lançamento, etc.

2. **Listar Séries:** Exibe uma lista com todas as séries cadastradas, mostrando informações básicas como título e status (ativo/inativo).

3. **Atualizar Série:** Permite editar as informações de uma série previamente cadastrada.

4. **Excluir Série:** Exclui ou marca como "inativo" uma série específica no cadastro.

5. **Visualizar Série:** Exibe detalhes completos de uma série selecionada.

### **Estrutura de Dados**

As séries são geralmente representadas como objetos em linguagens orientadas a objetos, como C#. Cada série pode conter atributos como:

- **ID:** Um identificador único para a série.
- **Título:** O nome da série.
- **Gênero:** O tipo ou categoria da série (e.g., ação, comédia, drama).
- **Descrição:** Informações adicionais sobre a série.
- **Ano de Lançamento:** O ano em que a série foi lançada.
- **Ativo/Inativo:** Um indicador de status (útil para exclusão lógica).

### **Objetivo no Aprendizado**

Um projeto como esse ajuda a consolidar:

- **Modelagem de Classes:** Representar uma série como uma classe com atributos e métodos.
- **Orientação a Objetos:** Aplicar conceitos como encapsulamento, herança e polimorfismo.
- **Coleções e Estruturas de Dados:** Usar listas, arrays ou outras coleções para armazenar os objetos.
- **Interação com o Usuário:** Criar menus para navegar entre as opções e interagir com o sistema.

Esse tipo de projeto é perfeito para aprender ou reforçar habilidades em **C#** e **.NET.**

## Script Criação Estrutura do Projeto

    #!/bin/bash

    # Caminho para a criação do projeto
    BASE_DIR="L:/VSCode/.NET/Cadastro-serie-APP"

    # Criar a estrutura principal de pastas
    mkdir -p "$BASE_DIR"
    mkdir -p "$BASE_DIR/img_dev" # Pasta para salvar prints do desenvolvimento

    # Navegar até a pasta base
    cd "$BASE_DIR" || exit

    # Inicializar o repositório Git
    git init

    # Criar arquivos e pastas principais
    echo "# Cadastro de Séries em .NET" > README.md
    echo "*.obj
    *.exe
    *.dll
    *.pdb
    bin/
    obj/
    .vscode/
    .idea/" > .gitignore

    echo "### Outras Observações
    Este arquivo pode ser utilizado para adicionar notas e pontos importantes durante o desenvolvimento." > Outras_observacoes.md

    # Inicializar o projeto .NET (se o .NET estiver instalado e configurado)
    dotnet new console --name CadastroSeries --output .

    # Mensagem de finalização
    echo "Estrutura do projeto criada com sucesso em $BASE_DIR"

## Passos para Criar a Pasta e Arquivos

1. **Crie a pasta Classes:**
        Clique com o botão direito no diretório raiz do projeto (na visualização do explorador do Visual Studio Code).
        Selecione "Nova Pasta" e nomeie como Classes.

2. **Crie os arquivos de classes:**
        Clique com o botão direito na pasta Classes que você acabou de criar.
        Selecione "Novo Arquivo" e crie os seguintes arquivos:
            Serie.cs
            SerieRepositorio.cs

3. Codifique o conteúdo das classes para os arquivos:
        Serie.cs e SerieRepositorio.cs

    CadastroSeries/
    ├── Classes/
    │   ├── Serie.cs
    │   ├── SerieRepositorio.cs
    ├── Program.cs
    ├── CadastroSeries.csproj
    ├── Outras_observacoes.md
    ├── .gitignore
    └── img_dev/

4. **Compile e execute o projeto:**

    dotnet run

## Compilação

Diferenças entre .csproj e .sln

    CadastroSeries.csproj:
        É o arquivo de configuração para o projeto específico.
        Contém informações sobre as dependências, configurações de build, framework alvo, etc.
        Compilar diretamente o arquivo .csproj irá:
            Compilar todos os arquivos .cs do projeto.
            Resolver e incluir dependências.
            Criar os binários (executável ou biblioteca).

    Cadastro-serie-APP.sln:
        É o arquivo de solução, usado para agrupar múltiplos projetos.
        Se você tivesse mais de um projeto no mesmo repositório, o .sln seria útil para compilar todos eles de uma vez.
        No seu caso, como só há um projeto, não é obrigatório usar o .sln.

o comando dotnet build CadastroSeries.csproj é suficiente para compilar o projeto, pois ele contém as informações necessárias para compilar todos os arquivos.

## Execução do Programa com Sucesso

O menu principal do Cadastro de Séries será apresentado conforme abaixo:

    Cadastro de Séries       
    Informe a opção desejada:
    1 - Listar séries        
    2 - Inserir nova série   
    3 - Atualizar série      
    4 - Excluir série        
    5 - Visualizar série     
    X - Sair

## Testando a funcionalidade do Programa

Em seguida, testar cada funcionalidade (Listar, Inserir, Atualizar, Excluir e Visualizar série) para garantir que tudo está funcionando conforme o esperado.

## Teste das Funcionalidades

Aqui está o que você pode testar em cada opção:

    Listar Séries:
        Como ainda não há séries cadastradas, o sistema deve exibir uma mensagem como "Nenhuma série cadastrada."

    Inserir Nova Série:
        Escolha esta opção e insira os dados de uma nova série (Título, Gênero, Descrição, Ano).
        Após a inserção, use a opção Listar Séries para verificar se a nova série foi cadastrada.

    Atualizar Série:
        Após cadastrar uma série, teste a atualização alterando seus dados (por exemplo, o Título ou Gênero).
        Verifique se as alterações foram aplicadas listando as séries novamente.

    Excluir Série:
        Cadastre uma série e em seguida exclua-a. Ela deve ser marcada como "inativa" (exclusão lógica).
        Use a opção Listar Séries para confirmar.

    Visualizar Série:
        Após cadastrar uma ou mais séries, visualize os detalhes completos de uma delas.

    Sair (X):
        Teste a saída do programa digitando "X".
