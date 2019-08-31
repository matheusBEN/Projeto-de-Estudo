using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using Impacta.MOD;

namespace Impacta.Tarefas.ClientApi
{
    class Program
    {
        static void Main(string[] args)
        {
            RunAsync().Wait();
        }
        static async Task RunAsync()
        {
            var formato = new MediaTypeWithQualityHeaderValue("application/json");

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:51798/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(formato);
                // o metodo GetAsync () ele vai solicitar a execução da sua API
                // e obter um valor de resposta, armazenado na variavel RESPOSTA
                var resposta = await client.GetAsync("api/WebApiEditora");

                //Nós precisamos definir qual tipoo de retorno iremos obter
                //neste caso podemos definir de duas maneiras
                //1 Definimos um objeto de retorno similar ao da assinatura da API
                // 2 Ou defini-se uma MOdelagem de uma classe igual a retornada pela API

               // var conteudo = await resposta.Content.ReadAsAsync<IEnumerable<object>>();

                // na segunda dorma seria assim
                var conteudo = await resposta.Content.ReadAsAsync<IEnumerable<Editora>>();

                //string conteudo = await resposta.Content.ReadAsAsync<string>();
                foreach (var item in conteudo)
                {
                    Console.WriteLine(string.Format("EditoraID: {0}, Nome: {1}", item.EditoraId, item.Nome));
                }
            }
            Console.ReadLine();
        }
    }
}