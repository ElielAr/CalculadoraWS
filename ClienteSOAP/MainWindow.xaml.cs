using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ClienteSOAP
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public int resultado { get; set; }

        private void Calcular_area_cuadrado_Click(object sender, RoutedEventArgs e)
        {
            ServiceReferencePractica3.CalcularWebServiceSoapClient ws = new ServiceReferencePractica3.CalcularWebServiceSoapClient();

            int A = Convert.ToInt32(_base.Text);
            int B = Convert.ToInt32(altura.Text);
            resultado = ws.Add(A, B);
            resultado.Text = resultado.ToString();
        }
    }
}
