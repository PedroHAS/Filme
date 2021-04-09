using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filmes.Model
{
	class Filme
	{
		public int ID;
		public string titulo;
		public string data;
		public string estudio;

		public Filme()
		{
		}
		public Filme(int ID)
		{
			this.ID = ID;
		}
		public Filme(string titulo, string data, string estudio)
		{
			this.titulo = titulo;
			this.data = data;
			this.estudio = estudio;
		}
		public Filme(int ID, string titulo, string data, string estudio)
		{
			this.ID = ID;
			this.titulo = titulo;
			this.data = data;
			this.estudio = estudio;
		}

	}
}
