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
using System.Windows.Shapes;

namespace Atvd_PDS
{
    /// <summary>
    /// Lógica interna para CadastroAluno.xaml
    /// </summary>
    public partial class CadastroAluno : Window
    {
        public CadastroAluno()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window1 tela = new Window1();
            this.Close();
            tela.Show();
        }
    }
}
