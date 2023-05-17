namespace Projeto_de_produtos
{
    public class Marca
    {
        public int CodigoDaMarca;

        public string NomeDaMarca;

        private DateTime DataCadastro;

        List<Marca> listaMarcas = new List<Marca>();

        public Marca()
        {

        }
        public Marca(int codigo, string nome)
        {
            Marca nova = new Marca();
            nova.CodigoDaMarca = codigo;
            nova.NomeDaMarca = nome;
            nova.DataCadastro = DateTime.Now;
            listaMarcas.Add(nova);
        }
        public void Cadastrar()
        {
            Marca nova = new Marca();
            Console.WriteLine($"CADASTRAR UMA MARCA:");

            Console.WriteLine($"INFORME O CODIGO DA MARCA A REGISTRAR::");
            nova.CodigoDaMarca = int.Parse(Console.ReadLine());
            
            Console.WriteLine($"INFORME O NOME DA MARCA:");
            nova.NomeDaMarca = Console.ReadLine();
            
            nova.DataCadastro = DateTime.Now ;

            listaMarcas.Add(nova);
        }

        public void Listar()
        {
            if (listaMarcas.Count != 0)
            {

                foreach (Marca m in listaMarcas)
                {
                    Console.WriteLine(@$" 
                    {listaMarcas.IndexOf(m) + 1}- CODIGO: {m.CodigoDaMarca} 
                       NOME DA MARCA: {m.NomeDaMarca}
                       CADASTRADA NO DIA: {m.DataCadastro}");
                }
            }
            else
            {
                Console.WriteLine($"A LISTA NAO POSSUI NENHUMA MARCA REGISTRADA!");

            }
        }
        public void Deletar(int codigo)
        {
            Marca marcaEncontrada = listaMarcas.Find(x => x.CodigoDaMarca == codigo);

            listaMarcas.Remove(marcaEncontrada);
        }


    }
}