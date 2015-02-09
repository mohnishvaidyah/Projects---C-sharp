using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace mvISC590AsgWebForms
{
    public partial class WebFormsMain : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void lbComputeCost_Click(object sender, EventArgs e)
        {
            Response.Redirect("ComputeCost.aspx");
        }

        protected void lbComputeRisk_Click(object sender, EventArgs e)
        {
            Response.Redirect("RiskAssessment.aspx");
        }

        protected void lbCheckResult_Click(object sender, EventArgs e)
        {
            Response.Redirect("CheckResult.aspx");
        }
    }
}