using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PdfExample
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();


            Button.Clicked += Button_Clicked;
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            var client = new HttpClient();

            var response = await client.GetAsync("https://s1.q4cdn.com/806093406/files/doc_downloads/test.pdf");

            var data = await response.Content.ReadAsByteArrayAsync();

            PdfViewer.Data = data;
        }
    }
}
