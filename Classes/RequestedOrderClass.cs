using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chaisher.Classes
{
    public class RequestedOrderClass
    {
        public int? InsertRequestedOrder(DateTime orderdate, int? clientID, TimeSpan time , string note , int?  userID , int? shiftID)
        {
            OptimizeChasierEntities db = new OptimizeChasierEntities();
            try
            {return db.usp_InsertRequestedOrder(orderdate, clientID, time , note , userID , shiftID).First(); }
            catch
            { return null; }
            finally
            {
                db.Dispose();
            }
        }
        public void UpdateOrder (int id , decimal amount , bool done,string note,decimal rEM ,int? clientId)
        {
            OptimizeChasierEntities db = new OptimizeChasierEntities();
            try
            {
                db.usp_updateTotal(done, amount, id , note , rEM , clientId);
            }
            catch
            { }
            finally
            {
                db.Dispose();
            }
            }
        public List< int?> SelectOrderWaitting()
        {
            OptimizeChasierEntities db = new OptimizeChasierEntities();
            try { return db.usp_SelectOrdersUnderPre().ToList(); }
            catch
            { return null; }
            finally
            { db.Dispose(); }
        }
        public decimal? SelectOrderDel(DateTime from, DateTime to)
        {
            OptimizeChasierEntities db = new OptimizeChasierEntities();
            try { return db.usp_SumSelectOrderByDateDel(from , to ).First(); }
            catch
            { return null; }
            finally
            { db.Dispose(); }
        }
        public decimal? SelectOrdertake(DateTime from, DateTime to)
        {
            OptimizeChasierEntities db = new OptimizeChasierEntities();
            try { return db.usp_SumSelectOrderByDateTake(from, to).First(); }
            catch
            { return null; }
            finally
            { db.Dispose(); }
        }
        public decimal? SelectTotalOrder(DateTime from, DateTime to)
        {
            OptimizeChasierEntities db = new OptimizeChasierEntities();
            try { return db.usp_SumSelectOrderByDate(from, to).First(); }
            catch
            { return null; }
            finally
            { db.Dispose(); }
        }
        public List<int?> SelectOrderDele()
            {
                OptimizeChasierEntities db = new OptimizeChasierEntities();
                try { return db.usp_SelectOrdersdelevery().ToList(); }
                catch
                { return null; }
                finally
                { db.Dispose(); }
            }
        public void SetDelevery(int id, decimal rem, int employeeID)
        {
            OptimizeChasierEntities db = new OptimizeChasierEntities();
            try
            {
                db.usp_DeleveryOrder(employeeID , rem , id);
            }
            catch
            { }
            finally
            {
                db.Dispose();
            }
        }

        public void UpdateRequestedOrder(DateTime orderdate, int clientID, TimeSpan time, int id  , string note,int userID)
        {
            OptimizeChasierEntities db = new OptimizeChasierEntities();
            try
            { db.usp_UpdateRequestedOrder(orderdate, clientID, time, id , note , userID); }
            catch
            { }
            finally
            {
                db.Dispose();
            }
        }
        public void DeleteRequestOrder(int id)
        {
            OptimizeChasierEntities db = new OptimizeChasierEntities();
            try
            { db.usp_DeleteRequestOrder(id); }
            catch (Exception ex )
            { }
            finally
            {
                db.Dispose();
            }
        }

        public List<usp_SelectRequestedOrders_Result> SelectRequestedorder(int empID , DateTime date )
        {
            OptimizeChasierEntities db = new OptimizeChasierEntities();
            try
            { return db.usp_SelectRequestedOrders(empID ,date).ToList(); }
            catch
            { return null; }
            finally
            {
                db.Dispose();
            }
        }
        public decimal? SelectedTotal(int empID, DateTime date)
        {
            OptimizeChasierEntities db = new OptimizeChasierEntities();
            try
            { return db.usp_SelectSumRequestedOrders(empID, date).First(); }
            catch(Exception ex)
            { return null; }
            finally
            {
                db.Dispose();
            }
        }
        public List<usp_SelectRequestedOrderByID_Result> SelectRequestedOrderByID(int id)
        {
            OptimizeChasierEntities db = new OptimizeChasierEntities();
            try
            {return  db.usp_SelectRequestedOrderByID(id).ToList(); }
            catch
            {return null; }
            finally
            {
                db.Dispose();
            }
        }
        public List<usp_SelectOrderByDate_Result>SelectOrderByDate(DateTime from , DateTime to)
        {
            OptimizeChasierEntities db = new OptimizeChasierEntities();
            try
            { return db.usp_SelectOrderByDate(from , to).ToList(); }
            catch
            { return null; }
            finally
            {
                db.Dispose();
            }
        }
        
          public List<usp_SelectRem_Result> SelectRequestedRwem()
        {
            OptimizeChasierEntities db = new OptimizeChasierEntities();
            try
            { return db.usp_SelectRem().ToList(); }
            catch(Exception ex)
            { return null; }
            finally
            {
                db.Dispose();
            }
        }
        public List<usp_SelectRequested_Result> SelectRequested()
        {
            OptimizeChasierEntities db = new OptimizeChasierEntities();
            try
            { return db.usp_SelectRequested().ToList(); }
            catch
            { return null; }
            finally
            {
                db.Dispose();
            }
        }
        public List<usp_SelectRequestedOrderDone_Result> SelectRequestedOrderDone()
        {
            OptimizeChasierEntities db = new OptimizeChasierEntities();
            try
            { return db.usp_SelectRequestedOrderDone().ToList(); }
            catch
            { return null; }
            finally
            {
                db.Dispose();
            }
        }
        public List<usp_SelectRequestedOrderByDate_Result> SelectRequestedOrderByDate(DateTime date)
        {
            OptimizeChasierEntities db = new OptimizeChasierEntities();
            try
            { return db.usp_SelectRequestedOrderByDate(date).ToList(); }
            catch
            { return null; }
            finally
            {
                db.Dispose();
            }
        }
        

    }
}
