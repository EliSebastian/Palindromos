using System;
using System.IO;

namespace Palindromos
{
    class Program
    {
        static void Main(string[] args)
        {
            //Para facilitar la interaccioncon el codigo se podra hacer obtener infomacion de 2 formas 
            //1. Por la base de Datos
            //2. Por un archivo de texto
            int Entrada = 2;

            switch(Entrada)
            {
                case 1:
                    EntradaBD();
                    break;

                case 2:
                    EntradaFile();
                    break;
            }
            Console.ReadKey();
        }

        //Funcion ejecutable para la primera opcion. Entrada por la BD
        private static void EntradaBD()
        {
            Database DB = new Database();
            DB.Ejecutar();
            Console.WriteLine("Existen {0} palindromos",DB.contador);
        }

        //funcion ejecutabe para la 2da opcion
        private static void EntradaFile()
        {
            TextFile FileText = new TextFile();

            FileText.PathFile = @"D:\eseba\Documents\Proyects\.NET\Palindromos\Texto.txt";
            FileText.Ejecutar();
            Console.WriteLine("Existen {0} palindromos", FileText.Contador);
        }

    }
}
