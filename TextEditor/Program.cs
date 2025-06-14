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

            Console.WriteLine("O que deseja fazer?");
            Console.WriteLine("");
            Console.WriteLine("0 - Sair da aplicação");
            Console.WriteLine("1 - Abrir um arquivo");
            Console.WriteLine("3 - Criar um arquivo");
            Console.WriteLine("");
            Console.Write("Selecione a opção desejada: ");

            short option = short.Parse(Console.ReadLine());

            switch (option)
            {
                case 0: Console.WriteLine("saiu da aplicação"); break;
                case 1: Console.WriteLine("abre um arquivo"); break;
                case 2: Console.WriteLine("cria um arquivo"); break;
                default: Console.WriteLine("chama o menu novamente"); break;
            }
        }
    }
}