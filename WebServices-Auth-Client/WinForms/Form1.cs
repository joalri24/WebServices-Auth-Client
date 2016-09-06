using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms
{
    public partial class Form1 : Form
    {

        // ---------------------------------------------
        // Constantes
        // ---------------------------------------------
        public const string DIRECCION_SERVIDOR = "http://localhost:2424/";
        public const string APP_JSON = "application/json";

        public const string RUTA_HEROES = "api/heroes";

        // ---------------------------------------------
        // Atributos
        // ---------------------------------------------

        // ---------------------------------------------
        // Constructor
        // ---------------------------------------------
        public Form1()
        {
            InitializeComponent();
        }

        // ---------------------------------------------
        // Métodos
        // ---------------------------------------------

        /// <summary>
        /// Obtiene todos los heroes enviando un request GET.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void ObtenerHeroes(object sender, EventArgs e)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(DIRECCION_SERVIDOR);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(APP_JSON));

                HttpResponseMessage response = await client.GetAsync(RUTA_HEROES);
                if (response.IsSuccessStatusCode)
                {
                    Hero[] heroes = await response.Content.ReadAsAsync<Hero[]>();
                    AgregarHeroControles(heroes);
                }
            }
        }

        /// <summary>
        /// Agrega un control por cada hero del arreglo pasado como parámetro.
        /// </summary>
        /// <param name="heroes"></param>
        void AgregarHeroControles(Hero[] heroes)
        {
            flowLayoutFondo.Controls.Clear();
            foreach (var hero in heroes)
            {
                AgregarHeroControl(hero);
            }
        }

        /// <summary>
        /// Agrega un HeroControl al layout del form.
        /// </summary>
        /// <param name="hero"></param>
        void AgregarHeroControl(Hero hero)
        {
            flowLayoutFondo.Controls.Add(new HeroControl(hero));
        }

        /// <summary>
        /// Obtiene todos los heroes enviando un request GET.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        async void AgregarHero(object sender, EventArgs e)
        {
            var form = new FormNuevoHeroe();
            if (form.ShowDialog() == DialogResult.OK)
            {
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri(DIRECCION_SERVIDOR);
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(APP_JSON));

                    Hero heroe = new Hero { Name = form.DarNombre(), Species = form.DarEspecie(), Type = form.DarTipo(), World = form.DarMundo() };
                    HttpResponseMessage response = await client.PostAsJsonAsync<Hero>(RUTA_HEROES, heroe);

                    if (response.IsSuccessStatusCode)
                    {
                        heroe = await response.Content.ReadAsAsync<Hero>();
                        AgregarHeroControl(heroe);
                    }

                }
            }
        }



    }
}
