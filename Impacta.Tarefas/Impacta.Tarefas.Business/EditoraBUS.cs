using Impacta.MOD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Impacta.Tarefas.EF;

namespace Impacta.Tarefas.Business
{
	public class EditoraBUS
	{
		public List<Editora> ListarEditoras()
		{
			try
			{	//estaciar o objeto que se comunica com banco de dados
				EditoraEF editoraEF = new EditoraEF();
				//executa o metodo listar editoras (faz select )
				var ed = editoraEF.ListarEditora();

				return ed;
			}
			catch (Exception ex)
			{

				throw new Exception("Falha ao tentar Validar a busca das Editoras. Erro:\n" + ex.Message);
			}
		}

		public void Salvar(Editora editora)
		{
			try
			{
				if (string.IsNullOrEmpty(editora.Nome))
				{
					throw new Exception("Nome invalido");

				}
				if (string.IsNullOrEmpty(editora.Email))
				{
					throw new Exception("E-mail invalido");
				}
				EditoraEF editoraEF = new EditoraEF();
				editoraEF.Salvar(editora);
			}
			catch (Exception ex)
			{

				throw ex;
			}
			
		}

		public Editora BuscarEditora(int id)
		{
			EditoraEF editoraEF = new EditoraEF();

			Editora ed;
			try
			{
				ed = editoraEF.BuscarEditora(id);
			}
			catch (Exception ex)
			{

				throw new Exception(
					"Falha ao tentar validar a busca das Editora. Erro: \n"
					+ ex.Message);
			}

			return ed;
		}

		public void Excluir (int id)
		{

		}
	}
}
