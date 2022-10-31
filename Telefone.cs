using System;

namespace Telefone
{
    public class Telefone
    {
        private int _id;
        private int _numero;
        private int _ddd;
        //private TipoTelefone _tipo;

        new public int id
        {
            get { return _id; }
            set
            {
                _id = value;
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
        new public int ddd
        {
            get { return _ddd; }
            set
            {
                _ddd = value;
            }
        }
    }
}