using ContadorDePalabras;
namespace Forms
{
    public partial class FrmContador : Form
    {
        public FrmContador()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            string texto = richTextBox.Text;
            Dictionary<string, int> constadorPalabras = new Dictionary<string, int>();
            Texto miTexto = new Texto(texto, constadorPalabras);
            if (string.IsNullOrEmpty(texto))
            {
                MessageBox.Show("El texto está vacío", "Contador de palabras");
            }
            else
            {
                MessageBox.Show(miTexto.RetornarConteoDePalabras(), "Contador de palabras", MessageBoxButtons.OK);
            }
        }
    }
}
