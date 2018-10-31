using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab4
{
    public partial class PageLifeCycleDemo : System.Web.UI.Page
    {
        String msg = "Events in Page Life Cycle in ASP.NET" + "<BR>";

        protected void Page_PreInit(object sender, EventArgs e)
        {
            msg = msg + "<BR>" + "Pre Init";
        }

        protected void Page_Init(object sender, EventArgs e)
        {
            msg = msg + "<BR>" + "Init";
        }

        protected void Page_InitComplete(object sender, EventArgs e)
        {
            msg = msg + "<BR>" + "Init Complete";
        }

        protected void Page_PreLoad(object sender, EventArgs e)
        {
            msg = msg + "<BR>" + "Pre Load";
        }

        protected void Page_LoadComplete(object sender, EventArgs e)
        {
            msg = msg + "<BR>" + "Load Complete";
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            msg = msg + "<BR>" + "Load";
        }
        protected void Page_PreRender(object sender, EventArgs e)
        {
            msg = msg + "<BR>" + "Pre Render";
            Label1.Text = msg;
        }

    }
}