using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chaisher.Classes
{
    class DistrictClass
    {
        public void InsertDistrict(string name)
        {
            OptimizeChasierEntities db = new OptimizeChasierEntities();
            try { db.usp_InsertDidtrict(name); }
            catch { }
            finally { db.Dispose(); }
        }
        public void UpdateDistrict(string name, int id)
        {
            OptimizeChasierEntities db = new OptimizeChasierEntities();
            try { db.usp_UpdateDidtrict(name, id); }
            catch { }
            finally { db.Dispose(); }
        }
        public void DeleteDistrict(int id)
        {
            OptimizeChasierEntities db = new OptimizeChasierEntities();
            try { db.usp_DeleteAllDistrictByID(id); }
            catch { }
            finally { db.Dispose(); }
        }
        public List<usp_SelectAllDistrict_Result> SelectAll()
        {

            OptimizeChasierEntities db = new OptimizeChasierEntities();
            try { return db.usp_SelectAllDistrict().ToList(); }
            catch { return null; }
            finally { db.Dispose(); }
        }
        public List<usp_SelectAllDistrictByID_Result> SelectAllDistrictByID(int id)
        {

            OptimizeChasierEntities db = new OptimizeChasierEntities();
            try { return db.usp_SelectAllDistrictByID(id).ToList(); }
            catch { return null; }
            finally { db.Dispose(); }
        }

    }
}
