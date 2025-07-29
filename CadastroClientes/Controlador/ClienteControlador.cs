using CadastroClientes.Entidades;
using CadastroClientes.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroClientes.Controlador
{
  public class ClienteControlador
        //Metodo
    {
        public void CadastrarCliente()
        {
            Console.WriteLine
                ("\n *** SISTEMA DE CADASTRO DE CLIENTES *** \n");
            Console.Write
                ("Entre com os dados do cliente para cadastro:\n");
            
            var cliente = new Cliente();
            Console.Write("Informe o nome do cliente...........: ");
            cliente.Nome = Console.ReadLine();

            Console.Write("Informe o cpf do cliente............: ");
            cliente.Cpf = Console.ReadLine();

            Console.Write("Informe o email do cliente..........: ");
            cliente.Email = Console.ReadLine();

            Console.Write("Informe o telefone do cliente.......: ");
            cliente.Telefone = Console.ReadLine();

            var clienteRepositorio = new ClienteRepositorio();
            clienteRepositorio.ExportarParaTxt(cliente);

            Console.WriteLine("\nDADOS GRAVADOS COM SUCESSO!");
        }
    }
}
