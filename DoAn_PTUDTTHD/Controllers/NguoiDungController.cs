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
        HoaDonRepository hoaDonRepository = new HoaDonRepository();

        //get all
        public IEnumerable<NguoiDung> Get()
        {
            return nguoiDungRepository.findAll();
        }
        //find by cmnd
        //Url: api/nguoidung/cmnd/?CMND=123456789
        [HttpGet]
        [Route("api/nguoidung/cmnd")]
        public NguoiDung GetByCMND(string CMND)
        {
            return nguoiDungRepository.findByCMND(CMND);
        }
        // login, if return == null -> DANG NHAP THAT BAI
        //  url: api/nguoidung/login?username=test1&password=123
        [HttpGet]
        [Route("api/nguoidung/login")]
        public NguoiDung Login(string username, string password)
        {
            return nguoiDungRepository.auth(username, password);
        }

        // sau khi dang nhap thanh cong, get nguoidung theo username   
        [HttpGet]
        [Route("api/nguoidung/")]
        public NguoiDung GetByUsername(string username)
        {
            return nguoiDungRepository.findByCMND(username);
        }
<<<<<<< HEAD

        //add nguoiDung
        //POST 
=======
<<<<<<< HEAD
        //add nguoiDung
        public bool Post ([FromBody] NguoiDung nguoiDung)
        {
            return nguoiDungRepository.addNguoiDung(nguoiDung);
        }
=======
        //Đăng ký
>>>>>>> parent of e8a0c6f... thêm 1 api get LoaiXe by properties
        public bool Post([FromBody] NguoiDung nguoiDung)
        {
            return nguoiDungRepository.addNguoiDung(nguoiDung);
        }

        //Đổi mật khẩu
        // Url : api/nguoidung/doimatkhau?username=test1&oldPassword=123&newPassword=12345
        [HttpGet]
        [Route("api/NguoiDung/DoiMatKhau")]
        public bool DoiMatKhau(string username, string oldPassword, string newPassword)
        {
            return nguoiDungRepository.doiMatKhau(username, oldPassword, newPassword);
        }

        //PUT api/nguoidung
        [HttpPut]
        [Route("api/NguoiDung/update")]
        public bool Put([FromBody] NguoiDung nguoiDung)
        {
            return nguoiDungRepository.updateNguoiDung(nguoiDung);
        }

        //Nộp Phạt
        [HttpGet]
        [Route("api/NguoiDung/NopPhat")]
        public bool Post([FromBody] HoaDon hoaDon)
        {
            return hoaDonRepository.addHoaDon(hoaDon);
        }

<<<<<<< HEAD



=======
        //Đổi mật khẩu
        [HttpGet]
        [Route("api/NguoiDung/DoiMatKhau")]
        public bool DoiMatKhau(int id, string password)
        {
            return nguoiDungRepository.doiMatKhau(id, password);
        }

>>>>>>> f4f84e7748b2b70ea6312cd64ffcbba9fc9ac9c9
>>>>>>> parent of e8a0c6f... thêm 1 api get LoaiXe by properties
    }
}
