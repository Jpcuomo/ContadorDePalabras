using ContadorDePalabras;
namespace Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string texto = "Ambos enfoques pueden realizar la tarea de ordenar y mostrar los 3 mayores resultados de manera efectiva. Sin embargo, el segundo enfoque parece más completo en términos de funcionalidad y reutilización del código.\r\n\r\nEl segundo enfoque proporciona una clase Texto que encapsula toda la funcionalidad relacionada con el conteo de palabras, eliminación de puntuación, separación de palabras, conteo y ordenamiento. Además, permite su uso en diferentes contextos, como aplicaciones de consola, aplicaciones web, etc.";
            Dictionary<string, int> contarPalabras = new Dictionary<string, int>();
            
            // Instancia de Texto
            Texto miTexto = new Texto(texto, contarPalabras);

            Console.WriteLine(miTexto.RetornarConteoDePalabras());
        }
    }
}
