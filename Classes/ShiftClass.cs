using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chaisher.Classes
{
   public class ShiftClass
    {
    public void InsertShift (TimeSpan shiftstart, TimeSpan? shiftend,int  userID)
    {
            OptimizeChasierEntities db = new OptimizeChasierEntities();
            try
            {
                db.usp_InsertNewShift(shiftstart, shiftend, userID);
            }
            catch
            { }
            finally
            { db.Dispose(); }
    }
        public void update( TimeSpan shiftend, int userID , int id)
        {
            OptimizeChasierEntities db = new OptimizeChasierEntities();
            try
            {
                db.usp_UpdateNewShift( shiftend, userID , id );
            }
            catch
            { }
            finally
            { db.Dispose(); }
        }
        public int? Select(int userid)
        {
            OptimizeChasierEntities db = new OptimizeChasierEntities();
            try{ return db.usp_SelectEmployeeShift(userid).First(); }
            catch{ return null; }
            finally{ db.Dispose(); }
        }

        public List<usp_SelectActiveShift_Result> SelectActiveShift()
        {
            OptimizeChasierEntities db = new OptimizeChasierEntities();
            try { return db.usp_SelectActiveShift().ToList(); }
            catch { return null; }
            finally { db.Dispose(); }
        }
        public List<usp_SelectRequestedORderByShiftID_Result> SelectORdersByShift(int shiftid)
        {
            OptimizeChasierEntities db = new OptimizeChasierEntities();
            try { return db.usp_SelectRequestedORderByShiftID(shiftid).ToList(); }
            catch { return null; }
            finally { db.Dispose(); }
        }
        public decimal? SelectAllORdersByShift(int shiftid)
        {
            OptimizeChasierEntities db = new OptimizeChasierEntities();
            try { return db.usp_SumSelectOrderByShift(shiftid).First(); }
            catch { return 0; }
            finally { db.Dispose(); }
        }
        public decimal? SelectAllORdersByShiftDel(int shiftid)
        {
            OptimizeChasierEntities db = new OptimizeChasierEntities();
            try { return db.usp_SumSelectOrderByShiftDel(shiftid).First(); }
            catch { return 0; }
            finally { db.Dispose(); }
        }
        public decimal? SelectAllORdersByShiftTake(int shiftid)
        {
            OptimizeChasierEntities db = new OptimizeChasierEntities();
            try { return db.usp_SumSelectOrderByShiftTake(shiftid).First(); }
            catch { return 0; }
            finally { db.Dispose(); }
        }
    }
}
