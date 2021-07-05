using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;
using Negocio;

namespace Presentacion.Medicos
{
    public partial class RegistroMedicos : System.Web.UI.Page
    {
        public List<Medico> Lista;
        public List<Medico> listaNoFiltrada;
        protected void Page_Load(object sender, EventArgs e)
        {
            cargarMedicos();
        }
        public void cargarMedicos()
        {
            MedicoNegocio negocio = new MedicoNegocio();
            try
            {

                listaNoFiltrada = negocio.Listar();
                Lista = listaNoFiltrada.FindAll(x => x.Estado == true);

                //foreach  ( Medico item in Lista)
                //{
                //    item.Especialidades = negocio.ListarEspecialidadesMedico(item.ID);
                //    item.ObrasSociales = negocio.ListarObrasSocialesMedico(item.ID);
                //    item.DiasHorarios = negocio.ListarDiasHorariosMedicos(item.ID);
                //}

                
                Session.Add("ListaMedicos", Lista);


                DGB.DataSource = Lista.Find(x=> x.ID== 1).Especialidades;
                DGB.DataBind();


            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}