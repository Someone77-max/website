using System;
using System.Data;
using System.Collections.Generic;

public partial class AdminUsers : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if ((UserRole)Session["Role"] != UserRole.Admin)
            Response.Redirect("../Default.aspx");

        if (!IsPostBack)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Username");
            dt.Columns.Add("Password");
            dt.Columns.Add("Admin");

            foreach (var a in (Dictionary<string, string>)Application["Admins"])
                dt.Rows.Add(a.Key, a.Value, "Yes");

            foreach (var u in (Dictionary<string, string>)Application["Users"])
                dt.Rows.Add(u.Key, u.Value, "No");

            gvUsers.DataSource = dt;
            gvUsers.DataBind();
        }
    }
}

