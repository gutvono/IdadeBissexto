namespace IdadeBissexto
{
    internal class Pessoa
    {
        string nome;
        int idade;
        string profissao;

        public Pessoa(string n, int i, string p)
        {
            this.Nome = n;
            this.Idade = i;
            this.Profissao = p;
        }

        public string Nome { get => nome; set => nome = value; }
        public int Idade { get => idade; set => idade = value; }
        public string Profissao { get => profissao; set => profissao = value; }

        public int GetIdadeBissexto()
        {
            int idadeBissexto = 0;
            int anoAtual = DateTime.Now.Year;
            for (int ano = anoAtual - this.idade; ano <= anoAtual; ano++)
            {
                if (ano % 4 == 0) idadeBissexto++;
            }
            return idadeBissexto;
        }

        public void Print()
        {
            Console.WriteLine($"Seu nome é {this.nome} e sua profissão é {this.profissao} e tem {this.idade} anos.\n" +
                $"Sua idade em anos bissextos {this.GetIdadeBissexto()}.");
        }
    }
}
