﻿using DoAn_PTUDTTHD.Models;
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
        [HttpPost]
        [Route("api/nguoidung/login")]
        public NguoiDung Login([FromBody] NguoiDung nguoiDung)
        {
            return nguoiDungRepository.auth(nguoiDung);
        }

        // sau khi dang nhap thanh cong, get nguoidung theo username   
        [HttpGet]
        [Route("api/nguoidung/")]
        public NguoiDung GetByUsername(string username)
        {
            return nguoiDungRepository.findByCMND(username);
        }

        //add nguoiDung
        //POST 
        public bool Post([FromBody] NguoiDung nguoiDung)
        {
            return nguoiDungRepository.addNguoiDung(nguoiDung);
        }

        //Đổi mật khẩu
        // Url : api/nguoidung/doimatkhau?username=test1&oldPassword=123&newPassword=12345
        [HttpPut]
        [Route("api/NguoiDung/DoiMatKhau")]
        public bool DoiMatKhau([FromBody] NguoiDung nguoiDung)
        {
            return nguoiDungRepository.doiMatKhau(nguoiDung);
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




    }
}
