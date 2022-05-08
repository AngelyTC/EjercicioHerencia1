using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using Newtonsoft.Json;

namespace EjercicioHerencia1
{
    public partial class Update : System.Web.UI.Page
    {
        static List<PersonaAdmin> datosAdministra = new List<PersonaAdmin>();
        static string igss;
        protected void Page_Load(object sender, EventArgs e)
        {
            string archivo = Server.MapPath("DatosPersonal.json");
            StreamReader jsonStream = File.OpenText(archivo);
            string json = jsonStream.ReadToEnd();
            jsonStream.Close();

            datosAdministra = JsonConvert.DeserializeObject<List<PersonaAdmin>>(json);
        }

     protected void GuardarEditado()
        {
            string json = JsonConvert.SerializeObject(datosAdministra);
            string archivo = Server.MapPath("DatosPersonal.json");
            System.IO.File.WriteAllText(archivo, json);
        }



        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            igss = txtIngrIgss.Text;
            bool encontrar = false;

            foreach (var u in datosAdministra)
            {
                PersonaAdmin AlEditado = datosAdministra.Find(c => c.NoIGSS == igss);

                if(AlEditado != null)
                {
                    txtNombree.Text = AlEditado.nombre;
                    txtApellidos.Text = AlEditado.Apellido;
                    txtDireccion.Text = AlEditado.Direccion;
                    txtProfesionU.Text = AlEditado.Profesion;
                    CalendarIn.SelectedDate = AlEditado.fechaInicio;
                    CalendarF.SelectedDate = AlEditado.fechaFin;
                    encontrar = true;
                }
            }
                if(!encontrar)
            {
                Response.Write("<script>alert('El personal no se ha encotrado')</script>");
                igss = "";
                txtNombree.Text = " ";
                txtApellidos.Text = " ";
                txtDireccion.Text = " ";
                txtProfesionU.Text = " ";

            }
        }

        protected void btnModificar_Click(object sender, EventArgs e)
        {
            foreach (var u in datosAdministra)
            {
                //en modificar se usa findIndex
                int editadoAdmin = datosAdministra.FindIndex(c => c.NoIGSS == igss);

                if (editadoAdmin > -1)
                {
                   u.nombre  = txtNombree.Text;
                    u.Apellido = txtApellidos.Text;
                    u.Direccion = txtDireccion.Text;
                    u.Profesion = txtProfesionU.Text;
                    u.fechaInicio = CalendarIn.SelectedDate;
                    u.fechaFin = CalendarF.SelectedDate;

                    GuardarEditado();
                }

            }
        }
    }
}