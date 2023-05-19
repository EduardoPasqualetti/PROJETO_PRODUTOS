namespace Projeto_de_produtos
{
    public class Produto
    {
        public int Codigo { get; set; }

        public string NomeProduto { get; set; }

        public float Preco { get; set; }

        private DateTime DataCadastro;

        public Marca marca = new Marca();
        public string CadastradoPor { get; set; }

        List<Produto> listaProdutos = new List<Produto>();


        public void Cadastrar()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"CADASTRAR PRODUTO:");

            Produto novoProduto = new Produto();

            bool continua = true;
            do
            {
                try
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write($"INFORME O CODIGO DO PRODUTO A CADASTRAR: ");
                    Console.ResetColor();
                    novoProduto.Codigo = int.Parse(Console.ReadLine());
                    continua = true;
                }
                catch (System.Exception)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"VOCE NAO DIGITOU UM CODIGO!");
                    Console.ResetColor();
                    continua = false;

                }
            } while (continua == false);

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write($"INFORME O NOME DO PRODUTO: ");
            Console.ResetColor();
            novoProduto.NomeProduto = Console.ReadLine();
            do
            {
                try
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write($"INFORME O PRECO DO PRODUTO: ");
                    Console.ResetColor();
                    novoProduto.Preco = float.Parse(Console.ReadLine());
                    continua = true;
                }
                catch (System.Exception)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"VOCE NAO DIGITOU UM VALOR NUMERICO!");
                    Console.ResetColor();
                    continua = false;

                }
            } while (continua == false);


            novoProduto.marca = marca.CadastrarMarca();

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write($"INFORME O NOME DO USUARIO QUE ESTA CADASTRANDO O PRODUTO: ");
            Console.ResetColor();
            novoProduto.CadastradoPor = Console.ReadLine();


            novoProduto.DataCadastro = DateTime.Now;

            listaProdutos.Add(novoProduto);



        }
        public void Listar()
        {
            if (listaProdutos.Count != 0)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"LISTA DOS PRODUTOS:");

                foreach (Produto p in listaProdutos)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(@$"
                    {listaProdutos.IndexOf(p) + 1}- 
                    CODIGO: {p.Codigo}, PRODUTO: {p.NomeProduto} 
                    PRECO DO PRODUTO: {p.Preco:c}
                    MARCA: {p.marca.NomeDaMarca} 
                    CADASTRADO POR: {p.CadastradoPor}, NA DATA: {p.DataCadastro}");
                    Console.ResetColor();
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine($"A LISTA NAO POSSUI NENHUM PRODUTO CADASTRADO!");
                Console.ResetColor();
            }
        }
        public void Deletar(int codigo)
        {

            Produto produtoEncontrado = listaProdutos.Find(x => x.Codigo == codigo);
            if (listaProdutos.Contains(produtoEncontrado))
            {
                listaProdutos.Remove(produtoEncontrado);
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine($"PRODUTO REMOVIDO COM SUCESSO!");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"A LISTA NAO POSSUI ESSE PRODUTO!");
                Console.ResetColor();
            }

        }

    }


}