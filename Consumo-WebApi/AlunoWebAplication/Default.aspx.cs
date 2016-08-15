using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace AlunoWebAplication
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            

            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:1299");
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

            Uri disciplinasURI;

            System.Net.Http.HttpResponseMessage response = client.GetAsync("api/Disciplina").Result;
            disciplinasURI = response.Headers.Location;

            if (response.IsSuccessStatusCode)
            {
                var json = response.Content.ReadAsStringAsync();
                List<Disciplina> model = new List<Disciplina>();
                model = JsonConvert.DeserializeObject<List<Disciplina>>(json.Result);

                gridDisciplinas.DataSource = model;
                gridDisciplinas.DataBind();
            }
        }
    }
}