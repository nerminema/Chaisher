using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chaisher.Classes
{
  public  class PODetailsClass
    {
        public List<usp_SelectAllPODetails_Result> SelectAll(int subID)
        {
            OptimizeChasierEntities db = new OptimizeChasierEntities();
            try { return db.usp_SelectAllPODetails(subID).ToList(); }
            catch { return null; }
            finally { db.Dispose(); }
        }
        
        public List<usp_SelectTotalqntyandPrice_Result> SelectAllByPOID(int id, DateTime sdate , DateTime edate)
        {
            OptimizeChasierEntities db = new OptimizeChasierEntities();
            try { return db.usp_SelectTotalqntyandPrice(id, sdate, edate).ToList(); }
            catch { return null; }
            finally { db.Dispose(); }
        }
        public List<usp_SelectAllPODetailsByPOID_Result> SelectAllByPOID(int id,int sid ,DateTime date)
        {
            OptimizeChasierEntities db = new OptimizeChasierEntities();
            try { return db.usp_SelectAllPODetailsByPOID(id ,sid , date).ToList(); }
            catch { return null; }
            finally { db.Dispose(); }
        }
        public List<usp_SelectAllPODetailsByID_Result> SelectAllByID(int id)
        {
            OptimizeChasierEntities db = new OptimizeChasierEntities();
            try { return db.usp_SelectAllPODetailsByID(id).ToList(); }
            catch { return null; }
            finally { db.Dispose(); }
        }
        public void Delete(int id)
        {
            OptimizeChasierEntities db = new OptimizeChasierEntities();
            try { db.usp_DeleteAllPODetailsByID(id); }
            catch { }
            finally { db.Dispose(); }
        }
        public void Insert(int Poid, int subpro, decimal qnty , decimal price , DateTime date)
        {
            OptimizeChasierEntities db = new OptimizeChasierEntities();
            try { db.usp_insertAllPODetailsByID(Poid, subpro, qnty ,price ,date); }
            catch { }
            finally { db.Dispose(); }
        }
        public void Update(int id, int Poid, int subpro, decimal qnty)
        {
            OptimizeChasierEntities db = new OptimizeChasierEntities();
            try { db.usp_UpdateAllPODetailsByID(id, Poid, subpro,qnty); }
            catch { }
            finally { db.Dispose(); }
        }
    }
}
