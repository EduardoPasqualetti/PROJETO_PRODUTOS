namespace Projeto_de_produtos
{
    public class Marca
    {
        public int CodigoDaMarca;

        public string NomeDaMarca;

        private DateTime DataCadastro;

        public static List<Marca> listaMarcas = new List<Marca>();

      
        public Marca CadastrarMarca()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write($"INFORME O CODIGO DA MARCA:");
            Console.ResetColor();
            int codigo = int.Parse(Console.ReadLine());

            Marca encontrada = listaMarcas.Find(x => x.CodigoDaMarca == codigo);

            if (encontrada == null)
            {
                encontrada = new Marca();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write($"INFORME O NOME DA MARCA:");
                Console.ResetColor();
                encontrada.NomeDaMarca = Console.ReadLine();

                encontrada.CodigoDaMarca = codigo;
                encontrada.DataCadastro = DateTime.Now;
                listaMarcas.Add(encontrada);

                return encontrada;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"MARCA JA CADASTRADA!");
                Console.ResetColor();
                return encontrada;
            }
        }
        public void Listar()
        {
            if (listaMarcas.Count != 0)
            {

                foreach (Marca m in listaMarcas)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(@$" 
                    {listaMarcas.IndexOf(m) + 1}- 
                    CODIGO: {m.CodigoDaMarca} 
                    NOME DA MARCA: {m.NomeDaMarca}
                    CADASTRADA NO DIA: {m.DataCadastro}");
                    Console.ResetColor();
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"A LISTA NAO POSSUI NENHUMA MARCA REGISTRADA!");
                Console.ResetColor();
            }
        }
        public void Deletar(int codigo)
        {
            Marca marcaEncontrada = listaMarcas.Find(x => x.CodigoDaMarca == codigo);
            if (listaMarcas.Contains(marcaEncontrada))
            {
                listaMarcas.Remove(marcaEncontrada);
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine($"MARCA REMOVIDA COM SUCESSO!");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"A LISTA NAO POSSUI ESSA MARCA!");
                Console.ResetColor();
            }



        }


    }
}