using DoAn_PTUDTTHD.Models;
using DoAn_PTUDTTHD.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DoAn_PTUDTTHD.Controllers
{
    public class NguoiDungController : ApiController
    {
        NguoiDungRepository nguoiDungRepository = new NguoiDungRepository();

        //get all
        public IEnumerable<NguoiDung> Get()
        {
            return nguoiDungRepository.findAll();
        }
        //Login
        public NguoiDung Get(string CMND)
        {
            return nguoiDungRepository.findByCMND(CMND);
        }
    }
}
