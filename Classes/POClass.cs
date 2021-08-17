using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chaisher.Classes
{
   public class POClass
    {
        public List<usp_SelectPOORder_Result> SelectBySubAndDate(int  suoID , DateTime date )
        {
            OptimizeChasierEntities db = new OptimizeChasierEntities();
            try { return db.usp_SelectPOORder(suoID , date).ToList(); }
            catch { return null; }
            finally { db.Dispose(); }
        }
        public List<usp_SelectAllPO_Result> SelectAll(bool isPaid)
        {
            OptimizeChasierEntities db = new OptimizeChasierEntities();
            try { return db.usp_SelectAllPO(isPaid).ToList(); }
            catch { return null; }
            finally { db.Dispose(); }
        }
        public List<usp_SelectAllPOBySubID_Result> SelectAllBySub(int id)
        {
            OptimizeChasierEntities db = new OptimizeChasierEntities();
            try { return db.usp_SelectAllPOBySubID(id).ToList(); }
            catch { return null; }
            finally { db.Dispose(); }
        }
        public List<usp_SelectAllPOByDate_Result> SelectAllBySub( DateTime from, DateTime to)
        {
            OptimizeChasierEntities db = new OptimizeChasierEntities();
            try { return db.usp_SelectAllPOByDate( from, to).ToList(); }
            catch { return null; }
            finally { db.Dispose(); }
        }
      
        public List<usp_SelectAllPOBySubIDAndDate_Result> SelectAllBySub(int id , DateTime from , DateTime to)
        {
            OptimizeChasierEntities db = new OptimizeChasierEntities();
            try { return db.usp_SelectAllPOBySubIDAndDate(id ,from ,to).ToList(); }
            catch { return null; }
            finally { db.Dispose(); }
        }
        public decimal? SelectTotalAllBySub(int id, DateTime from, DateTime to)
        {
            OptimizeChasierEntities db = new OptimizeChasierEntities();
            try { return db.usp_SelectSumPOBySubIDAndDate(id, from, to).First(); }
            catch { return null; }
            finally { db.Dispose(); }
        }
        public decimal? SelectTotalAll( DateTime from, DateTime to)
        {
            OptimizeChasierEntities db = new OptimizeChasierEntities();
            try { return db.usp_SelectSumPOByDate( from, to).First(); }
            catch { return null; }
            finally { db.Dispose(); }
        }
        //public decimal? SelectSumTotalAll(DateTime from, DateTime to)
        //{
        //    OptimizeChasierEntities db = new OptimizeChasierEntities();
        //    try { return db.usp_SelectSumpaidPOBySubIDAndDate(from, to).First(); }
        //    catch { return null; }
        //    finally { db.Dispose(); }
        //}
        public decimal? SelectPaidTotalAll(DateTime from, DateTime to)
        {
            OptimizeChasierEntities db = new OptimizeChasierEntities();
            try { return db.usp_SelectpaidSumPOByDate(from, to).First(); }
            catch { return null; }
            finally { db.Dispose(); }
        }
        public decimal? SelectUnPaidTotalAll(DateTime from, DateTime to)
        {
            OptimizeChasierEntities db = new OptimizeChasierEntities();
            try { return db.usp_SelectUnpaidSumPOByDate(from, to).First(); }
            catch { return null; }
            finally { db.Dispose(); }
        }
        public decimal? SelectSumPO()
        {
            OptimizeChasierEntities db = new OptimizeChasierEntities();
            try { return db.usp_SelectSumPO().First(); }
            catch { return null; }
            finally { db.Dispose(); }
        }
        public List<usp_SelectAllPOByID_Result> SelectAll(int id)
        {
            OptimizeChasierEntities db = new OptimizeChasierEntities();
            try { return db.usp_SelectAllPOByID(id).ToList(); }
            catch { return null; }
            finally { db.Dispose(); }
        }
        
        //public void UpdateTotal(int id , decimal total)
        //{
        //    OptimizeChasierEntities db = new OptimizeChasierEntities();
        //    try { db.usp_UpdatePOTotal(id , total); }
        //    catch { }
        //    finally { db.Dispose(); }
        //}
        //public void SubTotal(int id, decimal total)
        //{
        //    OptimizeChasierEntities db = new OptimizeChasierEntities();
        //    try { db.usp_subPOTotal(id, total); }
        //    catch { }
        //    finally { db.Dispose(); }
        //}
        //
        public void Delete(int id)
        {
            OptimizeChasierEntities db = new OptimizeChasierEntities();
            try { db.usp_DeleteAllPOByID(id); }
            catch { }
            finally { db.Dispose(); }
        }
        public int? Insert(int supplierID, DateTime date, decimal total, bool ispaid)
        {
            OptimizeChasierEntities db = new OptimizeChasierEntities();
            try {return db.usp_insertAllPOByID(supplierID, date, total, ispaid).First(); }
            catch { return null; }
            finally { db.Dispose(); }
        }
        public void Update(int id, int supplierID,DateTime date ,decimal total ,bool ispaid)
        {
            OptimizeChasierEntities db = new OptimizeChasierEntities();
            try { db.usp_UpdateAllPOByID(id, supplierID, date ,total , ispaid); }
            catch { }
            finally { db.Dispose(); }
        }
        }
    }

