using Modelos.ModelosDeDominio;
using System;

namespace ModelosDeDominio
{
    class Program
    {
        static void Main(string[] args)
        {
            ClienteAnemicoTeste();
            ClientenRicoTeste();
        }

        private static void ClientenRicoTeste()
        {
            try
            {
                var clienteRico = new ClienteRico(-1, "", "");
                Console.WriteLine(clienteRico.ToString());
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        private static void ClienteAnemicoTeste()
        {
            var clienteAnemico = new ClienteAnemico
            {
                Id = -1,
                Nome = "",
                CPF = ""
            };

            Console.WriteLine(clienteAnemico.ToString());
        }
    }
}
