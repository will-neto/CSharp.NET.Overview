namespace CSharp.NET.Overview.Core
{
    public static class ConsoleUtils
    {
        public static int UltimaEscolha = 0;
        public static bool Prosseguir = false;

        public static void Titulo(
            string texto,
            ConsoleColor foregroundColor = ConsoleColor.Yellow,
            ConsoleColor backgroundColor = ConsoleColor.Black)
        {
            Console.ForegroundColor = foregroundColor;
            Console.WriteLine(texto);
            Console.BackgroundColor = backgroundColor;
            Console.ResetColor();
        
        }


        public delegate void MetodoConsole();

        public static void InicializarConsole(MetodoConsole metodo)
        {
            do
            {
                LimpaConsole();

                metodo();

                Console.WriteLine("\n\nProsseguir? 1 - Sim | 0 - Não");

                var value = Console.ReadLine();
                int escolha;

                if (!string.IsNullOrEmpty(value) && int.TryParse(value, out escolha))
                {
                    if (escolha == 0) Prosseguir = false;
                    else Prosseguir = true;
                }

                LimpaConsole();

            }
            while (Prosseguir);
        }


        public static void LimpaConsole()
        {
            Console.WriteLine("\x1b[3J");
            Console.Clear();
        }
    }
}
