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
        static List<Catedratico> profesoresLista = new List<Catedratico>();
        static string ID2;
        protected void Page_Load(object sender, EventArgs e)
        {

            LeerP();
            leerA();

           
        }
        protected void LeerP()
        {
            string archivop = Server.MapPath("DatosProfesores.json");
            StreamReader jsonStreamp = File.OpenText(archivop);
            string jsonp = jsonStreamp.ReadToEnd();
            jsonStreamp.Close();

            profesoresLista = JsonConvert.DeserializeObject<List<Catedratico>>(jsonp);
        }

        protected void leerA()
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


        protected void GuardarBorradoP()
        {
            string json = JsonConvert.SerializeObject(profesoresLista);
            string archivo = Server.MapPath("DatosProfesores.json");
            System.IO.File.WriteAllText(archivo, json);
        }
        protected void btnBuscarProf_Click(object sender, EventArgs e)
        {
            ID2 = txtIdProfesor.Text;
            bool encontrar2 = false;

            foreach (var u in profesoresLista)
            {
                Catedratico CateEditado = profesoresLista.Find(c => c.idProfesor == ID2);

                if (CateEditado != null)
                {
                    txtNombreP.Text = CateEditado.nombre;
                    txtApellidoP.Text = CateEditado.Apellido;
                    encontrar2 = true;
                }
            }
            if (!encontrar2)
            {
                Response.Write("<script>alert('El Profesor no se ha encotrado')</script>");
                ID2 = "";
            }
        }

        protected void btnBorrarP_Click(object sender, EventArgs e)
        {
            foreach (var u in profesoresLista)
            {
                Catedratico CateEliminado = profesoresLista.Find(c => c.idProfesor == ID2);
                if (CateEliminado != null)
                {
                    profesoresLista.Remove(CateEliminado);
                    break;
                }
            }
            GuardarBorradoP();
        }
    }
}