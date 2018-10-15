using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using TallerApis.Xamarin.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TallerApis.Xamarin.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PublicacionPage : ContentPage
    {
        public PublicacionPage()
        {
            InitializeComponent();
            CargarPublicacion();
        }

        private void CargarPublicacion()
        {
            HttpClient client = new HttpClient();

            client.BaseAddress = new Uri("http://192.168.0.21");
            var request = client.GetAsync("TallerApis/api/Publicacion").Result;
            if (request.IsSuccessStatusCode)
            {
                var responseJson = request.Content.ReadAsStringAsync().Result;
                var response = JsonConvert.DeserializeObject<List<Publicacion>>(responseJson);
                listPublicacion.ItemsSource = response;
            }

                       
        }
    }
}