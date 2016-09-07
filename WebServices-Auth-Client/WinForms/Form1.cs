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
        public const string RUTA_LOGOUT = "api/Account/Logout";
        public const string RUTA_TOKEN = "Token";


        // ---------------------------------------------
        // Atributos
        // ---------------------------------------------

        public static Sesion Sesion;


        // ---------------------------------------------
        // Constructor
        // ---------------------------------------------
        public Form1()
        {
            InitializeComponent();
            Sesion = null;
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
                if(Sesion != null)
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", Sesion.access_token);

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
                    if (Sesion != null)
                        client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", Sesion.access_token);

                    Hero heroe = new Hero { Name = form.DarNombre(), Species = form.DarEspecie(), Type = form.DarTipo(), World = form.DarMundo() };
                    HttpResponseMessage response = await client.PostAsJsonAsync(RUTA_HEROES, heroe);

                    if (response.IsSuccessStatusCode)
                    {
                        heroe = await response.Content.ReadAsAsync<Hero>();
                        AgregarHeroControl(heroe);
                    }

                }
            }
        }

        /// <summary>
        /// Abre un dialogo donde el usuario puede escribir sus credenciales.
        /// Envía una petición POST con las credenciales proporcionadas. La respuesta 
        /// contiene un token que se utiliza para comunicarse con el servidor.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void IniciarSesion(object sender, EventArgs e)
        {
            FormIniciarSesion dialogo = new FormIniciarSesion();

            if(dialogo.ShowDialog() == DialogResult.OK)
            {
                toolStripLabelMensaje.Text = "Iniciando sesión...";
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri(DIRECCION_SERVIDOR);
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/x-www-form-urlencoded"));


                    var formContent = new FormUrlEncodedContent(new[]
                    {
                        new KeyValuePair<string, string>("grant_type", "password"),
                        new KeyValuePair<string, string>("username", dialogo.darLogin()),
                        new KeyValuePair<string, string>("password", dialogo.darcontraseña())
                    });
                    HttpResponseMessage response = await client.PostAsync(RUTA_TOKEN, formContent);

                    if (response.IsSuccessStatusCode)
                    {
                        Sesion = await response.Content.ReadAsAsync<Sesion>();
                        MessageBox.Show("Inicio de sesión exitoso!", "Inicio de sesión");
                        toolStripLabelMensaje.Text = "Sesión: " + Sesion.userName;
                        toolStripButtonLogout.Enabled = true;


                    }
                    else
                    {
                        MessageBox.Show("No fue posible iniciar sesión.", "Inicio de sesión");
                        toolStripLabelMensaje.Text = "Se debe iniciar sesión para obtener acceso a los datos.";
                    }
                        


                }
            }
        }


        /// <summary>
        /// Cierra la sesión, eliminando el token y enviando la petición 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void CerrarSesion(object sender, EventArgs e)
        {

            if (Sesion != null)
            {
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri(DIRECCION_SERVIDOR);
                    client.DefaultRequestHeaders.Accept.Clear();
                    if (Sesion != null)
                        client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", Sesion.access_token);

                    HttpResponseMessage response = await client.PostAsync(RUTA_LOGOUT, null);

                    if (response.IsSuccessStatusCode)
                    {
                        Sesion = null;
                        flowLayoutFondo.Controls.Clear();
                        toolStripButtonLogout.Enabled = false;
                        toolStripLabelMensaje.Text = "Se debe iniciar sesión para obtener acceso a los datos.";
                    }
                    else
                    {
                        toolStripLabelMensaje.Text = "No fue posible cerrar sesión.";
                    }
                }
            }
        }

    }
}
