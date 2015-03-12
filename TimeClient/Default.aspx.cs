using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //Timer1.Enabled = true;
    }
    protected void Timer1_Tick(object sender, EventArgs e)
    {
        TimeService.ItimeServiceClient ts = new TimeService.ItimeServiceClient();
        //Timer1.Interval = 1000;
        lblTime.Text = ts.GetCurrentTime();
    }
}