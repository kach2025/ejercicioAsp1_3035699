using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ejercicioAsp1_3035699
{
    public partial class Asp1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnConfirm_Click(object sender, EventArgs e)
        {
            Response.Cookies["ddlCategory"].Value = ddlCategory.SelectedValue;
            Response.Cookies["ddlSupplier"].Value = ddlSupplier.SelectedValue;
            Response.Cookies["strProduct"].Value = strProduct.Text;
            Response.Cookies["strDescription"].Value = strDescription.Text;
            Response.Cookies["strImage"].Value = strImage.Text;
            Response.Cookies["decPrice"].Value = decPrice.Text;
            Response.Cookies["bytNumberInStock"].Value = bytNumberInStock.Text;
            Response.Cookies["bytNumberOnOrder"].Value = bytNumberOnOrder.Text;
            Response.Cookies["bytReorderLevel"].Value = bytReorderLevel.Text;
            Response.Redirect("asp2.aspx");
        }
    }
}