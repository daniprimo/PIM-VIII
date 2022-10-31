using System;
namespace Endereco
{
    public class Endereco
    {
        private int _id;
        private string _logradouro;
        private int _numero;
        private int _cep;
        private string _bairro;
        private string _cidade;
        private string _estado;




        new public int id
        {
            get { return _id; }
            set
            {
                _id = value;
            }
        }

        new public string logradouro
        {
            get { return _logradouro; }
            set
            {
                _logradouro = value;
            }
        }

        new public int numero
        {
            get { return _numero; }
            set
            {
                _numero = value;
            }
        }
        new public int cep
        {
            get { return _cep; }
            set
            {
                _cep = value;
            }
        }

        new public string bairro
        {
            get { return _bairro; }
            set
            {
                _bairro = value;
            }
        }
        new public string cidade
        {
            get { return _cidade; }
            set
            {
                _cidade = value;
            }
        }
        new public string estado
        {
            get { return _estado; }
            set
            {
                _estado = value;
            }
        }

        


    }
}