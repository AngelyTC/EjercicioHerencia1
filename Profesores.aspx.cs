using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Newtonsoft.Json;
using System.IO;

namespace EjercicioHerencia1
{
    public partial class Profesores : System.Web.UI.Page
    {
        static List<Catedratico> datosProfesores = new List<Catedratico>();
        int edadP = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack )
            {
                leerProfe();
            }
        }

        protected void leerProfe()
        {
            string archivo = Server.MapPath("DatosProfesores.json");
            StreamReader jsonStream = File.OpenText(archivo);
            string json = jsonStream.ReadToEnd();
            jsonStream.Close();

           datosProfesores   = JsonConvert.DeserializeObject<List<Catedratico >>(json);
        }

        protected void btnIngreso_Click(object sender, EventArgs e)
        {
            Catedratico   datos1 = new Catedratico ();
            datos1.idProfesor =txtId.Text;
            datos1.nombre = txtNombreP.Text;
            datos1.Apellido = txtApellidoP.Text;
            datos1.Direccion = txtDireccionP.Text;
            datos1.FechaNacimiento = Calendar1.SelectedDate;
            datos1.titulo = txtTitulo.Text;
            datos1.edad = Convert.ToInt32 (txtEdad.Text);

            /*datos1.edad = edadP;*/
           

            datosProfesores.Add(datos1);
            GuardarProfesores();

           
        }

        private void GuardarProfesores()
        {
            string json = JsonConvert.SerializeObject(datosProfesores);

            string archivo = Server.MapPath("DatosProfesores.json");

            System.IO.File.WriteAllText (archivo, json);
        }

        private void ObtenerEdad()
        {
           DateTime FechaToday = DateTime.Today;
          edadP = FechaToday.Year  - Calendar1.SelectedDate.Year;
             txtEdad.Text = edadP.ToString() ;
        }

        protected void btnEdad_Click(object sender, EventArgs e)
        {
            ObtenerEdad();
        }
    }
}