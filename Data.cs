using LiteDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Muhasebe
{
    class Data<T> where T:class
    {

      
        public List<T> GetAll()
        {
            List<T> list = new List<T>();
            var db = new LiteDatabase(Sabitler.db);
            var col = db.GetCollection<T>(typeof(T).Name);
                foreach (T data in col.FindAll())
                {
                   
                    list.Add(data);
                }
          
            return list;
        }
        public bool AddSingle(T param) {


            try
            {
                var db = new LiteDatabase(Sabitler.db);
                var col = db.GetCollection<T>(typeof(T).Name);
                col.Insert (param);
            }
            catch { return false; }

            return true;
        }

        public void AddMultiple(List<T> parameters)
        {
            using (var db = new LiteDatabase(Sabitler.db))
            {
                var col = db.GetCollection<T>(typeof(T).Name);
                foreach (T parameter in parameters)
                {
                    col.Insert(parameter);
                }

              
            }
        }

        public bool DeleteSingle(LiteDB.ObjectId param)
        {
            try
            {
                var db = new LiteDatabase(Sabitler.db);
                var col = db.GetCollection<T>(typeof(T).Name);
                col.Delete(param);

            }

            catch { return false; }

            return true;
        }


        public bool UpdateSingle(T param)
        {

            try
            {
                var db = new LiteDatabase(Sabitler.db);

                var col = db.GetCollection<T>(typeof(T).Name);
                col.Update(param);

            }
            catch(Exception ex) { MessageBox.Show(ex.Message); return false;} 

            return true;
        }


        public void UpdateMultiple(List<T> param)
        {

            using (var db = new LiteDatabase(Sabitler.db))
            {
                var col = db.GetCollection<T>(typeof(T).Name);
                col.Update(param);

            }
        }



        public void DeleteMultiple(List<LiteDB.ObjectId> param)
        {

            using (var db = new LiteDatabase(Sabitler.db))
            {
                var col = db.GetCollection<T>(typeof(T).Name);
                foreach (ObjectId id in param) col.Delete(id);
              


            }
        }

    }
}
