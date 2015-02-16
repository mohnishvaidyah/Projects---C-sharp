using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mvISC590AsgWebForms
{
    public class Entity
    {
        public Entity()
        {
            pRowCnt = 0;
            pColCnt = 0;
        }

        #region "Properties"

        private Int16 pRowCnt;
        public Int16 RowCnt
        {
            get
            {
                return pRowCnt;
            }

            set
            {
                pRowCnt = value;
            }
        }

        private Int16 pColCnt;
        public Int16 ColCnt
        {
            get
            {
                return pColCnt;
            }

            set
            {
                pColCnt = value;
            }
        }

        #endregion

        #region "Entity Methods"

        public List<string[]> GetEntity(string EntityName)
        {
            List<string[]> EntityList = new List<string[]>();
            if (EntityName == "ResultSet0")
            {
                EntityList.Add(new string[] { "StudentID", "LastName", "FirstName" });
                EntityList.Add(new string[] { "100", "Godi", "Anusha" });
                EntityList.Add(new string[] { "101", "Gajjala", "Sai" });
                EntityList.Add(new string[] { "102", "Ganta", "Shravani" });
                EntityList.Add(new string[] { "103", "Fore", "John" });
            }
            else if (EntityName == "ResultSet1")
            {
                EntityList.Add(new string[] { "StudentID", "LastName", "FirstName", "Status" });
                EntityList.Add(new string[] { "100", "Godi", "Anusha", "Grad" });
                EntityList.Add(new string[] { "101", "Gajjala", "Sai", "Grad" });
                EntityList.Add(new string[] { "102", "Ganta", "Shravani", "" });
                EntityList.Add(new string[] { "103", "Fore", "John", "Grad" });
            }
            else if (EntityName == "ResultSet2")
            {
                EntityList.Add(new string[] { "StudentID", "LastName", "FirstName" });
                EntityList.Add(new string[] { "100", "Godi", "Anusha" });
                EntityList.Add(new string[] { "101", "Gajjala", "Sai" });
                EntityList.Add(new string[] { "102", "Ganta", "Shravani" });
            }
            else if (EntityName == "ResultSet3")
            {
                EntityList.Add(new string[] { "StudentID", "LastName", "FirstName" });
                EntityList.Add(new string[] { "100", "Godi", "Anusha" });
                EntityList.Add(new string[] { "101", "Gajjala", "Sai" });
                EntityList.Add(new string[] { "102", "Ganta", "Shravani" });
                EntityList.Add(new string[] { "106", "Loman", "Jeffery" });
            }
            else if (EntityName == "ResultSet4")
            {
                EntityList.Add(new string[] { "StudentID", "LastName", "FirstName" });
                EntityList.Add(new string[] { "100", "Godi", "Anusha" });
                EntityList.Add(new string[] { "101", "Gajjala", "Sai" });
                EntityList.Add(new string[] { "102", "Ganta", "Shravani" });
                EntityList.Add(new string[] { "103", "Fore", "John" });
            }
            else if (EntityName == "ResultSet5")
            {
                EntityList.Add(new string[] { "StudentID", "LastName", "Status" });
                EntityList.Add(new string[] { "100", "Godi", "Grad" });
                EntityList.Add(new string[] { "101", "Gajjala", "Grad" });
                EntityList.Add(new string[] { "102", "Ganta", "Grad" });
                EntityList.Add(new string[] { "103", "Fore", "" });
            }
            else if (EntityName == "ResultSet6")
            {
                EntityList.Add(new string[] { "StudentID", "LastName", "FirstName" });
                EntityList.Add(new string[] { "100", "Godi", "Anusha" });
                EntityList.Add(new string[] { "101", "Gajjala", "Sai" });
                EntityList.Add(new string[] { "110", "Prasad", "Shiva" });
                EntityList.Add(new string[] { "125", "Madineni", "Akhila" });
                EntityList.Add(new string[] { "133", "Motley", "Tracy" });
                EntityList.Add(new string[] { "258", "Bellamkonda", "Nandini" });
                EntityList.Add(new string[] { "114", "Deckard", "Greg" });
                EntityList.Add(new string[] { "885", "", "Hareesh" });
                EntityList.Add(new string[] { "147", "Duglaya", "Abhinay" });
                EntityList.Add(new string[] { "321", "Gudivada", "Hari" });
                EntityList.Add(new string[] { "124", "Jammula", "Aditya" });
                EntityList.Add(new string[] { "102", "Ganta", "Shravani" });
                EntityList.Add(new string[] { "103", "Fore", "John" });
            }
            else
            {
                EntityList.Add(new string[] { "Message" });
                EntityList.Add(new string[] { "Invalid entity name" });
            }
            pRowCnt = Convert.ToSByte(EntityList.Count);
            pColCnt = Convert.ToSByte(EntityList[0].Length);
            return EntityList;
        }

        public List<string[]> GetEntity(string EntityName, int MaxRowCnt)
        {
            List<string[]> EntityList = new List<string[]>();

            //if (EntityList.Count > MaxRowCnt)


            if (EntityName == "ResultSet0")
            {
                EntityList.Add(new string[] { "StudentID", "LastName", "FirstName" });
                EntityList.Add(new string[] { "100", "Godi", "Anusha" });
                EntityList.Add(new string[] { "101", "Gajjala", "Sai" });
                EntityList.Add(new string[] { "102", "Ganta", "Shravani" });
                EntityList.Add(new string[] { "103", "Fore", "John" });
            }
            else if (EntityName == "ResultSet1")
            {
                EntityList.Add(new string[] { "StudentID", "LastName", "FirstName", "Status" });
                EntityList.Add(new string[] { "100", "Godi", "Anusha", "Grad" });
                EntityList.Add(new string[] { "101", "Gajjala", "Sai", "Grad" });
                EntityList.Add(new string[] { "102", "Ganta", "Shravani", "" });
                EntityList.Add(new string[] { "103", "Fore", "John", "Grad" });
            }
            else if (EntityName == "ResultSet2")
            {
                EntityList.Add(new string[] { "StudentID", "LastName", "FirstName" });
                EntityList.Add(new string[] { "100", "Godi", "Anusha" });
                EntityList.Add(new string[] { "101", "Gajjala", "Sai" });
                EntityList.Add(new string[] { "102", "Ganta", "Shravani" });
            }
            else if (EntityName == "ResultSet3")
            {
                EntityList.Add(new string[] { "StudentID", "LastName", "FirstName" });
                EntityList.Add(new string[] { "100", "Godi", "Anusha" });
                EntityList.Add(new string[] { "101", "Gajjala", "Sai" });
                EntityList.Add(new string[] { "102", "Ganta", "Shravani" });
                EntityList.Add(new string[] { "106", "Loman", "Jeffery" });
            }
            else if (EntityName == "ResultSet4")
            {
                EntityList.Add(new string[] { "StudentID", "LastName", "FirstName" });
                EntityList.Add(new string[] { "100", "Godi", "Anusha" });
                EntityList.Add(new string[] { "101", "Gajjala", "Sai" });
                EntityList.Add(new string[] { "102", "Ganta", "Shravani" });
                EntityList.Add(new string[] { "103", "Fore", "John" });
            }
            else if (EntityName == "ResultSet5")
            {
                EntityList.Add(new string[] { "StudentID", "LastName", "Status" });
                EntityList.Add(new string[] { "100", "Godi", "Grad" });
                EntityList.Add(new string[] { "101", "Gajjala", "Grad" });
                EntityList.Add(new string[] { "102", "Ganta", "Grad" });
                EntityList.Add(new string[] { "103", "Fore", "" });
            }
            else if (EntityName == "ResultSet6")
            {
                EntityList.Add(new string[] { "StudentID", "LastName", "FirstName" });
                EntityList.Add(new string[] { "100", "Godi", "Anusha" });
                EntityList.Add(new string[] { "101", "Gajjala", "Sai" });
                EntityList.Add(new string[] { "110", "Prasad", "Shiva" });
                EntityList.Add(new string[] { "125", "Madineni", "Akhila" });
                EntityList.Add(new string[] { "133", "Motley", "Tracy" });
                EntityList.Add(new string[] { "258", "Bellamkonda", "Nandini" });
                EntityList.Add(new string[] { "114", "Deckard", "Greg" });
                EntityList.Add(new string[] { "885", "", "Hareesh" });
                EntityList.Add(new string[] { "147", "Duglaya", "Abhinay" });
                EntityList.Add(new string[] { "321", "Gudivada", "Hari" });
                EntityList.Add(new string[] { "124", "Jammula", "Aditya" });
                EntityList.Add(new string[] { "102", "Ganta", "Shravani" });
                EntityList.Add(new string[] { "103", "Fore", "John" });
            }
            else
            {
                EntityList.Add(new string[] { "Message" });
                EntityList.Add(new string[] { "Invalid entity name" });
            }

            pRowCnt = Convert.ToSByte(EntityList.Count);
            pColCnt = Convert.ToSByte(EntityList[0].Length);
            if (pRowCnt > MaxRowCnt)
            {
                return EntityList;
            }
            else
            {
                EntityList.Add(new string[] { "Message" });
                EntityList.Add(new string[] { "Exceed row count" });
                return EntityList;
            }
        }
        #endregion

    }
}