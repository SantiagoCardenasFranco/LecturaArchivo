using Compilador.src.cache;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LecturaArchivo
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void buscar_Click(object sender, EventArgs e)
        {
            url.Text = ObtainUrl();
            if (url.Text.Contains(".XML") || url.Text.Contains(".xml") || url.Text.Contains(".html") || url.Text.Contains(".txt"))
            {
                StreamReader lector;
                try
                {
                    lector = File.OpenText(url.Text);
                    List<string> Lineas = new List<string>();
                    while (!lector.EndOfStream)
                    {
                        Lineas.Add(lector.ReadLine());
                    }
                    info.Lines = Lineas.ToArray();
                }
                catch (ArgumentException exp)
                {
                    Console.WriteLine("La ruta no debe estar vacia", exp.Message);
                }
            }
            else
            {
                MessageBox.Show("Esta extensión no está permitida");
                url.Clear();
            }

        }

        private String ObtainUrl()
        {
            string path = string.Empty;
            OpenFileDialog dialog = new OpenFileDialog();

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                path = dialog.FileName;

            }
            return path;
        }

        private void limpiar_Click(object sender, EventArgs e)
        {
            url.Clear();
            info.Clear();
            caheInmediata.Clear();

        }

        private void cache_Click(object sender, EventArgs e)
        {
            ProgramaFuente cache = ProgramaFuente.obtenerProgramaFuente();
            cache.inicializar();

            foreach (String valorLinea in info.Lines)
            {
                cache.agregarLinea(valorLinea);
            }
            cache.agregarLinea("@EOF@");

            List<Linea> lineasCache = cache.obtenerLineas();
            List<string> Lineas = new List<string>();
            try
            {
                foreach (Linea linea in lineasCache)
                {
                    Lineas.Add(linea.NumeroLineas + " " + linea.Contenido);
                }
                caheInmediata.Lines = Lineas.ToArray();
            }
            catch
            {
                MessageBox.Show("No pudo ser guardad");
            }
            url.Clear();
            info.Clear();
        }
    }
}
