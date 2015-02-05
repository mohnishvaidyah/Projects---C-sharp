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
            return EntityList;
        }

        public List<string[]> GetEntity(string EntityName, Int16 MaxRowCnt)
        {
            List<string[]> EntityList = new List<string[]>();
            return EntityList;
        }

        #endregion

    }
}