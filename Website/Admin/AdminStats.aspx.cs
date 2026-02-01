using System;
using System.Collections.Generic;

public partial class AdminStats : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["Role"] == null || (UserRole)Session["Role"] != UserRole.Admin)
        {
            Response.Redirect("../Default.aspx");
            return;
        }

        int totalVisits = (int)(Application["TotalLogins"] ?? 0);
        int registeredLogins = (int)(Application["RegisteredLogins"] ?? 0);
        int onlineUsers = (int)(Application["OnlineUsers"] ?? 0);

        int registeredOnline = 0;
        int guestsOnline = 0;

        var loggedInUsers = (List<string>)Application["LoggedInUsers"];
        if (loggedInUsers != null)
        {
            registeredOnline = loggedInUsers.Count;
            guestsOnline = onlineUsers - registeredOnline;
        }
        else
        {
            guestsOnline = onlineUsers;
        }

        lblTotalVisits.Text = "Total visits: " + totalVisits;
        lblRegisteredLogins.Text = "Registered logins: " + registeredLogins;
        lblOnlineUsers.Text = "Total online users: " + onlineUsers;
        lblRegisteredOnline.Text = "Registered users online: " + registeredOnline;
        lblGuestsOnline.Text = "Guests online: " + guestsOnline;
    }
}

