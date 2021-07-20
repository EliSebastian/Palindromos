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

            Text = Regex.Replace(Text,@"\s","");
            Text = Regex.Replace(Text,@",","");
            Text = Regex.Replace(Text, @"\.", "");
            Text = QuitarTildes(Text);
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

        private static string Reverse(string Texto)
        {
            char[] TextoArray = Texto.ToCharArray();
            Array.Reverse(TextoArray);
            return new string(TextoArray);
        }
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
