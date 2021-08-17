using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chaisher.Classes
{
    class ClientsClass
    {
    public int? SelectMaxClient()
    {
            OptimizeChasierEntities db = new OptimizeChasierEntities();
            try { return db.usp_selectMaxClient().First(); }
            catch { return null; }
            finally { db.Dispose(); }
        }
        public List<usp_SelectAllClients_Result> SelectAllClients()
        {

            OptimizeChasierEntities db = new OptimizeChasierEntities();
            try { return db.usp_SelectAllClients().ToList(); }
            catch { return null; }
            finally { db.Dispose(); }
        }
        public List<usp_SelectAllClientsByDistrict_Result> SelectAllClientsByDistrict(int district)
        {

            OptimizeChasierEntities db = new OptimizeChasierEntities();
            try { return db.usp_SelectAllClientsByDistrict(district).ToList(); }
            catch { return null; }
            finally { db.Dispose(); }
        }
        public List<usp_SelectAllClientsByID_Result> SelectAllClients(int id)
        {

            OptimizeChasierEntities db = new OptimizeChasierEntities();
            try { return db.usp_SelectAllClientsByID(id).ToList(); }
            catch { return null; }
            finally { db.Dispose(); }
        }
        public List<usp_SelectAllClientsByPhone_Result> SelectAllClientByPhone(string phone)
        {

            OptimizeChasierEntities db = new OptimizeChasierEntities();
            try { return db.usp_SelectAllClientsByPhone(phone).ToList(); }
            catch { return null; }
            finally { db.Dispose(); }
        }
        public void InsertClient (string clientsName ,string clientPhone ,string clientAddress ,int  district)
        {
            OptimizeChasierEntities db = new OptimizeChasierEntities();
            try
            { db.usp_InsertClients(clientsName , clientPhone , clientAddress , district); }
            catch{ }
            finally{ db.Dispose(); }
        }
        public void UpdateClient(int id ,string clientsName, string clientPhone, string clientAddress, int district)
        {
            OptimizeChasierEntities db = new OptimizeChasierEntities();
            try
            { db.usp_UpdateClients(clientsName, clientPhone, clientAddress , id , district); }
            catch { }
            finally { db.Dispose(); }
        }
        public void DeleteClient(int id )
        {
            OptimizeChasierEntities db = new OptimizeChasierEntities();
            try
            { db.usp_DeleteAllClientsByID(id); }
            catch { }
            finally { db.Dispose(); }
        }
    }
}
