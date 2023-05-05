using System.Linq;

namespace Analise
{

    class Program 
    {
        private static List<Cliente> _clientes;

        static void Main(string[] args)
        {            
            CadastrarClientes();

            ListarClientesPorCidade();
            ExibirClientePorCodigo(2);
        }

        static void CadastrarClientes()
        {
            Console.WriteLine("-- CadastrarClientes --");

            _clientes = new List<Cliente>
            {
                new Cliente { Codigo = 1, Nome = "João", Cidade = "São Paulo" },
                new Cliente { Codigo = 2, Nome = "Maria", Cidade = "São Paulo" },
                new Cliente { Codigo = 3, Nome = "Carlos", Cidade = "Rio de Janeiro" },
                new Cliente { Codigo = 4, Nome = "Flávia", Cidade = "Santa Catarina" }
            };

        }

        static void ListarClientesPorCidade()
        {
            Console.WriteLine("-- ListarClientesPorCidade --");

            var cidades = _clientes.GroupBy(x => x.Cidade);

            foreach(var cidade in cidades)
            {
                Console.WriteLine($"{cidade.Count()} clientes residem em {cidade.Key}");

                foreach(var cliente in cidade)                
                    Console.WriteLine($" {cliente.Nome}");
                
                Console.WriteLine();
            }

        }

        static void ExibirClientePorCodigo(int codigo)
        {
            Console.WriteLine("-- ExibirClientePorCodigo --");

            var cliente = _clientes.FirstOrDefault(x => x.Codigo == codigo);

            Console.WriteLine($"{cliente.Nome} reside em {cliente.Cidade}");
        }

    }

}