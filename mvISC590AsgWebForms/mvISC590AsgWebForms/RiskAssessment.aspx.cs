using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace mvISC590AsgWebForms
{
    public partial class RiskAssessment : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //Populate Dropdown lists
                PopulateNodeDDls();
            }
        }

        protected void PopulateNodeDDls()
        {
            //Prenode Level 1 items
            ddlPrenode1.Items.Add(new ListItem("Select Prepare node Level 1", "0"));
            ddlPrenode1.Items.Add(new ListItem("Gather Knowledge", "11"));
            ddlPrenode1.Items.Add(new ListItem("Gain insider access", "41"));

            //Prenode Level 2 items
            ddlPrenode2.Items.Add(new ListItem("Select Prepare node Level 2", "0"));
            ddlPrenode2.Items.Add(new ListItem("From insider", "12"));
            ddlPrenode2.Items.Add(new ListItem("From Components", "32"));

            //Prenode Level 3 items
            ddlPrenode3.Items.Add(new ListItem("Select Prepare node Level 3", "0"));
            ddlPrenode3.Items.Add(new ListItem("Access directly", "22"));
            ddlPrenode3.Items.Add(new ListItem("Access indirectly", "23"));

            //Level 1 Executenode items
            ddlExecute1.Items.Add(new ListItem("Select Execute node Level 1", "0"));
            ddlExecute1.Items.Add(new ListItem("Hardware Attack", "51"));
            ddlExecute1.Items.Add(new ListItem("Software Attack", "81"));
            ddlExecute1.Items.Add(new ListItem("Network Attack", "91"));

            //Level 2 Executenode items
            ddlExecute2.Items.Add(new ListItem("Select Execute node Level 2", "0"));
            ddlExecute2.Items.Add(new ListItem("Jam Scanner", "52"));
            ddlExecute2.Items.Add(new ListItem("Attack Components", "62"));
            ddlExecute2.Items.Add(new ListItem("Attack Wired Connection", "92"));
            ddlExecute2.Items.Add(new ListItem("Attack Wireless Connection", "102"));

            //Level 3 Executenode items
            ddlExecute3.Items.Add(new ListItem("Select Execute node Level 3", "0"));
            ddlExecute3.Items.Add(new ListItem("Swap boot media", "63"));
            ddlExecute3.Items.Add(new ListItem("Destroy removable media", "73"));

        }

        protected void btnCompute_Click(object sender, EventArgs e)
        {
            int prenodeID1 = 0, prenodeID2 = 0, prenodeID3 = 0;
            int exenodeID1 = 0, exenodeID2 = 0, exenodeID3 = 0;
            {
                if (ddlPrenode1.SelectedValue == "11")
                {
                    prenodeID1 = 11;

                    if (ddlPrenode2.SelectedValue == "12")
                    {
                        if (ddlPrenode3.SelectedValue == "0")
                        {
                            prenodeID2 = 12;
                            prenodeID3 = 0;
                        }
                        else
                        {
                            prenodeID2 = 0;
                        }
                    }
                    else if (ddlPrenode2.SelectedValue == "32")
                    {
                        prenodeID2 = 32;
                        if (ddlPrenode3.SelectedValue == "22")
                        {
                            prenodeID3 = 22;
                        }
                        else if (ddlPrenode3.SelectedValue == "23")
                        {
                            prenodeID3 = 23;
                        }

                    }
                }
                else if (ddlPrenode1.SelectedValue == "41")
                {
                    if (ddlPrenode2.SelectedValue == "0" && ddlPrenode3.SelectedValue == "0")
                    {
                        prenodeID1 = 41;
                    }
                    else
                    {
                        prenodeID1 = 0;
                    }
                }

            }

            if (ddlExecute1.SelectedValue == "51")
            {
                exenodeID1 = 51;
                if (ddlExecute2.SelectedValue == "52")
                {
                    if (ddlExecute3.SelectedValue == "0")
                    {
                        exenodeID2 = 52;
                    }
                    else
                    {
                        exenodeID2 = 0;
                    }
                }
                else if (ddlExecute2.SelectedValue == "62")
                {
                    exenodeID2 = 62;
                    if (ddlExecute3.SelectedValue == "63")
                    {
                        exenodeID3 = 63;
                    }
                    else if (ddlExecute3.SelectedValue == "73")
                    {
                        exenodeID3 = 73;
                    }
                }
                else
                {
                    exenodeID3 = 0;
                }
            }
            else if (ddlExecute1.SelectedValue == "91")
            {
                exenodeID1 = 91;
                if (ddlExecute2.SelectedValue == "92")
                {
                    if (ddlExecute3.SelectedValue == "0")
                    {
                        exenodeID2 = 92;
                    }
                    else
                    {
                        exenodeID2 = 0;
                    }
                }
                else if (ddlExecute2.SelectedValue == "102")
                {
                    if (ddlExecute3.SelectedValue == "0")
                    {
                        exenodeID2 = 102;
                    }
                    else
                    {
                        exenodeID2 = 0;
                    }
                }
            }
            else if (ddlExecute1.SelectedValue == "81")
            {
                if (ddlExecute2.SelectedValue == "0" && ddlExecute3.SelectedValue == "0")
                {
                    exenodeID1 = 81;
                }
                else
                {
                    lbResult.Text = "Invalid";
                }
            }

            ComputeRiskScore(prenodeID1, prenodeID2, prenodeID3, exenodeID1, exenodeID2, exenodeID3);
        }

        protected int ComputeRiskScore(int PrenodeID1, int PrenodeID2, int PrenodeID3, int ExenodeID1, int ExenodeID2, int ExenodeID3)
        {
           int score = 0, prepare = 0, execute = 0;
                {
                    if (PrenodeID1 == 11)
                    {
                        if (PrenodeID2 == 12)
                        {
                            if (PrenodeID3 == 0)
                            {
                                prepare = 6;
                            }
                            else
                            {
                                prepare = 0;
                            }
                        }
                        else if (PrenodeID2 == 32)
                        {

                            if (PrenodeID3 == 22)
                            {
                                prepare = 5;
                            }
                            else if (PrenodeID3 == 23)
                            {
                                prepare = 3;
                            }
                        }
                    }
                    else if (PrenodeID1 == 41)
                    {
                        prepare = 10;
                    }
                }

                if (ExenodeID1 == 51)
                {

                    if (ExenodeID2 == 52)
                    {
                        execute = 7;
                    }
                    else if (ExenodeID2 == 62)
                    {
                        if (ExenodeID3 == 63)
                        {
                            execute = 4;
                        }
                        else if (ExenodeID3 == 73)
                        {
                            execute = 6;
                        }
                    }
                }
                else if (ExenodeID1 == 91)
                {
                    if (ExenodeID2 == 92)
                    {
                        execute = 5;
                    }
                    else if (ExenodeID2 == 102)
                    {
                        execute = 9;
                    }
                }
                else if (ExenodeID1 == 81)
                {
                    execute = 2;
                }

                score = prepare * execute;
                if (score == 0)
                {
                    lbResult.Text = "Invalid Vector selected";
                }
                else
                {
                    lbResult.Text = "Risk score: " + score.ToString();
                }
                return score;
        }
    } 
}