using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Filmes.DAO;
using Filmes.Model;

namespace Filmes
{
	public partial class Form1 : Form
	{
		
		public Form1()
		{
			InitializeComponent();
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void button2_Click(object sender, EventArgs e)
		{
			if ((txttitulo.Text.Equals("")) && (txtEstudio.Text.Equals("")))
				{
				MessageBox.Show("Informe o título do filme e o estúdio");
				return;
			}
			try
			{
				FilmesDao FilmesBD = new FilmesDao();
				Filme FilmeReg = new Filme(txttitulo.Text, txtEstudio.Text, txtdata.Text);
				FilmesBD.IncluirFilme(FilmeReg);
				MessageBox.Show("Cadastro realizado com sucesso");

				txttitulo.Text = "";
				txtdata.Text = "";
				txtEstudio.Text = "";
			}
			catch (Exception c)
			{
				MessageBox.Show(c.ToString());
			}
		}

		private void btnLimpar_Click(object sender, EventArgs e)
		{
			txttitulo.Text = "";
			txtEstudio.Text = "";
			txtdata.Text = "";
		}

		private void btnListar_Click(object sender, EventArgs e)
		{
			
			PesquisaFilmes abre = new PesquisaFilmes();
			abre.ShowDialog();
			this.Dispose();
		}
	}
}
