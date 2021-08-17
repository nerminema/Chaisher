using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chaisher.Classes
{
   public class ProductClass
    {
        public List<usp_SelectProduct_Result> SelectProduct ()
        {
            OptimizeChasierEntities db = new OptimizeChasierEntities();
            try { return db.usp_SelectProduct().ToList(); }
            catch(Exception ex)
            { return null; }
            finally { db.Dispose(); }
        }
        public List<usp_selectProductByCode_Result> SelectProduct(int code)
        {
            OptimizeChasierEntities db = new OptimizeChasierEntities();
            try { return db.usp_selectProductByCode(code).ToList(); }
            catch (Exception ex)
            { return null; }
            finally { db.Dispose(); }
        }
        public List<usp_SelectProductByCatID_Result> SelectProductByCatID(int id )
        {
            OptimizeChasierEntities db = new OptimizeChasierEntities();
            try { return db.usp_SelectProductByCatID(id).ToList(); }
            catch { return null; }
            finally { db.Dispose(); }
        }
        public List<usp_SelectProductByID_Result> SelectProductByID(int id)
        {
            OptimizeChasierEntities db = new OptimizeChasierEntities();
            try { return db.usp_SelectProductByID(id).ToList(); }
            catch(Exception ex) 
            { return null; }
            finally { db.Dispose(); }
        }
        public List<usp_searchProduct_Result> SearchProduct(string name )
        {
            OptimizeChasierEntities db = new OptimizeChasierEntities();
            try { return db.usp_searchProduct(name).ToList(); }
            catch (Exception ex)
            { return null; }
            finally { db.Dispose(); }
        }
        public void DeleteProductByID (int id)
        {
            OptimizeChasierEntities db = new OptimizeChasierEntities();
            try{ db.usp_DeletePRoduct(id);  }
            catch{  }
            finally{ db.Dispose(); }
        }
        public void InsertProductByID(string productName, decimal price, bool isWeightPrice, int catID, bool isNoteAllowed ,int no ,int barcode)
        {
            OptimizeChasierEntities db = new OptimizeChasierEntities();
            try { db.usp_InsertNewPRoduct(productName, price, isWeightPrice, catID,  isNoteAllowed ,no , barcode); }
            catch { }
            finally { db.Dispose(); }
        }
        public void UpdateProductByID(string productName ,decimal price ,bool isWeightPrice ,int catID ,int id ,bool isNoteAllowed,int no ,int barcode)
        {
            OptimizeChasierEntities db = new OptimizeChasierEntities();
            try { db.usp_UpdateNewPRoduct( productName , price , isWeightPrice , catID , id ,isNoteAllowed,no , barcode); }
            catch { }
            finally { db.Dispose(); }
        }
    }
}
