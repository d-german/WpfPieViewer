using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using WpfPieViewer.Models;

namespace WpfPieViewer.Services
{
    public class PieApiRepository : IPieRepository
    {
        static HttpClient client = new HttpClient();
        static async Task<IEnumerable<Pie>> GetProductAsync(string path)
        {
            IEnumerable <Pie> pies = null;
            HttpResponseMessage response = await client.GetAsync(path);
            if (response.IsSuccessStatusCode)
            {
                pies = await response.Content.ReadAsAsync<IEnumerable<Pie>>();
            }
            return pies;
        }

        public PieApiRepository()
        {
            client.BaseAddress = new Uri("http://localhost:64195/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public IEnumerable<Pie> GetAllPies()
        {
            throw new NotImplementedException();
        }

        public Pie GetPieById(int pieId)
        {
            throw new NotImplementedException();
        }
    }
}
