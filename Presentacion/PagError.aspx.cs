using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Presentacion
{
    public partial class PagError : System.Web.UI.Page
    {
        public string error;
        protected void Page_Load(object sender, EventArgs e)
        {
            error = (string)Session["error"];
        }
    }
}