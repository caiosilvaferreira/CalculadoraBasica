namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Menu(); // aqui chamamos a metodo com a funcao
        }

        static void Menu()
        {

            Console.WriteLine("qual calculo gostaria de realizar ? ");
            Console.WriteLine("1 - Soma.");
            Console.WriteLine("2 - subtracao.");
            Console.WriteLine("3 - divisao.");
            Console.WriteLine("4 - multiplicacao.");
            Console.WriteLine("5 - sair.");

            byte escolha = byte.Parse(Console.ReadLine());
            switch (escolha)
            {
                case 1: Soma(); break;
                case 2: Subtracao(); break;
                case 3: Divisao(); break;
                case 4: Multiplicacao(); break;
                case 5: System.Environment.Exit(0); break;
                default: Menu(); break;
                    // a funcao break tem a funcao de parar depois que funcionalidade rodar                      
            }
        }
        static void Soma()
        {
            Console.WriteLine("Digite o primeiro numero:");
            float N1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo numero:");
            float N2 = float.Parse(Console.ReadLine());

            float resultado = N1 + N2;

            Console.WriteLine($"esse e o resultado: {resultado}");
            Menu();
        }
        static void Subtracao()
        {

            Console.WriteLine("Digite o primeiro numero:");
            float N1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo numero:");
            float N2 = float.Parse(Console.ReadLine());

            float resultado = N1 - N2;

            Console.WriteLine($"esse e o resultado: {resultado}");
            Menu();
        }

        static void Divisao()
        {

            Console.WriteLine("Digite o primeiro numero: ");
            float N1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo numero: ");
            float N2 = float.Parse(Console.ReadLine());

            float resultado = N1 / N2;

            Console.WriteLine($"esse e o resultado: {resultado}");
            Menu();
        }

        static void Multiplicacao()
        {

            Console.WriteLine("Digite o primeiro numero: ");
            float N1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo numero: ");
            float N2 = float.Parse(Console.ReadLine());

            float resultado = N1 * N2;

            Console.WriteLine($"esse e o resultado: {resultado}");
            Menu();
        }
    }

}