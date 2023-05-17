namespace Projeto_de_produtos
{
    public class Produto
    {
        public int Codigo { get; set; }

        public string NomeProduto { get; set; }

        public float Preco { get; set; }

        private DateTime DataCadastro;

        public int CodigoMarca { get; set; }
        public string NomeMarca { get; set; }

        public string CadastradoPor { get; set; }

        List<Produto> listaProdutos = new List<Produto>();


        public void Cadastrar()
        {
            Console.WriteLine($"CADASTRAR PRODUTO:");
            Produto novoProduto = new Produto();

            Console.WriteLine($"INFORME O CODIGO DO PRODUTO A CADASTRAR:");
            novoProduto.Codigo = int.Parse(Console.ReadLine());

            Console.WriteLine($"INFORME O NOME DO PRODUTO:");
            novoProduto.NomeProduto = Console.ReadLine();

            Console.WriteLine($"INFORME O PRECO DO PRODUTO:");
            novoProduto.Preco = float.Parse(Console.ReadLine());
            
            Console.WriteLine($"INFORME O CODIGO DA MARCA DESSE PRODUTO:");
            novoProduto.CodigoMarca = int.Parse(Console.ReadLine());

            Console.WriteLine($"INFORME O NOME DA MARCA:");
            novoProduto.NomeMarca = Console.ReadLine();



            Console.WriteLine($"INFORME O NOME DO USUARIO QUE ESTA CADASTRANDO O PRODUTO:");
            novoProduto.CadastradoPor = Console.ReadLine();

            novoProduto.DataCadastro = DateTime.Now;

            listaProdutos.Add(novoProduto);


        }
        public void Listar()
        {
            if (listaProdutos.Count != 0)
            {
                    Console.WriteLine($"LISTA DOS PRODUTOS:");
                    
                foreach (Produto p in listaProdutos)
                {
                    Console.WriteLine(@$"
                    {listaProdutos.IndexOf(p) + 1}- CODIGO: {p.Codigo}, PRODUTO: {p.NomeProduto} 
                    MARCA: {p.NomeMarca} CODIGO DA MARCA: {p.CodigoMarca}  
                    PRECO DO PRODUTO: {p.Preco:c} 
                    CADASTRADO POR: {p.CadastradoPor}, NA DATA: {p.DataCadastro}");
                }
            }
            else
            {
                Console.WriteLine($"A LISTA NAO POSSUI NENHUM PRODUTO CADASTRADO!");

            }
        }
        public void Deletar(int codigo)
        {

            Produto produtoEncontrado = listaProdutos.Find(x => x.Codigo == codigo);

            listaProdutos.Remove(produtoEncontrado);
            Console.WriteLine($"PRODUTO REMOVIDO!");
            
        }
    
}


}