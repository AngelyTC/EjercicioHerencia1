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
    public partial class DeleteProfesores : System.Web.UI.Page
    {
        static List<Catedratico  > profesoresLista = new List<Catedratico>();
        static string ID2;
        protected void Page_Load(object sender, EventArgs e)
        {
            string archivo = Server.MapPath("DatosProfesores.json");
            StreamReader jsonStream = File.OpenText(archivo);
            string json = jsonStream.ReadToEnd();
            jsonStream.Close();

            profesoresLista  = JsonConvert.DeserializeObject<List<Catedratico>> (json);
        }

        protected void btnBuscarP_Click(object sender, EventArgs e)
        {
            ID2 = txtIdP.Text;
            bool encontrar2 = false;

            foreach (var u in profesoresLista )
            {
                Catedratico  CateEditado = profesoresLista.Find(c => c.idProfesor == ID2);

                if (CateEditado != null)
                {
                   txtNombrePro.Text = CateEditado.nombre;
                    txtApellidoPro.Text = CateEditado.Apellido;
                    encontrar2 = true;
                }
            }
            if (!encontrar2)
            {
                Response.Write("<script>alert('El Profesor no se ha encotrado')</script>");
                ID2 = "";
            }
        }

        protected void GuardarBorradoP()
        {
            string json = JsonConvert.SerializeObject(profesoresLista );
            string archivo = Server.MapPath("DatosProfesores.json");
            System.IO.File.WriteAllText(archivo, json);
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            foreach (var u in profesoresLista)
            {
                Catedratico CateEliminado = profesoresLista.Find(c => c.idProfesor == ID2);

                if (CateEliminado != null)
                {
                    profesoresLista.Remove(CateEliminado);
                }

            }
            GuardarBorradoP();
        }
    }
}