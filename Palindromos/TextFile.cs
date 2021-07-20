using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindromos
{
    class TextFile
    {
        private string pathFile;
        private int ContadorPalindromo = 0;

        public string PathFile
        {
            get { return pathFile; }
            set { pathFile = value; }
        }
        public int Contador
        {
            get { return ContadorPalindromo; }
            set { ContadorPalindromo = value; }
        }

        public void Ejecutar()
        {
            if (File.Exists(PathFile))
            {
                Validaciones validaciones = new Validaciones();

                string[] Text = File.ReadAllLines(pathFile);
                
                foreach(string line in Text)
                {
                    validaciones.Text = line;
                    if (validaciones.Validar())
                    {
                        Contador += 1;
                        //Console.WriteLine("{0}.- Si es un palindromo",Contador);
                    }
                    else
                    {
                        //Console.WriteLine("No es un palindromo");
                    }
                }
            }
            else
            {
                //Esto se ejecutara en caso de que no exixta el archivo
                File.Create(PathFile);
                Console.WriteLine("El archivo no exixtia en el entorno");
                Console.WriteLine("Se ha creado el archivo, favor de acceder a la ruta \"{0}\" y colocar informacion dentro de el ", PathFile);
            }
        }
        
    }
}
