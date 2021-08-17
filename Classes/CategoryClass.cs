using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chaisher.Classes
{
   public class CategoryClass
    {
        public void InsertNewCategory(string name , string color , string fore)
        {
            OptimizeChasierEntities db = new OptimizeChasierEntities();
            try { db.usp_InsertNewCatgory(name , color , fore); }
            catch { }
            finally { db.Dispose(); }
        }
        public void UpdateNewCategory(string name, string color, int id, int fore)
        {
            OptimizeChasierEntities db = new OptimizeChasierEntities();
            try { db.usp_UpdateNewCatgory(name , color, id , fore); }
            catch { }
            finally { db.Dispose(); }
        }
        public void DeleteCategory(int id )
        {
            OptimizeChasierEntities db = new OptimizeChasierEntities();
            try { db.usp_DeleteAllCategoryByID(id); }
            catch { }
            finally { db.Dispose(); }
        }
        public List<usp_SelectAllCategory_Result> SelectAllCategory()
        {
             
            OptimizeChasierEntities db = new OptimizeChasierEntities();
            try {return db.usp_SelectAllCategory().ToList(); }
            catch (Exception ex)
            { return null; }
            finally { db.Dispose(); }
        }
        public List<usp_SelectAllCategoryByID_Result> SelectAllCategoryByID(int id )
        {

            OptimizeChasierEntities db = new OptimizeChasierEntities();
            try { return db.usp_SelectAllCategoryByID(id).ToList(); }
            catch { return null; }
            finally { db.Dispose(); }
        }

    }
}
