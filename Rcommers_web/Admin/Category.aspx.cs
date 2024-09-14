using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Rcommers_web.Admin
{
    public partial class Category : System.Web.UI.Page
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter sda;
        DataTable dt;
        

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAddOrUpdate_Click(object sender, EventArgs e)
        {
            string actionName = string.Empty, imagePath = string.Empty, fileExtension = string.Empty;
            bool isValidToExecute = false;
            int categoryId = Convert.ToInt32(hfCategoryId.Value);
            con = new SqlConnection(Utils.getConnection());
            cmd = new SqlCommand("Category_Crud", con);
            cmd.Parameters.AddWithValue("@Action", categoryId == 0 ? "INSERT" : "UPDATE");
            cmd.Parameters.AddWithValue("@CategoryId", categoryId);
            cmd.Parameters.AddWithValue("@CategoryName", textCategoryName.Text.Trim());
            cmd.Parameters.AddWithValue("@IsActive", cbIsActive.Checked);
            if (fuCategoryImage.HasFile)
            {
                if (Utils.isValidExtension(fuCategoryImage.FileName)
                {
                    string newImageName = Utils.getUniqueId();
                    fileExtension = Path.GetExtension(fuCategoryImage.FileName);
                    imagePath = "Images/Category/" + newImageName.ToString() + fileExtension;
                    fuCategoryImage.PostedFile.SaveAs(Server .MapPath("~Images/Category/") + newImageName.ToString() + fileExtension;
                    cmd.Parameters.AddWithValue("@CateoryImageUrl", imagePath);
                }
 
            }
        }

        protected void btnClear_Click(object sender, EventArgs e)
        {

        }
    }
}