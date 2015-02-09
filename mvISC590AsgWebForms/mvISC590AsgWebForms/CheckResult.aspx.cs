using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace mvISC590AsgWebForms
{
    public partial class CheckResult : System.Web.UI.Page
    {
        public const string KeyEntityName = "ResultSet0";

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                InitializePage();
            }

        }

        protected void InitializePage()
        {
            Entity objEntity = new Entity();
            List<string[]> KeyResultSet = new List<string[]>();
            KeyResultSet = objEntity.GetEntity(KeyEntityName);

            gvKeyResultset.DataSource = ConvertEntityListToDataTable(KeyResultSet);
            gvKeyResultset.DataBind();
        }
        protected DataTable ConvertEntityListToDataTable(List<string[]> InputList)
        {
            DataTable dtEntity = new DataTable();

            

            return dtEntity;
        }
        protected bool CheckIfResultSetsMatch() 
        {
            bool ResultSetsMatch = false;

            return ResultSetsMatch;
        }

        protected void btnCheckResult_Click(object sender, EventArgs e)
        {

        }

        
    }
}