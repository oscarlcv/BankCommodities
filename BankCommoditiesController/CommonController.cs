using System.Collections.Generic;
using RestSharp;
using Newtonsoft.Json;

namespace BankCommoditiesControllers
{
    public class CommonController
    {
        /// <summary>
        /// Método que devuelve un listado de objetos de un tipo específico.
        /// Para ello, accede a la URL pasada por parámetro y extrae la información allí contenida.
        /// Posteriormente mapea dicha información a un listado de objetos del tipo definido por entrada.
        /// Además, hace una copia de seguridad de dicha información en una ruta específica.
        /// Si la conexión a la URL falla, intenta extraer los datos de la copia de seguridad.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="url"></param>
        /// <returns></returns>
        public static List<T> GetListFromURL<T>(string url, string backupPath)
        {
            List<T> tlist = null;

            RestClient client = new RestClient(url)
            {
                Timeout = -1
            };
            var request = new RestRequest(Method.GET);
            IRestResponse response = client.Execute(request);
            string json;
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
                json = response.Content;
            else
                json = BackUpController.GetBackUpJSon(backupPath);

            if (json.Length > 0)
            {
                BackUpController.SetBackUpJSon(backupPath, json);
                tlist = JSonToTList(tlist, json);
            }

            return tlist;
        }

        private static List<T> JSonToTList<T>(List<T> tlist, string json)
        {
            try
            {
                var model = JsonConvert.DeserializeObject<List<T>>(json);
                if (model != null)
                {
                    tlist = (List<T>)model;
                }
            }
            catch
            {
                throw;
            }

            return tlist;
        }
    }
}
