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

namespace UniversidadeApp
{
    /// <summary>
    /// Lógica interna para UniversidadeWindow.xaml
    /// </summary>
    public partial class UniversidadeWindow : Window
    {
        public UniversidadeWindow()
        {
            InitializeComponent();
        }

        private void InserirClick(object sender, RoutedEventArgs e)
        {
            Universidade u = new Universidade();
            u.Id = int.Parse(txtId.Text);
            u.Nome = txtNome.Text;
            u.Sigla = txtSigla.Text;
            NUniversidade.Inserir(u);
            ListarClick(sender, e);
        }

        private void ListarClick(object sender, RoutedEventArgs e)
        {
            listUniversidade.ItemsSource = null;
            listUniversidade.ItemsSource = NUniversidade.Listar();
        }

        private void AtualizarClick(object sender, RoutedEventArgs e)
        {
            Universidade u = new Universidade();
            u.Id = int.Parse(txtId.Text);
            u.Nome = txtNome.Text;
            u.Sigla = txtSigla.Text;
            NUniversidade.Atualizar(u);
            ListarClick(sender, e);

        }

        private void ExcluirClick(object sender, RoutedEventArgs e)
        {
            Universidade u = new Universidade();
            u.Id = int.Parse(txtId.Text);
            NUniversidade.Excluir(u);
            ListarClick(sender, e);

        }

        private void listTurmas_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (listUniversidade.SelectedItem != null)
            {
                Universidade obj = (Universidade)listUniversidade.SelectedItem;
                txtId.Text = obj.Id.ToString();
                txtNome.Text = obj.Nome;
                txtSigla.Text = obj.Sigla;
            }
        }
    }
}
