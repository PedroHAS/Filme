using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Filmes.Model;
using MySql.Data.MySqlClient;

namespace Filmes.DAO
{
	class FilmesDao
	{
		string Con;
		Filme fil = new Filme();

		public FilmesDao()
		{
			Con = "Persist Security Info=False;server=localhost;database=filme;uid=root;pwd=1234";
		}
		public void IncluirFilme(Filme filme)
		{
			MySqlConnection CN = new MySqlConnection(Con);
			MySqlCommand Com = CN.CreateCommand();

			Com.CommandText = "INSERT INTO filme(id,titulo,data,estudio)" +
							   "Values(?id, ?titulo,?data,?estudio)";
			Com.Parameters.AddWithValue("?id", filme.ID);
			Com.Parameters.AddWithValue("?titulo", filme.titulo);
			Com.Parameters.AddWithValue("?data", filme.data);
			Com.Parameters.AddWithValue("?estudio", filme.estudio);

			try
			{
				CN.Open();
				int regitrosAfetados = Com.ExecuteNonQuery();
			}
			catch (MySqlException ex)
			{
				throw new ApplicationException(ex.ToString());
			}
			finally
			{
				CN.Close();
			}
		}
		public DataTable getFilme()
		{
			MySqlConnection CN = new MySqlConnection(Con);
			MySqlCommand cmd = CN.CreateCommand();
			MySqlDataAdapter da;

			cmd.CommandText = "select id, titulo, data, estudio";
			try
			{
				CN.Open();
				cmd = new MySqlCommand(cmd.CommandText, CN);
				da = new MySqlDataAdapter(cmd);
				DataTable dtFilme = new DataTable();
				da.Fill(dtFilme);
				return dtFilme;
			}
			catch(MySqlException ex)
			{
				throw new ApplicationException(ex.ToString());
			}
			finally
			{
				CN.Close();
			}
		}
		public List<Filme> ListarFilmeCombo()
		{
			MySqlConnection CN = new MySqlConnection(Con);
			MySqlCommand cmd = CN.CreateCommand();
			MySqlDataReader dr;

			cmd.CommandText = "select id, titulo from filme";
			try
			{
				CN.Open();
				cmd = new MySqlCommand(cmd.CommandText, CN);
				dr = cmd.ExecuteReader();

				List<Filme> filmes = new List<Filme>();
				while (dr.Read())
				{
					Filme fil = new Filme();
					fil.ID = dr.GetInt32(dr.GetOrdinal("id"));
					fil.titulo = dr.GetString(dr.GetOrdinal("titulo"));
					filmes.Add(fil);
				}
				cmd.Connection.Close();
				cmd.Dispose();

				return filmes;
			}
				catch (MySqlException ex)
			{
				throw new ApplicationException(ex.ToString());
			}
			finally
			{
				CN.Close();
			}
		}
		
		public DataTable BuscaFilmeFiltro(string titulo)
		{
			MySqlConnection CN = new MySqlConnection(Con);
			MySqlCommand cmd = CN.CreateCommand();
			MySqlDataAdapter da;

			cmd.CommandText = "SELECT * FROM filme WHERE titulo LIKE '%" + titulo + "%'";

			try
			{
				CN.Open();
				cmd = new MySqlCommand(cmd.CommandText, CN);
				da = new MySqlDataAdapter(cmd);
				//
				DataTable dtfilme = new DataTable();
				da.Fill(dtfilme);
				return dtfilme;
			}
			catch (MySqlException ex)
			{
				throw new ApplicationException(ex.ToString());
			}
			finally
			{
				CN.Close();
			}

		}
	}
}

