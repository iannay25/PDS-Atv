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
    /// Lógica interna para Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            CadastrarCurso tela = new CadastrarCurso();
            this.Close();
            tela.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            CadastroRelatorio tela = new CadastroRelatorio();
            this.Close();
            tela.Show();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            CadastroEscola tela = new CadastroEscola();
            this.Close();
            tela.Show();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            CadastroAluno tela = new CadastroAluno();
            this.Close();
            tela.Show();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            CadastroTurma tela = new CadastroTurma();
            this.Close();
            tela.Show();
        }
    }
}
