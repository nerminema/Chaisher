using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chaisher.Classes
{
    public class ReqestedORderDetails
    {
    public void DeleteOrderDetails(int id)
    {
            OptimizeChasierEntities db = new OptimizeChasierEntities();

    try{ db.usp_DeleteRequestedOrderDetails(id); }
    catch{ }
    finally{ }
    }
        public List<usp_SelectRequestedORderDetailsById_Result> SelectRequestedOrderDetailsById(int id)
        {
            OptimizeChasierEntities db = new OptimizeChasierEntities();
            try
            {
                return db.usp_SelectRequestedORderDetailsById(id).ToList();
            }
            catch { return null; }
            finally { db.Dispose(); }
        }
        public List<usp_SelectRequestedORderDetailsByOrderId_Result> SelectRequestedORderDetailsByOrderId(int id)
        {
            OptimizeChasierEntities db = new OptimizeChasierEntities();
            try
            {
                return db.usp_SelectRequestedORderDetailsByOrderId(id).ToList();
            }
            catch { return null; }
            finally { db.Dispose(); }
        }
        public List<usp_SelectRequestedORderByORderID_Result> SelectRequestedORderByOrderId(int id)
        {
            OptimizeChasierEntities db = new OptimizeChasierEntities();
            try
            {
                return db.usp_SelectRequestedORderByORderID(id).ToList();
            }
            catch(Exception ex) 
            { return null; }
            finally { db.Dispose(); }
        }
        public void UpdateRequestedORderDetails(int requestedID, int prodid, decimal qnty, decimal price, int id , string notes)
        {
            OptimizeChasierEntities db = new OptimizeChasierEntities();
            try
            {
                db.usp_UpdateRequestedORderDetails(requestedID, prodid, qnty, price, id , notes);
            }
            catch { }
            finally { db.Dispose(); }
        }
        public void InsertRequestedORderDetails(int requestedID, int prodid, decimal qnty, decimal price , string notes)
        {
            OptimizeChasierEntities db = new OptimizeChasierEntities();
            try
            {
                db.usp_InsertRequestedORderDetails(requestedID, prodid, qnty, price , notes);
            }
            catch(Exception ex) { }
            finally { db.Dispose(); }
        }
        public decimal? SelectTotalOrder(int orderid)
        {
            OptimizeChasierEntities db = new OptimizeChasierEntities();
            try { return db.usp_SelectSumRequestedORderDetailsByOrderId(orderid).First(); }
            catch
            { return null; }
            finally
            { db.Dispose(); }
        }
    }
}