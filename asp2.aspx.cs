using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ejercicioAsp1_3035699
{
    public partial class asp2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ddlCategory.SelectedValue = Request.Cookies["ddlCategory"].Value;
            ddlSupplier.SelectedValue = Request.Cookies["ddlSupplier"].Value;
            strProduct.Text = Request.Cookies["strProduct"].Value;
            strDescription.Text = Request.Cookies["strDescription"].Value;
            strImage.Text = Request.Cookies["strImage"].Value;
            decimal DecPrice = Convert.ToDecimal(Request.Cookies["decPrice"].Value);
            decPrice.Text = DecPrice.ToString("c");
            lblNumberInStrock.Text = Request.Cookies["bytNumberInStock"].Value;
            lblNumberOnOrder.Text = Request.Cookies["bytNumberOnOrder"].Value;
            bytReorderLevel.Text = Request.Cookies["bytReorderLevel"].Value;

            Byte byNumberInStock = Convert.ToByte(Request.Cookies["bytNumberInStock"].Value);
            Byte byNumberOnOrder = Convert.ToByte(Request.Cookies["bytNumberOnOrder"].Value);
            decimal decValueInStock = DecPrice * byNumberInStock;
            decimal decValueOnOrder = DecPrice * byNumberOnOrder;
            bytNumberInStock.Text = " (Value: " + decValueInStock.ToString("c") + ")";
            bytNumberOnOrder.Text = " (Value: " + decValueOnOrder.ToString("c") + ")";
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {

        }

        protected void btnBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("Asp1.aspx");
        }
    }
}