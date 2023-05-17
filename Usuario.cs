namespace Projeto_de_produtos
{
    public class Usuario
    {
        private int Codigo { get; set; }

        private string Nome { get; set; }

        private string Email { get; set; }

        private string Senha { get; set; }
        private DateTime DataCadastro = DateTime.Now;

        public void Cadastrar()
        {
            Console.WriteLine($"INFORME O NOME DE USUARIO:");
            this.Nome = Console.ReadLine();

            Console.WriteLine($"INFORME O E-MAIL:");
            this.Email = Console.ReadLine();

            Console.WriteLine($"INFORME A SENHA:");
            this.Senha = Console.ReadLine();

            Console.WriteLine($"Informacoes salvas!");
        }

        public void Logar(bool logado)
        {
            do
            {
            Console.WriteLine($"LOGIN:");
            Console.WriteLine($"Informe o email cadastrado:");
            string email = Console.ReadLine();
            Console.WriteLine($"Informe a senha:");
            string senha = Console.ReadLine();
            if (email == Email && senha == Senha)
            {
               logado = true;
               
            }
            else
            {
                Console.WriteLine($"Email ou senha invalido");
                
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