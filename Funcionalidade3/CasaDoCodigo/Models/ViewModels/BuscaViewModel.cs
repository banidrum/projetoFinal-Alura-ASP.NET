using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CasaDoCodigo.Models.ViewModels
{
	public class BuscaViewModel
	{
		public BuscaViewModel(IList<Produto> produtos, bool encontrouResultados)
		{
			this.Produtos = produtos;
			this.EncontrouResultados = encontrouResultados;
		}

		public IList<Produto> Produtos { get; set;  }

		//Vai retornar true se encontrou resultados na pesquisa
		public BuscaViewModel(bool encontrouResultados)
		{
			EncontrouResultados = encontrouResultados;
		}

		public string Pesquisa { get; set; }
		public bool EncontrouResultados;
	}
}
