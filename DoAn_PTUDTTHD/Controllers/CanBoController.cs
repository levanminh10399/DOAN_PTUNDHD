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
    public class CanBoController : ApiController
    {
        CanBoRepository canBoRepository = new CanBoRepository();
        //get all
        public IEnumerable<CanBo> Get()
        {
            return canBoRepository.findAll();
        }
        //login
        public CanBo Post(string username,string password)
        {
            return canBoRepository.auth(username, password);
        }
    }
}
