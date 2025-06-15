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
            Console.WriteLine("1 - Abrir um arquivo já existente");
            Console.WriteLine("2 - Criar um novo arquivo");
            Console.WriteLine("");
            Console.Write("Selecione a opção desejada: ");

            short option;

            while (!short.TryParse(Console.ReadLine(), out option))
            {
                Console.Write("Entrada inválida! Digite um número válido: ");
            }

            return option;
        }
        static void DefaultOption()
        {
            Console.Clear();
            Console.WriteLine("Opção inválida!");
        }

        static void Open()
        {
            Console.Clear();
            Console.WriteLine("Qual é o caminho do arquivo que deseja editar?");
            Console.WriteLine();

            string path = Console.ReadLine();

            using (var file = new StreamReader(path))
            {
                string text = file.ReadToEnd();

                Console.WriteLine();
                Console.WriteLine(text);
                Console.WriteLine();
                Console.WriteLine("Pressione qualquer tecla para retornar para o menu.");
                Console.ReadLine();

                Menu();
            }
        }

        static void Edit()
        {
            Console.Clear();
            Console.WriteLine("Digite seu texto abaixo (pressione ESC a qualquer momento para sair do modo edição...)");
            Console.WriteLine("");
            string text = "";

            do
            {
                text += Console.ReadLine();
                text += Environment.NewLine;
            }

            while (Console.ReadKey().Key != ConsoleKey.Escape);

            Save(text);
        }

        static void Save(string text)
        {
            Console.Clear();
            Console.WriteLine("Qual é o caminho para salvar o arquivo?");
            var path = Console.ReadLine();

            using (var file = new StreamWriter(path))
            {
                file.Write(text);
            }

            Console.WriteLine();
            Console.WriteLine("Arquivo salvo com sucesso.");
            Console.WriteLine();

            Thread.Sleep(1000);

            Menu();

        }

    }
}