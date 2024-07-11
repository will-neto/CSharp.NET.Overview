
using CSharp.NET.Overview.Core;

ConsoleUtils.InicializarConsole(Execucao);

static void Execucao()
{
    int escolha;
    string value;

    Console.WriteLine(@"1 - Explicação sobre Métodos
2 - Tipos de Métodos
");

    value = Console.ReadLine()!;


    if (!string.IsNullOrEmpty(value) && int.TryParse(value, out escolha))
    {

        ConsoleUtils.LimpaConsole();

        switch (escolha)
        {
            case 1:
                Explicacao();
                break;
            case 2:
                break;
            default:
                break;
        }

    }
}

static void Explicacao() {

    ConsoleUtils.Titulo(@"Função");

    Console.WriteLine(@"
    No contexto geral, Função é um conceito matemático, relacionado a um conjunto de entradas
    e saídas.

    Na programação, uma função é um bloco de código, onde pode ou não aceitar entradas (argumentos)
    e pode ou não retornar um valor (diferente da função matemática onde se é necessário ao menos
    uma entrada e saída). O propósito de uma função é justamente a execução de instruções (códigos).
    Porém, além deste seu objetivo principal, se olharmos de forma menos objetiva, podemos ver que
    a função também tem benefícios como a reutilização de código (centralizando um código que pode
    ser chamado inúmeras vezes no sistema), legibilidade (através da nomenclatura da função podemos
    ter um entendimento melhor o propósito de um bloco de códigos), organização (deixando os códigos
    organizados de maneira clara e objetiva).

    Podemos entender também como uma função como algo que irá ou não alterar o estado de algo. Podendo
    ser um bloco de código que é disparado para executar 
        - Uma Ação: realizar um cálculo matemático, incluir o nome de um usuário, validar se o nome não
        possui 1000 caracteres, etc.
        - Uma Operação: um conjunto de Ações/Etapas que representam uma Ação maior, como
        por exemplo Salvar um Usuário, onde existem etapas (ações mencionadas anteriormente) como essas abaixo:
            - Ação de Incluir o nome de um usuário
            - Ação de Abrir a conexão com o banco de dados ou arquivo onde o usuário será salvo
            - Ação de Salvar o usuário no banco de dados ou arquivo
        - Um Evento: representa algum evento que pode ter ocorrido no sistema, como por exemplo, um método que é
        chamado devido um clique de botão em tela, ou um método que é chamado sempre que o sistema disparar um
        erro em código que não foi tratado pelo programador que o escreveu.

");


    ConsoleUtils.Titulo(@"Métodos");

    Console.WriteLine(@"
    De modo resumido, os métodos são funções. Porém, a única particularidade que nos permite chamarmos um
    uma função de método é o fato de que um método sempre pertencerá a uma Classe (um tipo de estrutura
    personalizada que nos permite criar objetos de tipos variados e que dá bastante enfâse ao conceito
    de Orientação a Objetos).

    O significado de um método é bastante explícito e seu propósito está sempre bem atrelado a classe ou escopo
    ao qual ele pertence. Desta forma, é de extrema importância que o nome de um método faça bastante
    sentido à classe que ele pertence. Por exemplo, um método (não esquecer que também é uma função)
    ""Miar"" deve estar atrelada a um Gato, certo? Um método ""Latir"" a um cachorro. Um método ""DispararEmail""
    a um Serviço de E-mails.
");

    ConsoleUtils.Titulo(@"
    Outro ponto importante é entendermos que no C# chamamos de métodos todas as funções, tendo em vista que sempre
    teremos uma função atrelada a uma Classe.

", ConsoleColor.Cyan);

    ConsoleUtils.Titulo(@"Armazenamento");

    Console.WriteLine(@"
    Durante a compilação e execução de um programa/aplicação, os métodos pertecentes ficam alocados em uma área da
    memória chamada ""Área de Código"" (Code Section). Este espaço na memória contém o código compilado em linguagem
    de máquina. As variáveis/objetos dentro das variáveis vão para as áreas de memórias Stack ou Heap dependendo do
    contexto em que são chamados.
");

    ConsoleUtils.Titulo(@"Assinatura de um método");

    Console.WriteLine(@"
    A declaração/assinatura de um método consiste em

    (modificador-de-acesso) [static] (retorno) (nome-do-metodo) ((parametros))

    Exemplo de declaração de método:

        public static void NomeDoMetodo (int parametro1) {
            ... Código do método
        }    
");

    ConsoleUtils.Titulo(@"
        Modificador de Acesso
    ", ConsoleColor.Magenta);

    Console.WriteLine(@"
        Uma palavra-chave que define o nível de acesso a um método (também podem ser usados em outros componentes como classes).
        public - Permite acesso ao método em qualquer lugar, dentro ou fora da classe onde o método está declarado.
        private - Restringe o acesso apenas uso interno da classe onde está declarado.
        protected - Permite acesso interno (própria classe) ou para sub-classes (classes derivadas/classes filhas)
        internal - Acessível apenas dentro do mesmo assembly (conjunto de arquivos .dll ou .exe compilados juntos);
            Podendo ser acessível dentro do mesmo projeto ou namespace.
        protected internal - Permite acesso a classes derivadas e dentro do mesmo Assembly
        private protected - Permite acesso interno (própria classe) ou a classes derivadas e dentro do mesmo Assembly (a partir do C# 7.2).
    ");

}

