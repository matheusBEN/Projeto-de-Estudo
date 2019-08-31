using Impacta.MOD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Impacta.Tarefas.EF
{
	public class EditoraEF
	{
		public List<Editora> ListarEditora()
		{
			List<Editora> listaDeEditora = null;

			using (RealBookContexto realDB = new RealBookContexto())
			{
				// uma vez instanciado

				listaDeEditora = realDB.Editoras.ToList();
			}

			return listaDeEditora;
		}

		public void Salvar(Editora editora)
		{
			using (RealBookContexto db = new RealBookContexto())
			{
				if (editora.EditoraId > 0)
				{
					var result = db.Editoras.Where(x => x.EditoraId == editora.EditoraId).FirstOrDefault();

					result.Nome = editora.Nome;
					result.Email = editora.Email;
					result.Telefone = editora.Telefone;
					result.Endereco = editora.Endereco;
					result.Cnpj = editora.Cnpj;

					db.SaveChanges();

					
				}
				else
				{
					db.Editoras.Add(editora);
					db.SaveChanges();
				}

			}
		}

		public Editora BuscarEditora(int id)
		{
			Editora editora = null;

			using (RealBookContexto realDB = new RealBookContexto())
			{
				using (var db =  new RealBookContexto())
				{
					editora = db.Editoras.Where(p => p.EditoraId == id).FirstOrDefault();
				}
			}
			return editora;
		}

		public void Excluir(int id)
		{
			using (var realDB = new RealBookContexto())
			{
				var editora = realDB.Editoras.Where(i => i.EditoraId == id).FirstOrDefault();
				realDB.Editoras.Remove(editora);
				realDB.SaveChanges();
			}
		}
	}
}
