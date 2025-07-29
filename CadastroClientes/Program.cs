using CadastroClientes.Controlador;

Console.WriteLine("\nAULA 01 - C#.NET WEBDEVELOPER Formação Fullstack\n");
//criando um objeto da classe de controle de clientes 
var clienteControlador = new ClienteControlador();
//executando o método para cadastrar um cliente 
clienteControlador.CadastrarCliente();
//pausar o prompt do console 
Console.ReadKey();
