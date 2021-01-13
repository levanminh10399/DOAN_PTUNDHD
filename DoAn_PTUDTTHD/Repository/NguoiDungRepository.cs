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
        public NguoiDung findByUsername(string username)
        {
            using (var db = new QLHTGTEntities())
            {
                NguoiDung nguoiDung = db.NguoiDungs.Include("BangLais").Include("YeuCauDangKyXes").Where(n => n.username == username).FirstOrDefault();
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
                NguoiDung ndung = findByUsername(nguoiDung.username);
                if (ndung != null)
                    return false;
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

        public bool doiMatKhau(string username, string oldPassword, string newPassword)
        {

            using (var db = new QLHTGTEntities())
            {
                try
                {

                    NguoiDung user = db.NguoiDungs.Where(n => n.username == username).FirstOrDefault();
                    if (user == null || user.password != oldPassword)
                        return false;
                    user.password = newPassword;
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
<<<<<<< HEAD
        public bool updateNguoiDung(NguoiDung nguoiDung)
=======
<<<<<<< HEAD
        public bool addNguoiDung(NguoiDung nguoiDung)
        {

=======
        public bool doiMatKhau(int id, string matkhau)
>>>>>>> parent of e8a0c6f... thêm 1 api get LoaiXe by properties
        {
>>>>>>> f4f84e7748b2b70ea6312cd64ffcbba9fc9ac9c9
            using (var db = new QLHTGTEntities())
            {
                try
                {
<<<<<<< HEAD
                    NguoiDung nguoiDungUpdate = db.NguoiDungs.Where(n => n.username == nguoiDung.username).FirstOrDefault();
                    if (nguoiDungUpdate == null)
=======
<<<<<<< HEAD
                    db.NguoiDungs.Add(nguoiDung);
                    db.SaveChanges();
                    return true;
=======
                    NguoiDung user = db.NguoiDungs.Find(id);
                    if (user == null)
>>>>>>> parent of e8a0c6f... thêm 1 api get LoaiXe by properties
                        return false;
                    nguoiDungUpdate.Ten = nguoiDung.Ten;
                    nguoiDungUpdate.CMND = nguoiDung.CMND;
                    nguoiDungUpdate.GioiTinh = nguoiDung.GioiTinh;
                    nguoiDungUpdate.NgaySinh = nguoiDung.NgaySinh;
                    nguoiDungUpdate.DiaChi = nguoiDung.DiaChi;
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
<<<<<<< HEAD
=======

>>>>>>> f4f84e7748b2b70ea6312cd64ffcbba9fc9ac9c9
>>>>>>> parent of e8a0c6f... thêm 1 api get LoaiXe by properties
        }



    }
}