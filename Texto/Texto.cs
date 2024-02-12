using System.Text;
using System.Text.RegularExpressions;

namespace ContadorDePalabras
{
    public class Texto
    {
        private string _miTexto;
        private Dictionary<string, int> _contadorPalabras;

        public string MiTexto { get; set; }
        public Dictionary<string, int> ContadorPalabras { get; set; }

        public Texto(string miTexto, Dictionary<string, int> contadorPalabras)
        {
            MiTexto = miTexto;
            ContadorPalabras = contadorPalabras;
        }

        private string EliminarPuntuacion(string texto)
        {
            string patron = @"[.,\-_]";
            string textoLimpio = Regex.Replace(texto, patron, "");
            return textoLimpio;
        }

        private List<string> SepararPalabras()
        {
            string textoLimpio = EliminarPuntuacion(MiTexto);
            List<string> listaPalabras = new List<string>();
            listaPalabras = textoLimpio.Split(new char[] {' ', '\n'}).ToList();
            return listaPalabras;
        }

        private Dictionary<string, int> ContarPalabras()
        {
            List<string> listaPalabras = SepararPalabras();
            foreach (string palabra in listaPalabras)
            {
                if (ContadorPalabras.ContainsKey(palabra.ToLower().Trim(new char[] { ' ', '\n' })))
                {
                    ContadorPalabras[palabra.ToLower().Trim(new char[] { ' ', '\n' })]++;
                }
                else
                {
                    ContadorPalabras[palabra.ToLower().Trim(new char[] {' ', '\n'})] = 1;
                }
            }
            return ContadorPalabras;
        }

        private Dictionary<string, int> OrdenarDiccionarioDescendentemente()
        {
            Dictionary<string, int> cantPalabras = ContarPalabras();
            Dictionary<string, int> cantidadDescendiente = cantPalabras.OrderByDescending(c => c.Value).ToDictionary(x => x.Key, x => x.Value);
            return cantidadDescendiente;
        }

        public string RetornarConteoDePalabras()
        {
            int contador = 0;
            Dictionary<string, int>  dicc = OrdenarDiccionarioDescendentemente();
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Cantidad de palabras:");
            foreach (var kvp in dicc)
            {
                if(contador != 3)
                {
                    sb.AppendLine($"- {kvp.Key}: {kvp.Value}");
                    contador++;
                }
                else
                {
                    break;
                }
            }
            return sb.ToString();
        }
    }
}
