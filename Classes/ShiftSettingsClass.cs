using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chaisher.Classes
{
    class ShiftSettingsClass
    {
        public List<usp_SelectAllShiftSettings_Result> SelectAll()
        {
            OptimizeChasierEntities db = new OptimizeChasierEntities();
            try { return db.usp_SelectAllShiftSettings().ToList(); }
            catch { return null; }
            finally { db.Dispose(); }
        }
        public List<usp_SelectAllShiftSettingsByID_Result> SelectAll(int id)
        {
          OptimizeChasierEntities db = new OptimizeChasierEntities();
            try { return db.usp_SelectAllShiftSettingsByID(id).ToList(); }
            catch { return null; }
            finally { db.Dispose(); }
        }
        public void Delete(int id)
        {
          OptimizeChasierEntities db = new OptimizeChasierEntities();
            try { db.usp_DeleteAllShiftSettingsByID(id); }
            catch { }
            finally { db.Dispose(); }
        }
        public void Insert(string shiftname,TimeSpan start, TimeSpan end)
        {
          OptimizeChasierEntities db = new OptimizeChasierEntities();
            try { db.usp_InsertShiftSettings(shiftname, start, end); }
            catch { }
            finally { db.Dispose(); }
        }
        public void Update(string shiftname, TimeSpan start, TimeSpan end , int id)
        {
          OptimizeChasierEntities db = new OptimizeChasierEntities();
            try { db.usp_UpdateShiftSettings(shiftname, start, end, id); }
            catch { }
            finally { db.Dispose(); }
        }
    }
}
