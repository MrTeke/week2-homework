using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PatikaHomework.DataModel;
using PatikaHomework.Services;
using PatikaHomework.UnitofWork;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PatikaHomework.Controllers
{
    
    [Route("patika/api/[controller]/[action]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService _customerService;
        private readonly IUnitOfWork _unitOfWork;
        public CustomerController(ICustomerService customerService, IUnitOfWork unitOfWork)
        {
            _customerService = customerService;
            _unitOfWork = unitOfWork;
        }
    
        [HttpGet]
        public CustomerDtoResponse GetById(int id)
        {
            return _customerService.GetById(id);
        }
        
        [HttpGet]
        public IEnumerable<CustomerDtoResponse> GetAll()
        {
            return _customerService.GetAll();
        }
        
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CustomerDto customerDto)
        {
            var result = await _customerService.InsertAsync(customerDto);
            return Ok(result);
        }
        [HttpDelete]
        public IActionResult Delete(int id)
        {
            _customerService.Delete(id);
            return Ok();
        }
        [HttpPut]
        public IActionResult Update([FromBody] CustomerDto customerDto)
        {
            _customerService.Update(customerDto);
            return Ok();
        }
        [HttpGet]
        public List<CustomerDtoResponse> SearchName(string name)
        {
            var result = _customerService.SearchName(name);
            if (result ==  null)
            {
                return null;
            }
            return result;
        }
    }
}
