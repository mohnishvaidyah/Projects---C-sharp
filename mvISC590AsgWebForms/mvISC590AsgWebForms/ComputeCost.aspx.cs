using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace mvISC590AsgWebForms
{
            
    public partial class ComputeCost : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
            
        }
        
        protected void btnCompute_Click(object sender, EventArgs e)
        {
            double CleaningCharge = Convert.ToDouble(txtCleaningCharge.Text);
            double XRayCharge = Convert.ToDouble(txtXrayCharge.Text);
            double CrownCharge = Convert.ToDouble(txtCrownCharge.Text);
            int CleaningQty = Convert.ToInt32(txtCleaningQty.Text);
            int XRayQty = Convert.ToInt32(txtXrayQty.Text);
            int CrownQty = Convert.ToInt32(txtCrownQty.Text);
            double patientCost = ComputePatientCost(CleaningCharge, XRayCharge, CrownCharge, CleaningQty, XRayQty, CrownQty);
            string value = string.Format("{0:N2}", patientCost);
            lblPatientCost.Text = "Patient Cost: " + value;            
        }

        protected double ComputePatientCost(double CleaningCharge, double XRayCharge, double CrownCharge, int CleaningQty,int XRayQty, int CrownQty) 
        {
            double patientCost = 0.0;
            double p1 = CleaningCharge * CleaningQty;
            double p2 = XRayCharge * XRayQty;
            double p3 = CrownCharge * CrownQty;
            patientCost = p1 * 0.05 + p2 * 0.1 + p3 * 0.25;
            lblCleaningCost.Text = p1.ToString();
            lblXrayCost.Text = p2.ToString();
            lblCrownCost.Text = p3.ToString();
            return patientCost;
        }
    }
}