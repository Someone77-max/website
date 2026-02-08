using System;

public partial class SiteMaster : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["Role"] == null)
        {
            Session["Role"] = UserRole.Guest;
            Session["Username"] = "Guest";
        }

        UserRole role = (UserRole)Session["Role"];

        lblUser.Text = Session["Username"].ToString();

        bool isUser = role == UserRole.User || role == UserRole.Admin;
        btnLogout.Visible = isUser;
        lnkAccount.Visible = isUser;
        lnkFriends.Visible = isUser;
        lnkRegister.Visible = !isUser;

        lnkTeacher.Visible = role == UserRole.Admin;
    }

    protected void btnLogout_Click(object sender, EventArgs e)
    {
        Session.Clear();
        Session["Role"] = UserRole.Guest;
        Session["Username"] = "Guest";

        Response.Redirect("/Default.aspx");
    }
}

