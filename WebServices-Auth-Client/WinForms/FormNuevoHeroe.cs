using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms
{
    public partial class FormNuevoHeroe : Form
    {
        public FormNuevoHeroe()
        {
            InitializeComponent();
        }

        public string DarNombre()
        {
            return textBoxNombre.Text;
        }

        public string DarEspecie()
        {
            return textBoxEspecie.Text;
        }

        public string DarTipo()
        {
            return textBoxTipo.Text;
        }

        public string DarMundo()
        {
            return textBoxMundo.Text;
        }

        public void CambiarNombre(String nombre)
        {
            textBoxNombre.Text = nombre;
        }

        public void CambiarTipo(String tipo)
        {
            textBoxTipo.Text = tipo;
        }

        public void CambiarEspecie(String especie)
        {
            textBoxEspecie.Text = especie;
        }
        public void CambiarMundo(String mundo)
        {
            textBoxMundo.Text = mundo;
        }
    }
}