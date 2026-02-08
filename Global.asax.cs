using System;
using System.Collections.Generic;
using System.Web;

public class Global : HttpApplication
{
    void Application_Start(object sender, EventArgs e)
    {
        Application["Admins"] = new Dictionary<string, string>
        {
            { "admin", "1234" },
            { "admin2", "abcd" }
        };

        Application["Users"] = new Dictionary<string, string>
        {
            { "user1", "111" },
            { "user2", "222" },
            { "user3", "333" }
        };

        Application["TotalLogins"] = 0;
        Application["RegisteredLogins"] = 0;
        Application["OnlineUsers"] = 0;
    }

    void Session_Start(object sender, EventArgs e)
    {
        Session["Role"] = UserRole.Guest;
        Session["Username"] = "Guest";

        Application.Lock();
        Application["TotalLogins"] = (int)Application["TotalLogins"] + 1;
        Application["OnlineUsers"] = (int)Application["OnlineUsers"] + 1;
        Application.UnLock();
    }

    void Session_End(object sender, EventArgs e)
    {
        Application.Lock();
        Application["OnlineUsers"] = (int)Application["OnlineUsers"] - 1;
        Application.UnLock();
    }
}

