using Microsoft.AspNetCore.Mvc;
using UnitOfWork;
using UnitOfWork.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Restaurant_Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        public readonly IUnitOfWork _UnitOfWork;
        public CategoryController(IUnitOfWork UnitOfWork)
        {
            _UnitOfWork = UnitOfWork;

        }
        // GET: api/<CategoryController>
        [HttpGet]
        public async Task <IEnumerable<Category>> Get()
        {
            return await _UnitOfWork.CategoryRepo.GetAllAsync();
        }

        // GET api/<CategoryController>/5
        [HttpGet("{id}")]
        public async Task <Category>Get(int id)
        {
            return await _UnitOfWork.CategoryRepo.GetByIdAsync(id);
        }

        // POST api/<CategoryController>
        [HttpPost]
        public async Task<Category> Post(Category category)
        {
            Category addedCategory =  await _UnitOfWork.CategoryRepo.AddAsync(category);
            _UnitOfWork.Complete();
            return addedCategory;
        }

        // PUT api/<CategoryController>/5
        [HttpPut("{id}")]
        public Category Put(int id, Category category)
        {
            Category updatedCategory = _UnitOfWork.CategoryRepo.Update(category);
            _UnitOfWork.Complete();
            return updatedCategory;
        }

        // DELETE api/<CategoryController>/5
        [HttpDelete("{id}")]
        public void Delete(Category category)
        {
            _UnitOfWork.CategoryRepo.Delete(category);
            _UnitOfWork.Complete();
        }
    }
}
