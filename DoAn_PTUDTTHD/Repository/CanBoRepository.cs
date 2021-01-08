using DoAn_PTUDTTHD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DoAn_PTUDTTHD.Repository
{
    public class CanBoRepository
    {
        public List<CanBo> findAll()
        {
            using (var db = new QLHTGTEntities())
            {
                List<CanBo> canBos = db.CanBoes.ToList();
                if (canBos != null)
                    return canBos;
            }
            return null;
        }
        public CanBo auth(string username,string password)
        {
            using (var db = new QLHTGTEntities())
            {
                CanBo canBo = db.CanBoes.Where(c => c.username == username && c.password == password).FirstOrDefault();
                if (canBo != null)
                    return canBo;
            }
                return null;
        }
    }
}