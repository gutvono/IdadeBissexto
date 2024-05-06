namespace IdadeBissexto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("\nInforme seu nome:");
            string nome = Console.ReadLine();

            Console.Write("\nInforme sua idade: ");
            int idade = int.Parse(Console.ReadLine());

            Console.Write("\nInforme sua profissão: ");
            string profissao = Console.ReadLine();

            Pessoa pessoa = new(nome, idade, profissao);
            pessoa.Print();
        }
    }
}