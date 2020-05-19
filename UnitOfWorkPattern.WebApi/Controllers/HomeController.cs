using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UnitOfWorkPattern.DataAccess.EntityFramework.Contexts;
using UnitOfWorkPattern.DataAccess.Repositories;
using UnitOfWorkPattern.DataAccess.UnitOfWork;
using UnitOfWorkPattern.Entities;

namespace UnitOfWorkPattern.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly IUnitOfWork _uow;
        public HomeController(IUnitOfWork uow)
        {
            _uow = uow;
        }
        #region Product işlemleri
        [HttpGet]
        [Route("GetAllProducts")]
        public ActionResult<IEnumerable<Product>> GetAllProducts()
        {
            var repo = _uow.GetRepository<Product>();

            return repo.GetAll().ToList();
        }


        [HttpGet]
        [Route("GetProductById/{id}")]
        public ActionResult<Product> GetProductById(int id)
        {
            var repo = _uow.GetRepository<Product>();
            return repo.Get(x => x.Id == id);
        }
        [HttpPost]
        [Route("AddProduct")]
        public IActionResult AddProduct([FromBody] Product product)
        {
            var repo = _uow.GetRepository<Product>();
            repo.Add(product);
            _uow.SaveChanges();
            return Ok("Eklendi.");
        }

        [HttpPost]
        [Route("DeleteProduct/{id}")]
        public IActionResult DeleteProduct(int id)
        {
            var repo = _uow.GetRepository<Product>();
            repo.Delete(id);
            _uow.SaveChanges();
            return Ok("Silindi.");
        }
        #endregion

        #region Category İşlemleri

        [HttpGet]
        [Route("GetAllCategorys")]
        public ActionResult<IEnumerable<Category>> GetAllCategorys()
        {
            var repo = _uow.GetRepository<Category>();

            return repo.GetAll().ToList();
        }


        [HttpGet]
        [Route("GetCategoryById/{id}")]
        public ActionResult<Category> GetCategoryById(int id)
        {
            var repo = _uow.GetRepository<Category>();
            return repo.Get(x => x.Id == id);
        }
        [HttpPost]
        [Route("AddCategory")]
        public IActionResult AddCategory([FromBody] Category category)
        {
            var repo = _uow.GetRepository<Category>();
            repo.Add(category);
            _uow.SaveChanges();
            return Ok("Eklendi.");
        }

        [HttpPost]
        [Route("DeleteCategory/{id}")]
        public IActionResult DeleteCategory(int id)
        {
            var repo = _uow.GetRepository<Category>();
            repo.Delete(id);
            _uow.SaveChanges();
            return Ok("Silindi.");
        }
    }
    #endregion

}