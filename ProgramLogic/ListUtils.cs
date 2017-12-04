using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramLogic
{
  public  class ListUtils
    {
        public List<int> List { get; set; }

        public ListUtils(List<int> namelist)
        {
            this.List = namelist;
        }
        public bool CheckArifmeticts()
        {
            List<int> resultList = new List<int>(List);

            resultList.Sort();

            for (int i = 2; i < List.Count; i++)
            {
                if (resultList[i] - resultList[i - 1] != resultList[i - 1] - resultList[i - 2])
                    return false;
            }

            return true;
        }
                
    }

}
