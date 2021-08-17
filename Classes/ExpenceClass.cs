using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chaisher.Classes
{
   public class ExpenceClass
    {
    public void InsertExpence (decimal expenceAmount,string  expenceDue,int ? employeeID,DateTime exDate,int? orderid)
    {
            OptimizeChasierEntities db = new OptimizeChasierEntities();
            try{ db.usp_InsertNewExpence(expenceAmount, expenceDue, employeeID, exDate , orderid); }
            catch{ }
            finally{ db.Dispose(); }
    }
    public List<usp_SelectExpenceByOrderID_Result> SelectExpenceByOrderID (int orderID)
    {
            OptimizeChasierEntities db = new OptimizeChasierEntities();
            try { return db.usp_SelectExpenceByOrderID(orderID).ToList(); }
            catch { return null; }
            finally { db.Dispose(); }
        }
        public List<usp_SelectExpenceByID_Result> SelectExpenceByID(int ID)
        {
            OptimizeChasierEntities db = new OptimizeChasierEntities();
            try { return db.usp_SelectExpenceByID(ID).ToList(); }
            catch { return null; }
            finally { db.Dispose(); }
        }
        public List<usp_SelectAllExpence_Result> SelectExpence()
        {
            OptimizeChasierEntities db = new OptimizeChasierEntities();
            try { return db.usp_SelectAllExpence().ToList(); }
            catch { return null; }
            finally { db.Dispose(); }
        }
        public List<usp_selectExpenceByDate_Result> SelectExpence(DateTime sdate , DateTime edate)
        {
            OptimizeChasierEntities db = new OptimizeChasierEntities();
            try { return db.usp_selectExpenceByDate(sdate , edate).ToList(); }
            catch { return null; }
            finally { db.Dispose(); }
        }
        public List<usp_selectAllDElExpenceByDate_Result> SelectDElExpence(DateTime sdate, DateTime edate)
        {
            OptimizeChasierEntities db = new OptimizeChasierEntities();
            try { return db.usp_selectAllDElExpenceByDate(sdate, edate).ToList(); }
            catch { return null; }
            finally { db.Dispose(); }
        }
        public decimal? Totalex( DateTime start, DateTime end)
        {
            OptimizeChasierEntities db = new OptimizeChasierEntities();
            try { return db.usp_selectTotalExpenceByDate(start, end).First(); }
            catch { return null; }
            finally { db.Dispose(); }
        }
        public decimal? totaldelex(DateTime start, DateTime end)
        {
            OptimizeChasierEntities db = new OptimizeChasierEntities();
            try { return db.usp_selectTotalDElExpenceByDate(start, end).First(); }
            catch { return null; }
            finally { db.Dispose(); }
        }
        
        
    }
}
