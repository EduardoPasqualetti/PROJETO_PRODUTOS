namespace Projeto_de_produtos
{
    public class Login
    {
        public bool Logado;
        public string Usuario { get; set; }

        public string teste;


        static void BarraCarregamento(string texto, int quantidadePontinhos, int tempo)
        {
            Console.Write(texto);

            for (var i = 0; i < quantidadePontinhos; i++)
            {
                Console.Write($".");
                Thread.Sleep(tempo);
            }
        }



        public void Deslogar(string usuario)
        {
            Usuario = usuario;
        }

        public Login()
        {
            Usuario user = new Usuario();
            user.Cadastrar();
            user.Logar(Logado);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"INFORMACOES VALIDAS!");
            Console.ResetColor();
            BarraCarregamento("ENTRANDO", 6, 400);
            GerarMenu();
        }

        public void GerarMenu()
        {
            Produto produto = new Produto();
            Marca marca = new Marca();
            int opcao;

            do
            {

                Console.WriteLine(@$"
           ======================================
                      MENU DE OPÇOES 
                Escolha a opçao desejada:

            [1] - CADASTRAR PRODUTO
            [2] - LISTAR PRODUTOS
            [3] - CADASTRAR MARCA
            [4] - LISTAR MARCAS
            [5] - REMOVER UM PRODUTO
            [6] - REMOVER UMA MARCA

            [0] - SAIR DO SISTEMA

           ====================================== 
            ");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:

                        produto.Cadastrar();

                        break;
                    case 2:

                        produto.Listar();

                        break;
                    case 3:
                        Console.WriteLine($"CADASTRAR MARCA:");
                        
                        marca.CadastrarMarca();
                        break;
                    case 4:
                        marca.Listar();
                        break;
                    case 5:
                        Console.Write($"INFORME O CODIGO DO PRODUTO NA QUAL DESEJA REMOVER:");
                        int codigo = int.Parse(Console.ReadLine()); 
                        produto.Deletar(codigo);

                        break;
                    case 6:
                        Console.Write($"INFORME O CODIGO DA MARCA NA QUAL DESEJA REMOVER:");
                        int codigos = int.Parse(Console.ReadLine());
                        marca.Deletar(codigos);
                        break;
                    case 0:
                        Console.ForegroundColor = ConsoleColor.Red;
                        BarraCarregamento("SAINDO DO SISTEMA", 3, 1000);
                        Console.ResetColor();
                        break;

                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"OPCAO INVALIDA, ESCOLHA UMA OPCAO VALIDA!");
                        Console.ResetColor();
                        break;
                }
            } while (opcao != 0);

        }
    }
}