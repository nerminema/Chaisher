using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chaisher.Classes
{
  public  class SuppliersProductsProductsClass
    {
        public List<usp_SelectAllSuppliersProductsBySub_Result> SelectAllBySub(int id)
        {
            OptimizeChasierEntities db = new OptimizeChasierEntities();
            try { return db.usp_SelectAllSuppliersProductsBySub(id).ToList(); }
            catch { return null; }
            finally { db.Dispose(); }
        }
        public List<usp_SelectAllSuppliersProductsByID_Result> SelectAll(int id)
        {
            OptimizeChasierEntities db = new OptimizeChasierEntities();
            try { return db.usp_SelectAllSuppliersProductsByID(id).ToList(); }
            catch { return null; }
            finally { db.Dispose(); }
        }
        public void Delete(int id)
        {
            OptimizeChasierEntities db = new OptimizeChasierEntities();
            try { db.usp_DeleteAllSuppliersProductsByID(id); }
            catch { }
            finally { db.Dispose(); }
        }
        public void Insert(int supplierID ,int  rowMaterialID ,decimal price)
        {
            OptimizeChasierEntities db = new OptimizeChasierEntities();
            try { db.usp_insertAllSuppliersProductsByID(supplierID , rowMaterialID , price); }
            catch { }
            finally { db.Dispose(); }
        }
        public void Update(int id, int supplierID, int rowMaterialID, decimal price)
        {
            OptimizeChasierEntities db = new OptimizeChasierEntities();
            try { db.usp_UpdateAllSuppliersProductsByID(id, supplierID, rowMaterialID, price); }
            catch { }
            finally { db.Dispose(); }
        }
    }
}
