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

        #region "Local methods"
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

            int count = InputList.Count;
            foreach (string item in InputList[0])
            {
                //Add column to dtEntity
                dtEntity.Columns.Add(item);
            }
            for (int i = 1; i < count; i++)
            {
                DataRow objRow = dtEntity.NewRow();
                string[] element = InputList[i];
                for (int j = 0; j < element.Count(); j++)
                {
                    if (element[j] == "")
                    {
                        objRow[j] = "null";
                    }
                    else
                    {
                        objRow[j] = element[j];
                    }
                }
                dtEntity.Rows.Add(objRow);
            }
            return dtEntity;
        }
        protected bool CheckIfResultSetsMatch() 
        {
            bool ResultSetsMatch = false;
            Entity objEntity = new Entity();
            
            List<string[]> keyEntityList = objEntity.GetEntity(KeyEntityName);
            DataTable dtKeyEntity = ConvertEntityListToDataTable(keyEntityList);
            
            List<string[]> matchEntityList = objEntity.GetEntity(txtEntityName.Text);
            DataTable dtmatchEntity = ConvertEntityListToDataTable(matchEntityList);

            if (dtKeyEntity.Columns.Count == dtmatchEntity.Columns.Count)
            {
                if (dtKeyEntity.Rows.Count == dtmatchEntity.Rows.Count)
                {
                    string keyElement = "";
                    string matchElement = "";
                    for (int i = 0; i < keyEntityList.Count(); i++)
                    {
                        string[] entityList = keyEntityList[i];
                        for (int j = 0; j < entityList.Length; j++)
                        {
                            keyElement = entityList + entityList[j];
                        }
                    }
                    for (int k = 0; k < matchEntityList.Count(); k++)
                    {
                        string[] matchentityList = matchEntityList[k];
                        for (int l = 0; l < matchentityList.Length; l++)
                        {
                            matchElement = matchentityList + matchentityList[l];
                        }
                    }
                    if (keyElement == matchElement)
                    {
                        ResultSetsMatch = true;
                    }
                }
            }
            return ResultSetsMatch;
        }

        protected void PopulateMatchResultSet()
        {
            Entity objEntity = new Entity();
            List<string[]> ResultSet = new List<string[]>();
            string entityname = txtEntityName.Text;
            int maxrowcnt;
            
            if (txtRowCnt.Text == "")
            {
              ResultSet = objEntity.GetEntity(entityname);
            }
            else
            {
              maxrowcnt = Convert.ToInt16(txtRowCnt.Text);
              ResultSet = objEntity.GetEntity(entityname, maxrowcnt);
            } 
            
            lblRowCnt.Text = "RowCnt: " + objEntity.RowCnt.ToString();
            lblColCnt.Text = "ColCnt: " + objEntity.ColCnt.ToString();

            gvMatchResultset.DataSource = ConvertEntityListToDataTable(ResultSet);
            gvMatchResultset.DataBind();
        }
        #endregion

        #region "Button Click Event"
        protected void btnCheckResult_Click(object sender, EventArgs e)
        {
            PopulateMatchResultSet();
            lblMatch.Text = "Match: " + CheckIfResultSetsMatch().ToString();

        }
        #endregion

    }
}