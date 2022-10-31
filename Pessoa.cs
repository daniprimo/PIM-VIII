using System;

namespace Pessoa
{
    public class Pessoa
    {
        private int _id;
        private string _nome;
        private long _cpf;
        //private Endereco _endereco;
        //private Telefone _telefone;

        new public int id
        {
            get { return _id; }
            set
            {
                _id = value;
            }
        }

        new public string nome
        {
            get { return _nome; }
            set
            {
                _nome = value;
            }
        }
        new public long cpf
        {
            get { return _cpf; }
            set { _cpf = value; }
        }
    }
}