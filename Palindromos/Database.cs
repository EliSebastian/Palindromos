using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindromos
{
    class Database
    {
        private int Contador = 0;
        public int contador
        {
            get { return Contador; }
            set { Contador = value; }
        }

        public void Ejecutar()
        {
            Conexion Conex = new Conexion();
            
            DataTable Tabla = Conex.LlamarDatos();

            Validaciones validacion = new Validaciones();
            foreach (DataRow dataRow in Tabla.Rows)
            {
                foreach (var item in dataRow.ItemArray)
                {
                    validacion.Text = item.ToString();
                    if (validacion.Validar())
                    {
                        contador += 1;
                    }
                }
            }
        }
    }
}
