using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Camara_en_Web
{
    public partial class Layout : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            jquery();
        }

        private void jquery()
        {
            ScriptManager.ScriptResourceMapping.AddDefinition(
                "jquery", new ScriptResourceDefinition
                {
                    Path = "~/jquery-3.5.1.slim.min.js",
                    CdnDebugPath = "~/jquery-3.5.1.slim.min.js",
                    CdnSupportsSecureConnection = true,
                    LoadSuccessExpression = "Window.jQuery"
                });
        }
    }
}