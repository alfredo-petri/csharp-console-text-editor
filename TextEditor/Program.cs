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
            bool showMenu = true;

            while (true)
            {
                if (showMenu)
                {
                    Console.Clear();
                    short option = MenuOptions();

                    switch (option)
                    {
                        case 0:
                            Environment.Exit(0);
                            break;
                        case 1:
                            Open();
                            showMenu = false;
                            break;
                        case 2:
                            Edit();
                            showMenu = false;
                            break;
                        default:
                            DefaultOption();
                            showMenu = false;
                            break;
                    }
                }
            }
        }


        static short MenuOptions()
        {
            Console.WriteLine("O que deseja fazer?");
            Console.WriteLine("");
            Console.WriteLine("0 - Sair da aplicação");
            Console.WriteLine("1 - Abrir um arquivo");
            Console.WriteLine("2 - Criar um arquivo");
            Console.WriteLine("");
            Console.Write("Selecione a opção desejada: ");

            short option;

            while (!short.TryParse(Console.ReadLine(), out option))
            {
                Console.Write("Entrada inválida! Digite um número válido: ");
            }

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

        static void DefaultOption()
        {
            Console.Clear();
            Console.WriteLine("Opção inválida!");
        }
    }
}