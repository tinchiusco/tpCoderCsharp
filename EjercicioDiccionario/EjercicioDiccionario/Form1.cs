namespace EjercicioDiccionario
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }



        private void Menu_Load(object sender, EventArgs e)
        {
            Dictionary<string, Dictionary<string, double>> casaDeComidas = new Dictionary<string, Dictionary<string, double>>();
            casaDeComidas.Add("Bebidas", new Dictionary<string, double> { { "Coca cola", 100 }, { "Fanta", 80 }, { "Agua", 50 } });
            casaDeComidas.Add("Entradas", new Dictionary<string, double> { { "Vitel Tone", 800 }, { "Rabas", 1000 }, { "Fiambre", 200 } });
            casaDeComidas.Add("Plato Principal", new Dictionary<string, double> { { "Lomo", 1000 }, { "Milanesa", 500 }, { "Pasta", 800 } });

            lstMenu.Items.Add("Seccion\t\t\t\t\tProducto\t\tPrecio");

            foreach (KeyValuePair<string, Dictionary<string, double>> seccion in casaDeComidas)
            {
                lstMenu.Items.Add(seccion.Key);
                foreach (KeyValuePair<string, double> parMenu in seccion.Value)
                {
                    lstMenu.Items.Add($"\t\t\t\t\t{parMenu.Key}\t\t{parMenu.Value}");
                }
            }
        }

    }
}
