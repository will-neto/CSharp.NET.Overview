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

        Console.WriteLine("Tipos de Valor" +
            "\n");

        Console.WriteLine($"Tipo [bool] | Valor Mínimo: {variavelBooleanaFalsa} & Valor Máximo  {variavelBooleanaVerdadeira}");
        Console.WriteLine($"Tipo [byte] | Valor Mínimo: {variavelByteMinValue} & Valor Máximo : {variavelByteMaxValue}");
        Console.WriteLine($"Tipo [sbyte] | Valor Mínimo: {variavelSByteMinValue} & Valor Máximo : {variavelSByteMaxValue}");
        Console.WriteLine($"Tipo [decimal] | Valor Mínimo: {variavelDecimalMinValue} & Valor Máximo : {variavelDecimalMaxValue}");
        Console.WriteLine($"Tipo [double] | Valor Mínimo: {variavelDoubleMinValue} & Valor Máximo : {variavelDoubleMaxValue}");
        Console.WriteLine($"Tipo [float] | Valor Mínimo: {variavelFloatMinValue} & Valor Máximo : {variavelFloatMaxValue}");
        Console.WriteLine($"Tipo [int] | Valor Mínimo: {variavelIntMinValue} & Valor Máximo : {variavelIntMaxValue}");
        Console.WriteLine($"Tipo [uint] | Valor Mínimo: {variavelUIntMinValue} & Valor Máximo : {variavelUIntMaxValue}");
        Console.WriteLine($"Tipo [long] | Valor Mínimo: {variavelLongMinValue} & Valor Máximo : {variavelLongMaxValue}");
        Console.WriteLine($"Tipo [ulong] | Valor Mínimo: {variavelULongMinValue} & Valor Máximo : {variavelULongMaxValue}");
        Console.WriteLine($"Tipo [short] | Valor Mínimo: {variavelShortMinValue} & Valor Máximo : {variavelShortMaxValue}");
        Console.WriteLine($"Tipo [ushort] | Valor Mínimo: {variavelUShortMinValue} & Valor Máximo : {variavelUShortMaxValue}");
        Console.WriteLine($"Tipo [char] | Valor Mínimo: {Convert.ToInt32(variavelCharMinValue)} & Valor Máximo : {Convert.ToInt32(variavelCharMaxValue)}");

        Console.WriteLine( "\n" +
@"      
    Armazenamento Stack (Pilha): 

    - Região da memória responsável pelo armazenamento de variáveis 
    locais e dados relacionados a funções e métodos.
      
    - A área de memória chamada Stack segue a maneira de armazenamento LIFO 
    (Last-In First-out - Ultimo a entrar Primeiro a sair)
    Esse modelo de armazenamento visa remover da memória após utilização os dados que foram
    incluidos por ultimo após finalização de um processo       
    
    - Acesso direto aos dados, pois eles estão localizados onde a variável é alocada. Desta forma,
    o acesso é mais rápido.

    - Quando atribuídos a outra variável ou passados como parâmetros, uma cópia dos dados é feita.
"
        );
    }


}

