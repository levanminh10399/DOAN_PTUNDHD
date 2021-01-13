using DoAn_PTUDTTHD.Models;
using System.Collections.Generic;
using System.Linq;

namespace DoAn_PTUDTTHD.Repository
{
    public class NguoiDungRepository
    {
        public NguoiDung findByCMND(string CMND)
        {
            using (var db = new QLHTGTEntities())
            {
                NguoiDung nguoiDung = db.NguoiDungs.Where(n => n.CMND == CMND).FirstOrDefault();
                if (nguoiDung != null)
                {
                    return nguoiDung;
                }
            }
            return null;
        }
        public NguoiDung findById(int id)
        {
            using (var db = new QLHTGTEntities())
            {
                NguoiDung nguoiDung = db.NguoiDungs.Where(n => n.ID == id).FirstOrDefault();
                if (nguoiDung != null)
                {
                    return nguoiDung;
                }
            }
            return null;
        }
        public List<NguoiDung> findAll()
        {
            using (var db = new QLHTGTEntities())
            {
                List<NguoiDung> nguoiDungs = db.NguoiDungs.Include("BangLais").ToList();
                if (nguoiDungs != null)
                    return nguoiDungs;
            }
            return null;
        }
        public NguoiDung auth(string username, string password)
        {
            using (var db = new QLHTGTEntities())
            {
                NguoiDung nguoiDung = db.NguoiDungs.Where(c => c.username == username && c.password == password).FirstOrDefault();
                if (nguoiDung != null)
                    return nguoiDung;
            }
            return null;
        }
        public bool addNguoiDung(NguoiDung nguoiDung)
        {

            using (var db = new QLHTGTEntities())
            {
                try
                {
                    db.NguoiDungs.Add(nguoiDung);
                    db.SaveChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
            }
        }
    }
}