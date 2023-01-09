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

namespace EscolaApp
{
    /// <summary>
    /// Lógica interna para AlunoWindow.xaml
    /// </summary>
    public partial class AlunoWindow : Window
    {
        public AlunoWindow()
        {
            InitializeComponent();
        }

        private void InserirClick(object sender, RoutedEventArgs e)
        {
            Aluno a = new Aluno();
            a.Id = int.Parse(txtId.Text);
            a.Nome = txtCurso.Text;
            a.Matrícula = txtTurma.Text;
            a.Email = int.Parse(txtAno.Text);
            // Inserir a turma na lista de turmas
            NAluno.Inserir(a);
            // Lista a turma inserida
            ListarClick(sender, e);
        }

        private void ListarClick(object sender, RoutedEventArgs e)
        {
            listAluno.ItemsSource = null;
            listAluno.ItemsSource = NAluno.Listar();
        }
    }
}
