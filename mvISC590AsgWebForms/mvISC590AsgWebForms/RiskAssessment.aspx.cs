﻿using System;
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
            int prenodeID1 = Convert.ToInt32(ddlPrenode1.SelectedValue);
            int prenodeID2 = Convert.ToInt32(ddlPrenode2.SelectedValue); 
            int prenodeID3 = Convert.ToInt32(ddlPrenode3.SelectedValue);
            int exenodeID1 = Convert.ToInt32(ddlExecute1.SelectedValue);
            int exenodeID2 = Convert.ToInt32(ddlExecute2.SelectedValue);
            int exenodeID3 = Convert.ToInt32(ddlExecute3.SelectedValue);
            ComputeRiskScore(prenodeID1, prenodeID2, prenodeID3, exenodeID1, exenodeID2, exenodeID3);
        }

        protected int ComputeRiskScore(int PrenodeID1, int PrenodeID2, int PrenodeID3, int ExenodeID1, int ExenodeID2, int ExenodeID3)
        {
           int score = 0, prepare = 0, execute = 0;

            {  
               // Prepare type error
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
                   if (PrenodeID2 == 0 && PrenodeID3 == 0)
                   {
                       prepare = 10;
                   }
                   else
                   {
                       prepare = 0;
                   }
               }
           }

        //Execute Type logic
           if (ExenodeID1 == 51)
           {
               if (ExenodeID2 == 52)
               {
                   if (ExenodeID3 == 0)
                   {
                       execute = 7;
                   }
                   else
                   {
                       execute = 0;
                   }
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
                   if (ExenodeID3 == 0)
                   {
                       execute = 5;
                   }
                   else
                   {
                       execute = 0;
                   }
               }
               else if (ExenodeID2 == 102)
               {
                   if (ExenodeID3 == 0)
                   {
                       execute = 9;
                   }
                   else
                   {
                       execute = 0;
                   }
               }
           }
           else if (ExenodeID1 == 81)
           {
               if (ExenodeID2 == 0 && ExenodeID3 == 0)
               {
                   execute = 2;
               }
               else
               {
                   execute = 0;
               }
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