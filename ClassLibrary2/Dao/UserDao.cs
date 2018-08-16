using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary2.EF;
namespace ClassLibrary2.Dao
{
    public class UserDao
    {
        AChanDB db = null;
        public UserDao()
        {
            db = new AChanDB();
        }
        public KhachHang getByID(string id)
        {
            return db.KhachHangs.SingleOrDefault(x => x.taikhoan == id);
        }
        public long Insert(KhachHang entity)
        {
            db.KhachHangs.Add(entity);
            db.SaveChanges();

            return entity.maKH;
        }
        public bool Login(String username, String password)
        {
            var result = db.KhachHangs.Count(x => x.taikhoan == username && x.matkhau == password);
            if (result > 0) return true;
            else return false;
        }
    }
}
