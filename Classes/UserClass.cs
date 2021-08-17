using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chaisher.Classes
{
  public  class UserClass
    {
        public int? CheckLogin(string username, string password)
        {
            OptimizeChasierEntities db = new OptimizeChasierEntities();
            try
            { return db.usp_CheckLogin(username, password).First(); }
            catch (Exception EX)
            {

                return null;
            }
            finally
            { db.Dispose(); }
        }
        public void InsertNewUser(string username, string password, int prevId)
        {
            OptimizeChasierEntities db = new OptimizeChasierEntities();
            try { db.usp_InsertNewUser(username, password, prevId); }
            catch { }
            finally { db.Dispose(); }
        }
        public void UpdateNewUser(string username, string password, int prevId , int id )
        {
            OptimizeChasierEntities db = new OptimizeChasierEntities();
            try { db.usp_UpdateNewUser(username, password, prevId , id); }
            catch { }
            finally { db.Dispose(); }
        }
        public void DeleteUser(int id )
        {
            OptimizeChasierEntities db = new OptimizeChasierEntities();
            try { db.usp_DeleteNewUser( id); }
            catch { }
            finally { db.Dispose(); }
        }
        public List<usp_SelectNewUser_Result> SelectUsers()
        {
            OptimizeChasierEntities db = new OptimizeChasierEntities();
            try{return db.usp_SelectNewUser().ToList(); }
            catch{ return null; }
            finally{ db.Dispose(); }
        }
        public List<usp_SelectNewUserByID_Result> SelectUsers(int id )
        {
            OptimizeChasierEntities db = new OptimizeChasierEntities();
            try { return db.usp_SelectNewUserByID(id).ToList(); }
            catch { return null; }
            finally { db.Dispose(); }
        }

    }
}
