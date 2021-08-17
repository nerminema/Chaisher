using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chaisher.Classes
{
 public  class EmployeeTimeAttanceClass
    {
        public List<usp_SelectEmployeeAttedance_Result> SelectAll(int eid , DateTime strat , DateTime end)
        {
            OptimizeChasierEntities db = new OptimizeChasierEntities();
            try { return db.usp_SelectEmployeeAttedance(eid , strat , end).ToList(); }
            catch { return null; }
            finally { db.Dispose(); }
        }
        public List<usp_SelectAllEmployeeAttedance_Result> SelectAll( DateTime strat, DateTime end)
        {
            OptimizeChasierEntities db = new OptimizeChasierEntities();
            try { return db.usp_SelectAllEmployeeAttedance( strat, end).ToList(); }
            catch { return null; }
            finally { db.Dispose(); }
        }
        public List<usp_SelectAllEmployeeSalary_Result> SelectAllSalary(DateTime strat, DateTime end)
        {
            OptimizeChasierEntities db = new OptimizeChasierEntities();
            try { return db.usp_SelectAllEmployeeSalary(strat, end).ToList(); }
            catch { return null; }
            finally { db.Dispose(); }
        }
        public decimal? TotalWorkingHours (int empID , DateTime start , DateTime end)
        {
            OptimizeChasierEntities db = new OptimizeChasierEntities();
            try{ return db.usp_TotalWorkingHours(start, end, empID).First(); }
            catch{ return null; }
            finally{ db.Dispose(); }
        }
        public List<usp_SelectEmployeeAttedanceByID_Result> SelectAll(int id)
        {
           OptimizeChasierEntities db = new OptimizeChasierEntities();
            try { return db.usp_SelectEmployeeAttedanceByID(id).ToList(); }
            catch { return null; }
            finally { db.Dispose(); }
        }
        public void Delete(int id)
        {
           OptimizeChasierEntities db = new OptimizeChasierEntities();
            try { db.usp_DeleteEmployeeAttedance(id); }
            catch { }
            finally { db.Dispose(); }
        }
        public void Insert(int employeeID, TimeSpan intime, TimeSpan? outTime, decimal? totalWorkingHours, DateTime date, int id)
        {
           OptimizeChasierEntities db = new OptimizeChasierEntities();
            try { db.usp_InsertEmployeeAttedance(employeeID, intime, outTime, totalWorkingHours, date, id); }
            catch { }
            finally { db.Dispose(); }
        }
        public void Update(int employeeID ,TimeSpan intime , TimeSpan outTime ,decimal totalWorkingHours ,DateTime date , int id)
        {
           OptimizeChasierEntities db = new OptimizeChasierEntities();
            try { db.usp_UpdateEmployeeAttedance(employeeID , intime , outTime , totalWorkingHours , date , id); }
            catch { }
            finally { db.Dispose(); }
        }
    }
}
