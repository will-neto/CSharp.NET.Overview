bool prosseguir = true;

while (prosseguir)
{
    Console.Clear();

    Console.WriteLine(@"== Selecione o Descritivo ==
1 - Tipos de Valor
2 - Tipos de Referência
        ");

    var value = Console.ReadLine();
    int escolha;


    if (!string.IsNullOrEmpty(value) && int.TryParse(value, out escolha))
    {

        Console.Clear();

        switch (escolha)
        {
            case 1:
                TiposDados.TiposDeDadosValor();
                break;
            case 2:

                break;
            default:
                break;
        }

    }

    Console.WriteLine("\n\n Prosseguir? 1 - Sim | 0 - Não");
    
    var value2 = Console.ReadLine();
    int escolha2;

    if (!string.IsNullOrEmpty(value2) && int.TryParse(value2, out escolha2))
    {
        if(escolha2 == 0) { prosseguir = false; }
    }

}


//string variavelString = "Exemplo de string";
//Console.WriteLine($"Tipo [string] | Valor: {variavelString}");


// Valor máximo dos tipos "char" e "string"  é 65535 devido ser o valor máximo em hexadecimal (\uFFFF)


// object
// enum
//dynamic
//DateTime
//TimeSpan
//Nullable<T>


internal static class TiposDados
{
    internal static void TiposDeDadosValor()
    {
        bool variavelBooleanaFalsa = false;
        bool variavelBooleanaVerdadeira = true;
        byte variavelByteMinValue = byte.MinValue;
        byte variavelByteMaxValue = byte.MaxValue;
        sbyte variavelSByteMinValue = sbyte.MinValue;
        sbyte variavelSByteMaxValue = sbyte.MaxValue;
        char variavelCharMinValue = char.MinValue;
        char variavelCharMaxValue = char.MaxValue;
        decimal variavelDecimalMinValue = decimal.MinValue;
        decimal variavelDecimalMaxValue = decimal.MaxValue;
        double variavelDoubleMinValue = double.MinValue;
        double variavelDoubleMaxValue = double.MaxValue;
        float variavelFloatMinValue = float.MinValue;
        float variavelFloatMaxValue = float.MaxValue;
        int variavelIntMinValue = int.MinValue;
        int variavelIntMaxValue = int.MaxValue;
        uint variavelUIntMinValue = uint.MinValue;
        uint variavelUIntMaxValue = uint.MaxValue;
        long variavelLongMinValue = long.MinValue;
        long variavelLongMaxValue = long.MaxValue;
        ulong variavelULongMinValue = ulong.MinValue;
        ulong variavelULongMaxValue = ulong.MaxValue;
        short variavelShortMinValue = short.MinValue;
        short variavelShortMaxValue = short.MaxValue;
        ushort variavelUShortMinValue = ushort.MinValue;
        ushort variavelUShortMaxValue = ushort.MaxValue;

        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Variáveis de Tipo Valor");
        Console.ResetColor();

        Console.WriteLine(@"      
    É um tipo de dado que armazena diretamente seu valor real onde a variável está declarada
    
    Os tipos valores podem ser amazenados na Stack e Heap

    - Stack: São armazenados na Stack se forem variáveis locais
    - Heap: São armazenados no Heap se forem campos de instâncias (objetos tipo referência)
    
    Os tipos valores são destruídos quando saem do seu escopo

    Quando uma váriavel recebe o valor de outra variável de tipo valor, esse valor é uma cópia.
    Desta forma, serão duas variaveis com valores distintos (separados por endereços de memórias diferentes)

    O gerenciamento do endereço de memória de um Tipo Valor é feito pelo Compilador e runtime .NET
"
        );

        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Tipos de Valor");
        Console.ResetColor();


        Console.WriteLine(@$"
    Tipo [bool] | Valor Mínimo:{variavelBooleanaFalsa} & Valor Máximo {variavelBooleanaVerdadeira}
    Tipo [byte] | Valor Mínimo:{variavelByteMinValue} & Valor Máximo :{variavelByteMaxValue}"");
    Tipo [sbyte] | Valor Mínimo:{variavelSByteMinValue} & Valor Máximo :{variavelSByteMaxValue}"");
    Tipo [decimal] | Valor Mínimo:{variavelDecimalMinValue} & Valor Máximo :{variavelDecimalMaxValue}"");
    Tipo [double] | Valor Mínimo:{variavelDoubleMinValue} & Valor Máximo :{variavelDoubleMaxValue}"");
    Tipo [float] | Valor Mínimo:{variavelFloatMinValue} & Valor Máximo :{variavelFloatMaxValue}"");
    Tipo [int] | Valor Mínimo:{variavelIntMinValue} & Valor Máximo :{variavelIntMaxValue}"");
    Tipo [uint] | Valor Mínimo:{variavelUIntMinValue} & Valor Máximo :{variavelUIntMaxValue}"");
    Tipo [long] | Valor Mínimo:{variavelLongMinValue} & Valor Máximo :{variavelLongMaxValue}"");
    Tipo [ulong] | Valor Mínimo:{variavelULongMinValue} & Valor Máximo :{variavelULongMaxValue}"");
    Tipo [short] | Valor Mínimo:{variavelShortMinValue} & Valor Máximo :{variavelShortMaxValue}"");
    Tipo [ushort] | Valor Mínimo:{variavelUShortMinValue} & Valor Máximo :{variavelUShortMaxValue}"");
    Tipo [char] | Valor Mínimo:{Convert.ToInt32(variavelCharMinValue)} & Valor Máximo :{Convert.ToInt32(variavelCharMaxValue)}"");

");

        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine(@$"
    Tipo [struct]");
        Console.ResetColor();

        Console.WriteLine($@"
    É um tipo valor que permite o agrupamento de variáveis de diversos tipos");

        EstruturaDeDados estruturaDeDados = new EstruturaDeDados();
        estruturaDeDados.Variavel1 = 1;
        estruturaDeDados.Variavel2 = 1;

        unsafe
        {
            EstruturaDeDados* ponteiroStruct = &estruturaDeDados;
            long* ponteiroVariavel1 = &estruturaDeDados.Variavel1;
            long* ponteiroVariavel2 = &estruturaDeDados.Variavel2;
            int tamanhoEmBytesStruct = sizeof(EstruturaDeDados);


            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(@$"
    Alocação de Endereço de Memória");
            Console.ResetColor();

            Console.WriteLine(@$"
    - Valor da estruturaDeDados (Struct)  = {estruturaDeDados} | Endereço Inicial de Memória da estruturaDeDados = {(long)ponteiroStruct}
    - Valor da Variavel1 (long) = {estruturaDeDados.Variavel1} | Endereço Inicial de Memória da Variavel1 = {(long)ponteiroVariavel1}
    - Valor da Variavel2 (long) = {estruturaDeDados.Variavel2} | Endereço Inicial de Memória da Variavel2 = {(long)ponteiroVariavel2}
    - Tamanho em Bytes da estruturaDeDados (Struct) = Soma dos tamanhos dos seus campos = {tamanhoEmBytesStruct} bytes

    O endereço de memória apresentado é o endereço inicial da variável. Seu tamanho está relacionado ao espaço em bytes que o seu tipo ocupa
    Outro detalhe importante é entender que o Endereço Inicial de Memória da Struct (estruturaDeDados) é o mesmo do primeiro campo (Variavel1). Assim
    como seu endereço final é o endereço final do seu último campo (Variavel2)
");
        }

    }


}


public struct EstruturaDeDados
{
    public long Variavel1;

    public long Variavel2;
}
