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
    public class KategoriController : ControllerBase
    {
        private readonly IUnitOfWork _uow;
        public KategoriController(IUnitOfWork uow)
        {
            _uow = uow;
        }
        [HttpGet]
        [Route("GetAllKategoris")]
        public ActionResult<IEnumerable<Kategori>> GetAllKategoris()
        {
            var repo = _uow.GetRepository<Kategori>();

            return repo.GetAll().ToList();
        }


        [HttpGet]
        [Route("GetKategoriById/{id}")]
        public ActionResult<Kategori> GetKategoriById(int id)
        {
            var repo = _uow.GetRepository<Kategori>();
            return repo.Get(x => x.Id == id);
        }
        [HttpPost]
        [Route("AddKategori")]
        public IActionResult AddKategori([FromBody] Kategori Kategori)
        {
            var repo = _uow.GetRepository<Kategori>();
            repo.Add(Kategori);
            _uow.SaveChanges();
            return Ok("Eklendi.");
        }

        [HttpPost]
        [Route("DeleteKategori/{id}")]
        public IActionResult DeleteKategori(int id)
        {
            var repo = _uow.GetRepository<Kategori>();
            repo.Delete(id);
            _uow.SaveChanges();
            return Ok("Silindi.");
        }
    }
}