using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindromos
{
    class Conexion
    {

        /*
         * La base de Datos esta en MySql
         * para creacrla ejecutar los siguentes comandos por partes
         * 
         *CREACION DE LA BASE DE DATOS
         *
         *CREATE SCHEMA `palindromos` ;

         *CREACION DE LA TABLA
         *
         CREATE TABLE `palindromos`.`pal` (
         `id` INT NOT NULL AUTO_INCREMENT,
         `Palindromo` LONGTEXT NOT NULL,
         PRIMARY KEY (`id`));

         *INSERCION DE LOS DATOS
         *
          INSERT INTO `palindromos`.`pal` (`Palindromo`) VALUES ('A mamá, Roma le aviva el amor a papá, y a papá, Roma le aviva el amor a mamá.');
          INSERT INTO `palindromos`.`pal` (`Palindromo`) VALUES ('Adán no cede con Eva y Yavé no cede con nada.');
          INSERT INTO `palindromos`.`pal` (`Palindromo`) VALUES ('jganknu');
          INSERT INTO `palindromos`.`pal` (`Palindromo`) VALUES ('Este no es un paindromo');
          INSERT INTO `palindromos`.`pal` (`Palindromo`) VALUES ('A mi loca Colima.');
          INSERT INTO `palindromos`.`pal` (`Palindromo`) VALUES ('boob');
          INSERT INTO `palindromos`.`pal` (`Palindromo`) VALUES ('Bo b');
         */


        private static MySqlConnection Conectar()
        {
            MySqlConnection Conexion = new MySqlConnection("Server=localhost; Database=palindromos; Uid=root; Pwd=E11172003");
            try
            {
                Conexion.Open();
            }
            catch
            {
                Conexion.Close();
                Conexion = null;
            }
            return Conexion;
        }

        public DataTable LlamarDatos()
        {
            MySqlConnection Conexion = Conectar();
            if(Conexion != null)
            {
                string SQL = "SELECT Palindromo FROM pal;";
                MySqlCommand Comando = new MySqlCommand(SQL,Conexion);
                MySqlDataAdapter Adapdator = new MySqlDataAdapter();
                Adapdator.SelectCommand = Comando;
                DataTable TablaDatos = new DataTable();
                Adapdator.Fill(TablaDatos);
                return TablaDatos;
                
            }
            else
            {
                return null;
            }
        }
    }
}
