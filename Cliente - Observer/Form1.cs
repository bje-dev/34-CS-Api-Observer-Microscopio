using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cliente___Observer
{
    public partial class Form1 : Form
    {
        private readonly HttpClient httpClient = new HttpClient();
        private readonly Timer timer = new Timer();

        private Habitante claseObservada = new Habitante();
        private FloraObserver floraObserver = new FloraObserver();
        private FaunaObserver faunaObserver = new FaunaObserver();

        public Form1()
        {
            InitializeComponent();
            timer.Interval = 2000;
            timer.Tick += async (sender, e) => await ObtenerDatosHabitante();

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            claseObservada.RegistrarObservador(floraObserver);
            claseObservada.RegistrarObservador(faunaObserver);

            timer.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer.Stop();
            claseObservada.QuitarObservador(floraObserver);
            claseObservada.QuitarObservador(faunaObserver);
        }

        private async Task ObtenerDatosHabitante()
        {
            try
            {
                string apiUrl = "http://localhost:5281/api/Habitante/habitante";
                HttpResponseMessage response = await httpClient.GetAsync(apiUrl);
              
                if (response.IsSuccessStatusCode)
                {

                    string apiResponse = await response.Content.ReadAsStringAsync();
                    var objetoApi = JsonConvert.DeserializeObject<Habitante>(apiResponse);
                    MostrarResultado(objetoApi.Nombre.ToString(), objetoApi.Color.ToString(), objetoApi.Tamaño.ToString(), objetoApi.Tipo.ToString());
                }
                else
                {
                    MessageBox.Show($"Error en la solicitud. Código de estado: {response.StatusCode}");
                }
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show($"Error en la solicitud HTTP: {ex.Message}");
            }
        }

        public void MostrarResultado(string nombre, string color, string tamaño, string tipo)
        {
            
                textBox1.Text = nombre;
                textBox2.Text = color;
                textBox3.Text = tamaño;
                textBox4.Text = tipo;

            
            claseObservada.Nombre = nombre;
            claseObservada.Color = color;
            claseObservada.Tamaño = tamaño;
            claseObservada.Tipo = tipo;

            claseObservada.SomeBusinessLogic();

        }
    }
}
