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

            Console.WriteLine($"Z clientes residem em Y");
        }

        static void ExibirClientePorCodigo(int codigo)
        {
            Console.WriteLine("-- ExibirClientePorCodigo --");            

            Console.WriteLine("X reside em Y");
        }

    }

}