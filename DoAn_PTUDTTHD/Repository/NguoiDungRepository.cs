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
                NguoiDung nguoiDung = db.NguoiDungs.Include("BangLais").Include("YeuCauDangKyXes").Where(n => n.CMND == CMND).FirstOrDefault();
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
                NguoiDung nguoiDung = db.NguoiDungs.Include("BangLais").Include("YeuCauDangKyXes").Where(n => n.ID == id).FirstOrDefault();
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
<<<<<<< HEAD
                List<NguoiDung> nguoiDungs = db.NguoiDungs.Include("BangLais").ToList();
=======
                List<NguoiDung> nguoiDungs = db.NguoiDungs.Include("BangLais").Include("YeuCauDangKyXes").ToList();
>>>>>>> f4f84e7748b2b70ea6312cd64ffcbba9fc9ac9c9
                if (nguoiDungs != null)
                    return nguoiDungs;
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
                    if (db.SaveChanges() > 0)
                        return true;
                    else return false;
                }
                catch
                {
                    return false;
                }
            }
        }
        public NguoiDung auth(string username, string password)
        {
            using (var db = new QLHTGTEntities())
            {
                NguoiDung nguoiDung = db.NguoiDungs.Include("BangLais").Include("YeuCauDangKyXes").Where(c => c.username == username && c.password == password).FirstOrDefault();
                if (nguoiDung != null)
                    return nguoiDung;
            }
            return null;
        }
<<<<<<< HEAD
        public bool addNguoiDung(NguoiDung nguoiDung)
        {

=======
        public bool doiMatKhau(int id, string matkhau)
        {
>>>>>>> f4f84e7748b2b70ea6312cd64ffcbba9fc9ac9c9
            using (var db = new QLHTGTEntities())
            {
                try
                {
<<<<<<< HEAD
                    db.NguoiDungs.Add(nguoiDung);
                    db.SaveChanges();
                    return true;
=======
                    NguoiDung user = db.NguoiDungs.Find(id);
                    if (user == null)
                        return false;
                    user.password = matkhau;
                    if (db.SaveChanges() > 0)
                        return true;
                    else return false;
>>>>>>> f4f84e7748b2b70ea6312cd64ffcbba9fc9ac9c9
                }
                catch
                {
                    return false;
                }
            }
<<<<<<< HEAD
=======

>>>>>>> f4f84e7748b2b70ea6312cd64ffcbba9fc9ac9c9
        }
    }
}