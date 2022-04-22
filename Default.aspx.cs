using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

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

            notast.Clear();

        }
    }
}