using DoAn_PTUDTTHD.Models;
using DoAn_PTUDTTHD.Repository;
using System.Collections.Generic;
using System.Web.Http;

namespace DoAn_PTUDTTHD.Controllers
{
    public class XeController : ApiController
    {
        XeRepository xeRepository = new XeRepository();
        // GET api/xe
        public IEnumerable<Xe> Get()
        {
            return xeRepository.findAll();
        }

        // GET api/xe/2
        public Xe Get(int id)
        {
            return xeRepository.findById(id);
        }

        // POST api/xe
     
        public bool Post([FromBody] Xe xe)
        {
            return xeRepository.addXe(xe);
        }

        // PUT api/xe
        
        public bool Put([FromBody] Xe xe)
        {
            return xeRepository.updateXe(xe);
        }

        // DELETE api/xe/1
        public bool Delete(int id)
        {
            return xeRepository.deleteXe(id);
        }
    }
}
