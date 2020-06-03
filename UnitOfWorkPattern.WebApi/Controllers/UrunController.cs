using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UnitOfWorkPattern.DataAccess.UnitOfWork;
using UnitOfWorkPattern.Entities;

namespace UnitOfWorkPattern.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UrunController : ControllerBase
    {
        private readonly IUnitOfWork _uow;
        public UrunController(IUnitOfWork uow)
        {
            _uow = uow;
        }
        [HttpGet]
        [Route("GetAllUruns")]
        public ActionResult<IEnumerable<Urun>> GetAllUruns()
        {
            var repo = _uow.GetRepository<Urun>();

            return repo.GetAll().ToList();
        }


        [HttpGet]
        [Route("GetUrunById/{id}")]
        public ActionResult<Urun> GetUrunById(int id)
        {
            var repo = _uow.GetRepository<Urun>();
            return repo.Get(x => x.Id == id);
        }
        [HttpPost]
        [Route("AddUrun")]
        public IActionResult AddUrun([FromBody] Urun Urun)
        {
            var repo = _uow.GetRepository<Urun>();
            repo.Add(Urun);
            _uow.SaveChanges();
            return Ok("Eklendi.");
        }

        [HttpPost]
        [Route("DeleteUrun/{id}")]
        public IActionResult DeleteUrun(int id)
        {
            var repo = _uow.GetRepository<Urun>();
            repo.Delete(id);
            _uow.SaveChanges();
            return Ok("Silindi.");
        }
    }
}