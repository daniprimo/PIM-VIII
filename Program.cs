using System;

namespace Principal
{
    class Program
    {
        static void Main(string[] args)
        {
            Endereco.Endereco endereco = new Endereco.Endereco();

            endereco.id = 15;
            endereco.logradouro = "Rua ipixuna";
            endereco.numero = 141;
            endereco.cep = 06385820;
            endereco.bairro = "Vila Menk";
            endereco.cidade = "Carapicuiba";
            endereco.estado = "São Paulo";


            Console.WriteLine("Id {0}", endereco.id);
            Console.WriteLine("Logradouro {0}", endereco.logradouro);
            Console.WriteLine("Numero {0}", endereco.numero);
            Console.WriteLine("Cep {0}", endereco.cep);
            Console.WriteLine("Bairro {0}", endereco.bairro);
            Console.WriteLine("Cidade {0}", endereco.cidade);
            Console.WriteLine("Estado {0}", endereco.estado);
        }
    }
}