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
    public partial class PersonalAdmi : System.Web.UI.Page
    {
        static List<PersonaAdmin> datosAdministra = new List<PersonaAdmin>();
        int edadPer = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                leerAdmi();
            }
        }

        protected void leerAdmi()
        {
            string archivo = Server.MapPath("DatosPersonal.json");
            StreamReader jsonStream = File.OpenText(archivo);
            string json = jsonStream.ReadToEnd();
            jsonStream.Close();

            datosAdministra = JsonConvert.DeserializeObject<List<PersonaAdmin>>(json);
        }

        protected void btnIngresarA_Click(object sender, EventArgs e)
        {
            PersonaAdmin  datosA = new PersonaAdmin();
            datosA.NoIGSS = txtIGSS.Text;
            datosA.nombre = txtNombreA.Text;
            datosA.Apellido = txtApellidoA .Text;
            datosA.Direccion = txtDireccionA.Text;
            datosA.Profesion= txtProfesion.Text;
            datosA.fechaInicio = CalendarInicio.SelectedDate;
            datosA.fechaFin =CalendarFin.SelectedDate;
            datosA.edad = Convert.ToInt32(txtEdadP.Text);
            datosAdministra.Add(datosA);
            GuardarAdmin();
        }

        private void GuardarAdmin()
        {
            string json = JsonConvert.SerializeObject(datosAdministra);

            string archivo = Server.MapPath("DatosPersonal.json");

            System.IO.File.WriteAllText(archivo, json);
        }

        private void ObtenerEdad()
        {
            DateTime FechaToday = DateTime.Today;
            edadPer = FechaToday.Year - CalendarFechaN.SelectedDate.Year;
           txtEdadP.Text = edadPer.ToString();
        }

        protected void btnEdadP_Click(object sender, EventArgs e)
        {
            ObtenerEdad();
        }
    }
}