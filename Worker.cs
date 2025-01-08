using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sql_Interactor
{
    public class Worker
    {
        public int W_Id;
        public string F_Name;
        public string L_Name;
        public DateTime Birth_Date;
        public Functions Function;

        public Worker(int W_Id, string F_Name, string L_Name, DateTime Birth_Date, Functions Function) 
        {
            this.W_Id = W_Id;
            this.F_Name = F_Name;
            this.L_Name = L_Name;
            this.Birth_Date = Birth_Date;
            this.Function = Function;
        }
    }
}
