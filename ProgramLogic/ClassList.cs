﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramLogic
{
  public  class ClassList
    {
        public List<int> List { get; set; }

        public ClassList(List<int> namelist)
        {
            this.List = namelist;
        }
        public bool CheckArifmeticts()
        {
            List.Sort();

            for (int i = 2; i < List.Count; i++)
            {
                if (List[i] - List[i - 1] != List[i - 1] - List[i - 2])
                    return false;
            }

            return true;
        }
                
    }

}
