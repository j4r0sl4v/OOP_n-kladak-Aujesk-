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

namespace OOP_vozidla_Aujeský
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Nakladak man;
        Nakladak mercedes;

        public MainWindow()
        {
            InitializeComponent();
            man = new Nakladak();
            man.název = "Man";
            Zobraz(man, text1);

            mercedes = new Nakladak();
            mercedes.název = "Mercedes";
            Zobraz(mercedes, text2);
        }

        public void Zobraz (Nakladak nákladak, TextBox textBox)
        {
            textBox.Text = nákladak.název + "\n";
            textBox.Text += "Nosnost " + nákladak.nosnost.ToString()+ "kg" + "\n";
            textBox.Text += "Náklad " + nákladak.náklad.ToString() + "kg" + "\n";
            textBox.Text += "Spotřeba nádrže " + nákladak.Spotřeba_Nádrže.ToString() + "l/100km" + "\n";
            textBox.Text += "Objem nadrze " + nákladak.ObjemNadrze.ToString()+ "l" + "\n";
            textBox.Text += "Celková vzdálenost " + nákladak.CelkováVzdalenost.ToString() + "km" + "\n";
        }

        private void JetN_Click(object sender, RoutedEventArgs e)
        {
            man.jet();
            Zobraz(man, text1);
        }

        private void JetA_Click(object sender, RoutedEventArgs e)
        {
            mercedes.jet();
            Zobraz(mercedes, text2);
        }
    }
}
