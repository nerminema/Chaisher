using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chaisher.Classes
{
  public  class SuppliersClass
    {
        public List<usp_selectSupplierProduct_Result> SelectAllSid( int sid)
        {
            OptimizeChasierEntities db = new OptimizeChasierEntities();
            try { return db.usp_selectSupplierProduct(sid).ToList(); }
            catch { return null; }
            finally { db.Dispose(); }
        }
        public List<usp_SelectAllSuppliers_Result> SelectAll()
        {
            OptimizeChasierEntities db = new OptimizeChasierEntities();
            try { return db.usp_SelectAllSuppliers().ToList(); }
            catch { return null; }
            finally { db.Dispose(); }
        }
        public List<usp_SelectAllSuppliersByID_Result> SelectAll(int id)
        {
           OptimizeChasierEntities db = new OptimizeChasierEntities();
            try {return db.usp_SelectAllSuppliersByID(id).ToList(); }
            catch { return null; }
            finally { db.Dispose(); }
        }
        public void Delete(int id)
        {
           OptimizeChasierEntities db = new OptimizeChasierEntities();
            try { db.usp_DeleteAllSuppliersByID(id); }
            catch { }
            finally { db.Dispose(); }
        }
        public void Insert(string supplierName, string supplierPhone, string supplierAddress)
        {
           OptimizeChasierEntities db = new OptimizeChasierEntities();
            try { db.usp_insertAllSuppliersByID( supplierName, supplierPhone, supplierAddress); }
            catch { }
            finally { db.Dispose(); }
        }
        public void Update(int id, string supplierName ,string supplierPhone ,string supplierAddress)
        {
           OptimizeChasierEntities db = new OptimizeChasierEntities();
            try { db.usp_UpdateAllSuppliersByID(id , supplierName , supplierPhone , supplierAddress); }
            catch { }
            finally { db.Dispose(); }
        }
    }
}
