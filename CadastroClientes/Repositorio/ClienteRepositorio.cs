using CadastroClientes.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroClientes.Repositorio
{
   public class ClienteRepositorio
    {
        //Método 
        public void ExportarParaTxt(Cliente cliente)
        {
            //Criando um objeto da classe StreamWriter para criar um arquivo 
            //true -> flag que indica que a gravação  será feita em modo 'append'

            //ou seja, o arquivo não será substituido,  mas terá conteudo adicionado
            using (var streamWriter = new StreamWriter
            ("c:\\temp\\clientes.txt", true)) 
            {
                //Escrever os dados do cliente no arquivo 
                streamWriter.WriteLine(cliente.Id);
                streamWriter.WriteLine(cliente.Nome);
                streamWriter.WriteLine(cliente.Cpf);
                streamWriter.WriteLine(cliente.Email);
                streamWriter.WriteLine(cliente.Telefone);
                streamWriter.WriteLine(cliente.DataHoraCadastro);
                streamWriter.WriteLine("=====");
            }
        }
    }
}
