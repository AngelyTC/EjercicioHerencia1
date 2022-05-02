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
    public partial class Delete : System.Web.UI.Page
    {
        static List<IngresosUniversidad> universidades = new List<IngresosUniversidad>();
        static string carne2;
        protected void Page_Load(object sender, EventArgs e)
        {
            string archivo = Server.MapPath("Universidades.json");
            StreamReader jsonStream = File.OpenText(archivo);
            string json = jsonStream.ReadToEnd();
            jsonStream.Close();

            universidades = JsonConvert.DeserializeObject<List<IngresosUniversidad>>(json);
        }

        protected void GuardarBorrado()
        {
            string json = JsonConvert.SerializeObject(universidades);
            string archivo = Server.MapPath("Universidades.json");
            System.IO.File.WriteAllText(archivo, json);
        }

        protected void btnBuscarAl_Click(object sender, EventArgs e)
        {
            carne2= txtCarneb.Text;
            bool encontrar2 = false;

            foreach (var u in universidades)
            {
                Alumnos AlEditado = u.Alumno.Find(c => c.NoCarnet == carne2);

                if (AlEditado != null)
                {
                    txtNombres.Text = AlEditado.nombre;
                   txtApellido.Text = AlEditado.Apellido;
                    encontrar2 = true;
                }
            }
            if (!encontrar2)
            {
                Response.Write("<script>alert('El alumno no se ha encotrado')</script>");
                carne2 = "";
            }
        }

        protected void btnBorrar_Click(object sender, EventArgs e)
        {
            foreach (var u in universidades)
            {
                Alumnos alumnoEliminado = u.Alumno.Find(c => c.NoCarnet == carne2);

                if(alumnoEliminado !=null)
                {
                    u.Alumno.Remove(alumnoEliminado);
                }

            }
            GuardarBorrado();
        }
    }
}