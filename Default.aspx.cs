using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Newtonsoft.Json;

namespace EjercicioHerencia1
{
    public partial class _Default : Page
    {
        static List<Alumnos> alumnos = new List<Alumnos>();
        static List<int> notast = new List<int>();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        protected void btnNotas_Click(object sender, EventArgs e)
        {
            int notatemp = Convert.ToInt16(txtNotas.Text);
            notast.Add(notatemp);
            GridView1.DataSource = notast;
            GridView1.DataBind();
        }

        protected void btnIngreso_Click(object sender, EventArgs e)
        {
            Alumnos alumno = new Alumnos();
            alumno.NoCarnet = txtCarne.Text;
            alumno.nombre = txtNombre.Text;
            alumno.Apellido = txtApellido.Text;
            alumno.Notas = notast;
            alumno.Direccion = txtDireccion.Text;
            alumno.FechaNacimiento = txtFecha.SelectedDate;
            alumno.edad = Convert.ToInt32(txtEdad.Text);

            alumnos.Add(alumno);
                       
            Guardar();

            notast.Clear();
        }

        private void Guardar()
        {
            //Se serializa (convierte) la lista en formato Json y se guarda en una variable de tipo string
            string json = JsonConvert.SerializeObject(alumnos);

            //El nombre del archivo
            string archivo = Server.MapPath("DatosAlumnoss.json");

            //Se escribe la variable que contiene el json al archivo en un solo paso
            //con WriteAllText se escribe todo de un solo
            System.IO.File.WriteAllText(archivo, json);
        }


    }
}