using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chaisher.Classes
{
  public  class RowMaterialClass
    {
        public List<usp_SelectAllRowMatrial_Result> SelectAll()
        {
            OptimizeChasierEntities db = new OptimizeChasierEntities();
            try { return db.usp_SelectAllRowMatrial().ToList(); }
            catch { return null; }
            finally { db.Dispose(); }
        }
        public List<usp_SelectAllRowMatrialByID_Result> SelectAll(int id)
        {
            OptimizeChasierEntities db = new OptimizeChasierEntities();
            try { return db.usp_SelectAllRowMatrialByID(id).ToList(); }
            catch { return null; }
            finally { db.Dispose(); }
        }
        public void Delete(int id)
        {
            OptimizeChasierEntities db = new OptimizeChasierEntities();
            try { db.usp_DeleteAllRowMatrialByID(id); }
            catch { }
            finally { db.Dispose(); }
        }
        public void Insert(string productName)
        {
            OptimizeChasierEntities db = new OptimizeChasierEntities();
            try { db.usp_insertAllRowMatrialByID(productName); }
            catch { }
            finally { db.Dispose(); }
        }
        public void Update(int id, string productName)
        {
            OptimizeChasierEntities db = new OptimizeChasierEntities();
            try { db.usp_UpdateAllRowMatrialByID(id, productName); }
            catch { }
            finally { db.Dispose(); }
        }
    }
}
