using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chaisher.Classes
{
   public class EmployeeClass
    {
    public List<usp_SelectAllEmployee_Result> SelectAllEmployee()
    {
            OptimizeChasierEntities db = new OptimizeChasierEntities();
            try
            { return db.usp_SelectAllEmployee().ToList(); }
            catch
            { return null; }
            finally
            { db.Dispose(); }

    }
        public List<usp_SelectAllEmployeeByID_Result> SelectAllEmployee( int id)
        {
            OptimizeChasierEntities db = new OptimizeChasierEntities();
            try
            { return db.usp_SelectAllEmployeeByID(id).ToList(); }
            catch
            { return null; }
            finally
            { db.Dispose(); }

        }

        public void DeleteEmployee(int id)
        {
            OptimizeChasierEntities db = new OptimizeChasierEntities();
            try
            { db.usp_DeleteAllEmployeeByID(id); }
            catch
            {  }
            finally
            { db.Dispose(); }

        }
        public void UpdateEmployee(string employeeName ,bool isDelevery ,decimal salary ,bool isweekly ,decimal working , int id , bool isManager , bool isAttand)
        {
            OptimizeChasierEntities db = new OptimizeChasierEntities();
            try
            { db.usp_UpdateEmployee(employeeName , isDelevery , salary , isweekly , working , id , isManager , isAttand ); }
            catch
            { }
            finally
            { db.Dispose(); }

        }
        public void InsertEmployee(string employeeName, bool isDelevery, decimal salary, bool isweekly, decimal working, bool isManager, bool isAttand)
        {
            OptimizeChasierEntities db = new OptimizeChasierEntities();
            try
            { db.usp_InsertEmployee(employeeName, isDelevery, salary, isweekly, working, isManager, isAttand); }
            catch(Exception ex)
            { 
            }
            finally
            { db.Dispose(); }

        }
    }
}

