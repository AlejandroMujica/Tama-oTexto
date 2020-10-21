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

namespace TamañoTexto
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private String tamaño;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void tamañoRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            tamaño = (sender as RadioButton).Tag.ToString();

            if(tamaño=="Pequeño")
                desarrolloTextBlock.FontSize = 36;
            else if (tamaño == "Mediano")
                desarrolloTextBlock.FontSize = 48;
            else
                desarrolloTextBlock.FontSize = 72;
        }
    }
}
