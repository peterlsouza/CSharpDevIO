using Cadastro;
using System;

namespace Repositorio
{
    public class ClienteRepositorio
    {
        public List<Cliente> clientes = new List<Cliente>();

        public void GravarDadosClientes()
        {
            var json = System.Text.Json.JsonSerializer.Serialize(clientes);
            File.WriteAllText("Clientes.txt", json);
        }

        public void LerDadosClientes()
        {
            if(File.Exists("clientes.txt"))
            {
                var dados = File.ReadAllText("Clientes.txt");
                var clientesArquivo = System.Text.Json.JsonSerializer.Deserialize<List<Cliente>>(dados);

                clientes.AddRange(clientesArquivo);
            }
        }


        public void ExcluirCliente()
        {
            Console.Clear();
            Console.Write("Informe o codigo do Cliente: ");
            var codigo = Console.ReadLine();

            var cliente = clientes.FirstOrDefault(p => p.Id == int.Parse(codigo));

            if (cliente == null)
            {
                Console.WriteLine("Cliente não encontrado! [Enter]");
                Console.ReadKey();
                return;
            }

            ImprimirCliente(cliente);
            clientes.Remove(cliente);
            Console.WriteLine("Cliente removido com sucesso! [Enter]");
            Console.ReadKey();
        }

        public void EditarCliente()
        {
            Console.Clear();
            Console.Write("Informe o codigo do Cliente: ");
            var codigo = Console.ReadLine();

            var cliente = clientes.FirstOrDefault(p => p.Id == int.Parse(codigo));

            if (cliente == null)
            {
                Console.WriteLine("Cliente não encontrado! [Enter]");
                Console.ReadKey();
                return;
            }

            ImprimirCliente(cliente);

            System.Console.WriteLine("Nome do cliente: ");
            var nome = Console.ReadLine();
            Console.Write(Environment.NewLine);

            Console.Write("Data de Nascimento: ");
            var dataNascimento = DateOnly.Parse(Console.ReadLine());
            Console.Write(Environment.NewLine);

            Console.Write("Desconto: ");
            var desconto = decimal.Parse(Console.ReadLine());
            Console.Write(Environment.NewLine);

            cliente.Nome = nome;
            cliente.DataNascimento = dataNascimento;
            cliente.Desconto = desconto;
            cliente.CadastradoEm = DateTime.Now;

            Console.WriteLine("Cliente alterado com sucesso! [Enter]");
            ImprimirCliente(cliente);
            Console.ReadKey();

        }

        public void CadastrarCliente()
        {
            Console.Clear();

            Console.Write("Nome do Cliente: ");
            var nome = Console.ReadLine();
            Console.Write(Environment.NewLine);

            
            Console.Write("Data de Nascimento: ");
            var dataNascimento = DateOnly.Parse(Console.ReadLine());
            Console.Write(Environment.NewLine);

            
            Console.Write("Desconto: ");
            var desconto = decimal.Parse(Console.ReadLine());
            Console.Write(Environment.NewLine);

            
            int? lastId = clientes.Max(p => (int?)p.Id);
            if (lastId == null)
            {
                lastId = 0;
            }

            var cliente = new Cliente();
            cliente.Id = (int)lastId + 1;
            cliente.Nome = nome;
            cliente.DataNascimento = dataNascimento;
            cliente.Desconto = desconto;
            cliente.CadastradoEm = DateTime.Now;

            clientes.Add(cliente);

            Console.WriteLine("Cliente Cadastrado com sucesso! [Enter]");
            ImprimirCliente(cliente);
            Console.ReadKey();

        }


        public void ImprimirCliente(Cliente cliente)
        {   
            Console.WriteLine("ID...............: " + cliente.Id);
            Console.WriteLine("Nome.............: " + cliente.Nome);
            Console.WriteLine("Desconto.........: " + cliente.Desconto);
            Console.WriteLine("Data Nascimento..: " + cliente.DataNascimento);
            Console.WriteLine("Data Cadastro....: " + cliente.CadastradoEm);
            Console.WriteLine("----------------------------------------------: ");
        }

        public void ExibirClientes()
        {
            Console.Clear();
            foreach (var cliente in clientes)
            {
                ImprimirCliente(cliente);
            }
            Console.ReadKey();
        }


    }
}