using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CarRepo;
namespace WebApplication1
{
    
    public partial class BuyCar : System.Web.UI.Page
    {
        
        Class1 repo = new Class1();
        protected void Page_Load(object sender, EventArgs e)
        {
            //int brandId = Convert.ToInt32(ddlBrand.SelectedValue);
            if (!IsPostBack)
            {
                
                BrandDropDown();
                //ModelDropDown();
            }
        }
        private void BrandDropDown()
        {
            ddlBrand.DataSource = repo.GetAllBrands();
            ddlBrand.DataTextField = "Key";
            ddlBrand.DataValueField = "Value";
            ddlBrand.DataBind();
        }
        private void ModelDropDown()
        {
            //ddlBrand.Items
            int brandId = Convert.ToInt32(ddlBrand.SelectedValue);
            ddlModel.DataSource = repo.GetAllModels(brandId);
            ddlModel.DataTextField = "Key";
            ddlModel.DataValueField = "Value";
            ddlModel.DataBind();
        }
        protected void btnBill_Click(object sender, EventArgs e)
        {
            int modelId = Convert.ToInt32(ddlModel.SelectedValue);
            int qty = Convert.ToInt32(txtQuantity.Text);
            txtTotal.Text = repo.GetTotal(modelId, qty).ToString();
        }

        protected void ddlBrand_SelectedIndexChanged(object sender, EventArgs e)
        {
            int brandId = Convert.ToInt32(ddlBrand.SelectedValue);
            ddlModel.DataSource = repo.GetAllModels(brandId);
            ddlModel.DataTextField = "Key";
            ddlModel.DataValueField = "Value";
            ddlModel.DataBind();
            int id = Convert.ToInt32(ddlModel.SelectedValue);
            txtPrice.Text = repo.GetPriceById(id).ToString();
        }
        protected void ddlModel_SelectedIndexChanged(object sender, EventArgs e)
        {
            int modelId = Convert.ToInt32(ddlModel.SelectedValue);
            txtPrice.Text = repo.GetPriceById(modelId).ToString();
        }
    }
}