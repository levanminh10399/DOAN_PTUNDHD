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
        public CanBo findById(int id)
        {
            using (var db = new QLHTGTEntities())
            {
                CanBo canBo = db.CanBoes.Where(b => b.ID == id).FirstOrDefault();
                if (canBo != null)
                    return canBo;
            }
            return null;
        }
        public CanBo findByUsername(string username)
        {
            using (var db = new QLHTGTEntities())
            {
                CanBo canBo = db.CanBoes.Where(b => b.username == username).FirstOrDefault();
                if (canBo != null)
                    return canBo;
            }
            return null;
        }
        public CanBo auth(CanBo canBo)
        {
            using (var db = new QLHTGTEntities())
            {
                CanBo cbo = db.CanBoes.Where(c => c.username == canBo.username && c.password == canBo.password).FirstOrDefault();
                if (cbo != null)
                    return cbo;
            }
            return null;
        }
        public bool doiMatKhau(CanBo _canBo)
        {

            using (var db = new QLHTGTEntities())
            {
                try
                {

                    CanBo canBo = db.CanBoes.Where(n => n.username == _canBo.username).FirstOrDefault();
                    if (canBo == null)
                        return false;

                    canBo.password = _canBo.password;
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
        public bool addCanBo(CanBo canBo)
        {
            using (var db = new QLHTGTEntities())
            {
                CanBo cbo = this.findByUsername(canBo.username);
                if (cbo != null)
                    return false;
                try
                {
                    db.CanBoes.Add(canBo);
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

        public bool updateCanBo(CanBo canBo)
        {
            using (var db = new QLHTGTEntities())
            {
                try
                {
                    CanBo canBoUpdate = db.CanBoes.Where(n => n.username == canBo.username).FirstOrDefault();
                    if (canBoUpdate == null)
                        return false;
                    canBoUpdate.Ten = canBo.Ten;
                    canBoUpdate.Bac = canBo.Bac;
                    canBoUpdate.username = canBo.username;
                    canBoUpdate.password = canBo.password;
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
        public bool deleteCanBo(string username)
        {
            using (var db = new QLHTGTEntities())
            {
                try
                {
                    CanBo canBoDel = db.CanBoes.Where(n => n.username == username).FirstOrDefault();
                    db.CanBoes.Remove(canBoDel);
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
    }
}