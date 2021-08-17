using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chaisher.Classes
{
  public  class LoanClass
    {
    public void InsertEmployeeLoan(int empID,bool isLoan,decimal amount,DateTime date)
    {
            OptimizeChasierEntities db = new OptimizeChasierEntities();
            try{ db.usp_InsertEmployeeLoan(empID, isLoan, amount, date); }
            catch{ }
            finally{ db.Dispose(); }
    }

        public decimal? SelectEmployeeLoan(int empID,DateTime sdate , DateTime edate , bool isloan)
        {
            OptimizeChasierEntities db = new OptimizeChasierEntities();
            try {return db.usp_SelectLaon(empID, sdate , edate , isloan).First(); }
            catch { return null; }
            finally { db.Dispose(); }
        }
    }
}
