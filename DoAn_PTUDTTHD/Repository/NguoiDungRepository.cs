using DoAn_PTUDTTHD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

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
        public List<NguoiDung> findAll()
        {
            using (var db = new QLHTGTEntities())
            {
                List<NguoiDung> nguoiDungs = db.NguoiDungs.ToList();
                if (nguoiDungs != null)
                    return nguoiDungs;
            }
            return null;
        }
    }
}