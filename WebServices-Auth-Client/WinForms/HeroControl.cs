using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.Net.Http.Headers;

namespace WinForms
{
    public partial class HeroControl : UserControl
    {

        Hero Hero;

        public HeroControl(Hero h)
        {
            InitializeComponent();
            Hero = h;

            RellenarCampos(Hero);

        }

        private async void buttonEditar_Click(object sender, EventArgs e)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Form1.DIRECCION_SERVIDOR);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(Form1.APP_JSON));
                if (Form1.Sesion != null)
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", Form1.Sesion.access_token);

                Hero nuevoHeroe = new Hero { Id = Hero.Id, Name = textBoxNombre.Text, Species = textBoxEspecie.Text, Type = textBoxTipo.Text, World = textBoxMundo.Text };
                HttpResponseMessage response = await client.PutAsJsonAsync(Form1.RUTA_HEROES + "/" + Hero.Id, nuevoHeroe);

                if (response.IsSuccessStatusCode)
                    Hero = nuevoHeroe;
            }
        }



        void RellenarCampos(Hero hero)
        {
            textBoxNombre.Text = Hero.Name;
            textBoxMundo.Text = Hero.World;
            textBoxEspecie.Text = Hero.Species;
            textBoxTipo.Text = Hero.Type;
            toolStripLabel1.Text = Hero.Name;
        }

        private async void buttonVer_Click(object sender, EventArgs e)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Form1.DIRECCION_SERVIDOR);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(Form1.APP_JSON));
                if (Form1.Sesion != null)
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", Form1.Sesion.access_token);

                HttpResponseMessage response = await client.GetAsync(Form1.RUTA_HEROES + "/" + Hero.Id);
                if (response.IsSuccessStatusCode)
                {
                    Hero heroe = await response.Content.ReadAsAsync<Hero>();
                    var dialogo = new FormNuevoHeroe();
                    dialogo.CambiarNombre(heroe.Name);
                    dialogo.CambiarTipo(heroe.Type);
                    dialogo.CambiarEspecie(heroe.Species);
                    dialogo.CambiarMundo(heroe.World);
                    dialogo.ShowDialog();
                }
            }
        }

        private async void toolStripButtonBorrar_Click(object sender, EventArgs e)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Form1.DIRECCION_SERVIDOR);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(Form1.APP_JSON));
                if (Form1.Sesion != null)
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", Form1.Sesion.access_token);

                HttpResponseMessage response = await client.DeleteAsync(Form1.RUTA_HEROES + "/" + Hero.Id);
                if (response.IsSuccessStatusCode)
                {
                    this.Dispose();
                }
            }
        }
    }
}