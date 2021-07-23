using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;
using Negocio;

namespace Presentacion.Usuarios
{
    public partial class AltaUsuario : System.Web.UI.Page
    {
        UsuarioNegocio negocio = new UsuarioNegocio();
        public Usuario usuario = new Usuario();

        protected void Page_Load(object sender, EventArgs e)
        {
            usuario = (Usuario)Session["Usuario"];
            if (usuario.TipoUsuario.Id != 1)
            {
                Session.Add("error", "Permisos invalidos");
                Response.Redirect("../Info/PagError.aspx");
            }

            try
            {
                if (!IsPostBack)
                {
                    CargarDdl();


                }
            }
            catch (Exception)
            {

                throw;
            }


         


        }


        public void CargarDdl()
        {
            try
            {
               

                DdlTipoUsuario.DataSource = negocio.ListarTiposUsuarios();
                DdlTipoUsuario.DataValueField = "ID";
                DdlTipoUsuario.DataTextField = "Nombre";
                
                DdlTipoUsuario.DataBind();

            }
            catch (Exception)
            {

                throw;
            }

        }

        protected void DdlTipoUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (int.Parse(DdlTipoUsuario.SelectedValue) == 3)
            {
                TextBoxToken.Visible = true;
            }
            else
            {
                TextBoxToken.Visible = false;
            }
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            Usuario aux = new Usuario();
            
            try
            {
                aux.User = TextBoxNombre.Text;
                aux.Pass = TextBoxContrasenia.Text;
                aux.TipoUsuario= new TipoUsuario(int.Parse(DdlTipoUsuario.SelectedValue),DdlTipoUsuario.SelectedItem.ToString());
                if (aux.TipoUsuario.Id == 3)
                {
                    MedicoNegocio medicoNegocio = new MedicoNegocio();

                    if (medicoNegocio.Listar().Find(x=> x.Legajo== TextBoxToken.Text ) == null)
                    {
                        btnOkToken.Visible = true;
                        lblToken.Visible = true;
                         
                        return;

                    }
                    else
                    {
                        aux.Token = TextBoxToken.Text;
                        negocio.AgregarUsuario(aux);
                        string script = "confirmarAccion( 1 , 'RegistroUsuario.aspx')";
                        ScriptManager.RegisterStartupScript(this, typeof(Page), "MensajeOk", script, true);
                    }


                    
                }
                else
                {
                    aux.Token = "";
                    negocio.AgregarUsuario(aux);
                    string script = "confirmarAccion( 1 , 'RegistroUsuario.aspx')";
                    ScriptManager.RegisterStartupScript(this, typeof(Page), "MensajeOk", script, true);

                }
                

            }
            catch (Exception)
            {

                throw;
            }






        }

        protected void btnOkToken_Click(object sender, EventArgs e)
        {

            TextBoxToken.Text ="";
            btnOkToken.Visible = false;
            lblToken.Visible = false;

        }
    }
}