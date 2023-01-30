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
    /// Lógica interna para DepartamentoWindow.xaml
    /// </summary>
    public partial class DepartamentoWindow : Window
    {
        public DepartamentoWindow()
        {
            InitializeComponent();
        }

        private void InserirClick(object sender, RoutedEventArgs e)
        {
            Departamento d = new Departamento();
            d.Id = int.Parse(txtId.Text);
            d.Nome = txtNome.Text;
            d.Sigla = txtSigla.Text;
            d.Localizacao = txtLocalizacao.Text;
            NDepartamento.Inserir(d);
            ListarClick(sender, e);
        }

        private void ListarClick(object sender, RoutedEventArgs e)
        {
            listDepartamento.ItemsSource = null;
            listDepartamento.ItemsSource = NDepartamento.Listar();
        }

        private void AtualizarClick(object sender, RoutedEventArgs e)
        {
            Departamento d = new Departamento();
            d.Id = int.Parse(txtId.Text);
            d.Nome = txtNome.Text;
            d.Sigla = txtSigla.Text;
            d.Localizacao = txtLocalizacao.Text;
            NDepartamento.Atualizar(d);
            ListarClick(sender, e);
        }

        private void ExcluirClick(object sender, RoutedEventArgs e)
        {
            Departamento d = new Departamento();
            d.Id = int.Parse(txtId.Text);
            NDepartamento.Excluir(d);
            ListarClick(sender, e);
        }

        private void listDepartamentos_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (listDepartamento.SelectedItem != null)
            {
                Departamento obj = (Departamento)listDepartamento.SelectedItem;
                txtId.Text = obj.Id.ToString();
                txtNome.Text = obj.Nome;
                txtSigla.Text = obj.Sigla;
                txtLocalizacao.Text = obj.Localizacao;
            }
        }
    }
}

