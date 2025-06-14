namespace TextEditor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();

            short option = MenuOptions();

            switch (option)
            {
                case 0: Environment.Exit(0); break;
                case 1: Open(); break;
                case 2: Edit(); break;
                default: Console.WriteLine("chama o menu novamente"); break;
            }
        }

        static short MenuOptions()
        {
            Console.WriteLine("O que deseja fazer?");
            Console.WriteLine("");
            Console.WriteLine("0 - Sair da aplicação");
            Console.WriteLine("1 - Abrir um arquivo");
            Console.WriteLine("3 - Criar um arquivo");
            Console.WriteLine("");
            Console.Write("Selecione a opção desejada: ");

            short option = short.Parse(Console.ReadLine());

            return option;
        }

        static void Open()
        {
            Console.WriteLine("abre um arquivo");
        }

        static void Edit()
        {
            Console.WriteLine("cria um arquivo");
        }
    }
}