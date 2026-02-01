using System;
using System.Web.UI;

public partial class Login : System.Web.UI.Page
{
    private const string CorrectUser = "admin";
    private const string CorrectPass = "1234";

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (Session["Role"] == null)
            {
                Session["Role"] = UserRole.Guest;
                Session["Username"] = "Guest";
            }
        }

        UpdateStats();
    }

    protected void btnLogin_Click(object sender, EventArgs e)
    {
        string user = txtUsername.Text.Trim();
        string pass = txtPassword.Text.Trim();

        if (user == CorrectUser && pass == CorrectPass)
        {
            Session["Username"] = user;
            Session["Role"] = UserRole.Admin;

            Application.Lock();
            int total = (Application["TotalLogins"] != null) ? (int)Application["TotalLogins"] : 0;
            Application["TotalLogins"] = total + 1;
            Application.UnLock();

            lblMessage.Text = "You've logged in successfully!";
            lblMessage.ForeColor = System.Drawing.Color.Green;

            Response.Redirect("/Default.aspx");
        }
        else
        {
            lblMessage.Text = "Username or password are incorrect.";
            lblMessage.ForeColor = System.Drawing.Color.Red;
        }

        UpdateStats();
    }

    protected void btnForgot_Click(object sender, EventArgs e)
    {
        Response.Redirect("RecoverPassword.aspx");
    }

    private void UpdateStats()
    {
        int total = (Application["TotalLogins"] != null) ? (int)Application["TotalLogins"] : 0;
        lblStats.Text = "Total users: " + total;
    }
}

