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

        // login, if return == null -> DANG NHAP THAT BAI
        //  url: api/canbo/login?username=Canbo1&password=123
        [HttpPost]
        [Route("api/Canbo/login")]
        public CanBo Login([FromBody] CanBo canBo)
        {
            return canBoRepository.auth(canBo);
        }

        //Tra cứu thông tin cán bộ
        //Url : api/canbo/tracuucanbo/?username=ahihi
        [HttpGet]
        [Route("api/Canbo/tracuucanbo")]
        public CanBo Get(string username)
        {
            return canBoRepository.findByUsername(username);
        }

        //Đổi mật khẩu can bo
        // Url : api/canbo/doimatkhau?username=test1&oldPassword=123&newPassword=12345
        [HttpPut]
        [Route("api/canbo/DoiMatKhau")]
        public bool DoiMatKhau([FromBody] CanBo canBo)
        {
            return canBoRepository.doiMatKhau(canBo);
        }

        //add can bo
        // POST api/canbo
        public bool Post([FromBody] CanBo canBo)
        {
            return canBoRepository.addCanBo(canBo);
        }

        //PUT api/canbo/update
        [HttpPut]
        [Route("api/Canbo/update")]
        public bool Put([FromBody] CanBo canBo)
        {
            return canBoRepository.updateCanBo(canBo);
        }

        // DELETE api/canbo/1
        //Url : api/canbo/xoacanbo/?username=ahihi
        [HttpDelete]
        [Route("api/Canbo/xoacanbo")]
        public bool Delete(string username)
        {
            return canBoRepository.deleteCanBo(username);
        }

    }
}
