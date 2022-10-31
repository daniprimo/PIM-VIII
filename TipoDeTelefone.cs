using System;

namespace TipoTelefone
{
    public class Tipo
    {
        private int _id;
        private string _tipo;

        new public int id
        {
            get { return _id; }
            set
            {
                _id = value;
            }
        }

        new public string tipo
        {
            get { return _tipo; }
            set
            {
                _tipo = value;
            }
        }


    }
}