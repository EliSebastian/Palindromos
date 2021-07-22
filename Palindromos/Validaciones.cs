using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Globalization;

namespace Palindromos
{
    class Validaciones
    {
        private string TextToValidate;

        public string Text
        {
            get { return TextToValidate; }
            set { TextToValidate = value; }
        }

        public bool Validar()
        {

            Text = Regex.Replace(Text,@"\s",""); //Elimina todos los espacios
            Text = Regex.Replace(Text,@",","");  //Elimina todas las comas
            Text = Regex.Replace(Text, @"\.", "");//Elimina todos los puntos
            Text = QuitarTildes(Text); //Elimina todas las tildes
            Text = Text.ToLower();

            string TextoRevers = Reverse(Text);

            if(Text == TextoRevers)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Funcion que Voltea el string y regresa el string alreves
        private static string Reverse(string Texto)
        {
            char[] TextoArray = Texto.ToCharArray();
            Array.Reverse(TextoArray);
            return new string(TextoArray);
        }

        //Funcion que quita cualquer tilde a las palabras introducidas
        private static string QuitarTildes(string Texto)
        {
            return new String(
            Texto.Normalize(NormalizationForm.FormD)
            .Where(c => CharUnicodeInfo.GetUnicodeCategory(c) != UnicodeCategory.NonSpacingMark)
            .ToArray()
            )
        .Normalize(NormalizationForm.FormC);
        }
    }
}
