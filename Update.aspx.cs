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
        static List<IngresosUniversidad> universidades = new List<IngresosUniversidad>();
        static string carne1;
        protected void Page_Load(object sender, EventArgs e)
        {
            string archivo = Server.MapPath("Universidades.json");
            StreamReader jsonStream = File.OpenText(archivo);
            string json = jsonStream.ReadToEnd();
            jsonStream.Close();

            universidades  = JsonConvert.DeserializeObject<List<IngresosUniversidad>>(json);
        }

     protected void GuardarEditado()
        {
            string json = JsonConvert.SerializeObject(universidades);
            string archivo = Server.MapPath("Universidades.json");
            System.IO.File.WriteAllText(archivo, json);
        }



        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            carne1 = txtIngrCarne.Text;
            bool encontrar = false;

            foreach (var u in universidades)
            {
                Alumnos AlEditado = u.Alumno.Find(c => c.NoCarnet == carne1);

                if(AlEditado != null)
                {
                    txtNombree.Text = AlEditado.nombre;
                    txtApellidos.Text = AlEditado.Apellido;
                    encontrar = true;
                }
            }
                if(!encontrar)
            {
                Response.Write("<script>alert('El alumno no se ha encotrado')</script>");
                carne1 = "";
            }
        }

        protected void btnModificar_Click(object sender, EventArgs e)
        {
            foreach (var u in universidades)
            {
                int editadoAlumno = u.Alumno.FindIndex(c => c.NoCarnet == carne1);

                if (editadoAlumno > -1)
                {
                    u.Alumno[editadoAlumno].Apellido = txtApellidos.Text;
                    u.Alumno[editadoAlumno].nombre = txtNombree.Text;

                    GuardarEditado();
                }
 
            }
        }
    }
}