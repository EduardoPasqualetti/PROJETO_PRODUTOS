namespace Projeto_de_produtos
{
    public class Usuario
    {
        private int Codigo { get; set; }

        private string Nome { get; set; }

        private string Email { get; set; }

        private string Senha { get; set; }
        private DateTime DataCadastro = DateTime.Now;


        static void BarraCarregamento(string texto, int quantidadePontinhos, int tempo)
        {
            Console.Write(texto);

            for (var i = 0; i < quantidadePontinhos; i++)
            {
                Console.Write($".");
                Thread.Sleep(tempo);
            }
        }


        public void Cadastrar()
        {
            BarraCarregamento("ENTRANDO NO SISTEMA", 5, 400);
            Console.WriteLine($"");
            Console.WriteLine($"");
            Console.WriteLine(@$"
             TELA DE CADASTRO: 
            ___________________
            ");
            Console.WriteLine($"");
            Console.WriteLine($"INFORME O NOME DE USUARIO:");
            this.Nome = Console.ReadLine();
            bool validacao;
            do
            {
                Console.WriteLine($"INFORME O E-MAIL:");
                this.Email = Console.ReadLine();
                if (Email.Contains("@"))
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"EMAIL VALIDO");
                    Console.ResetColor();
                    validacao = true;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"EMAIL INVALIDO! O E-MAIL DEVE POSSUIR '@' ");
                    Console.ResetColor();
                    validacao = false;
                }
            } while (validacao == false);

            do
            {

            Console.WriteLine($"INFORME A SENHA: (Minimo de 5 e maximo de 12 caracteres.)");
            this.Senha = Console.ReadLine();
            if (Senha.Length >= 5 && Senha.Length <= 12)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"SENHA VALIDA");
                Console.ResetColor();
                validacao = true;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"SENHA INVALIDA, NAO ATENDE AOS REQUISITOS!");
                Console.ResetColor();
                validacao = false;
            }
            } while (validacao == false);


            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"INFORMACOES SALVAS!");
            Console.ResetColor();
        }

        public void Logar(bool logado)
        {
            do
            {

                Console.WriteLine(@$"
             TELA DE LOGIN: 
            ________________
            ");
                Console.WriteLine($"INFORME O E-MAIL CADASTRADO::");
                string email = Console.ReadLine();
                Console.WriteLine($"INFORME A SENHA:");
                string senha = Console.ReadLine();
                if (email == Email && senha == Senha)
                {
                    logado = true;

                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"EMAIL OU SENHA INVALIDO!");
                    Console.ResetColor();

                }
            } while (logado != true);
        }
        public void Deletar()
        {
            this.Nome = "";
            this.Email = "";
            this.Senha = "";
            this.DataCadastro = DateTime.Parse("0000-00-00T00:00:00");

        }
    }
}