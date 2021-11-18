using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    class Numero
    {
        private int _valorACalcular1 = 0;
        private int _valorACalcular2 = 0;
        private string _operacion = "";



        public int N1
        {
            get 
            {
                return _valorACalcular1;
            }
            set
            {
                _valorACalcular1 = value;
            }
            
        }

        public int N2
        {
            get
            {
                return _valorACalcular2;
            }
            set
            {
                _valorACalcular2 = value;
            }

        }

        public string Operacion
        {
            get
            {
                return _operacion;
            }
            set
            {
                _operacion = value;
            }

        }


    }
}
