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

namespace UniversidadeApp
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Cadastro_uni_Click(object sender, RoutedEventArgs e)
        {
            UniversidadeWindow w = new UniversidadeWindow();
            w.ShowDialog();
        }

        private void Cadastro_dep_Click(object sender, RoutedEventArgs e)
        {
            DepartamentoWindow w = new DepartamentoWindow();
            w.ShowDialog();
        }

        private void Cadastro_curso_Click(object sender, RoutedEventArgs e)
        {
            CursosWindow w = new CursosWindow();
            w.ShowDialog();
        }

        private void dep_uni_Click(object sender, RoutedEventArgs e)
        {
            Cadastrar_Dep_UniWindow W = new Cadastrar_Dep_UniWindow();
            W.ShowDialog();
        }

        private void curso_dep_Click(object sender, RoutedEventArgs e)
        {
            Cadastrar_Cursos_DepWindow W = new Cadastrar_Cursos_DepWindow();
            W.ShowDialog();
        }

        private void list_dep_Click(object sender, RoutedEventArgs e)
        {
            List_Dep_UniWindow W = new List_Dep_UniWindow();
            W.ShowDialog();
        }

        private void list_curso_Click(object sender, RoutedEventArgs e)
        {
            List_Cursos_DepWindow W = new List_Cursos_DepWindow();
            W.ShowDialog();
        }
    }
}
