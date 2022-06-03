using AutoMapper;
using PatikaHomework.DataModel;
using PatikaHomework.Repository;
using PatikaHomework.UnitofWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace PatikaHomework.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public CustomerService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public void Delete(int id)
        {
            var result = _unitOfWork.CustomerRepository.GetById(id);
            _unitOfWork.CustomerRepository.Delete(result);
        }

        public IEnumerable<CustomerDtoResponse> GetAll()
        {
            var result = _unitOfWork.CustomerRepository.GetAll();
            var resultDto = _mapper.Map<IEnumerable<CustomerDto>>(result);
            var customerDtoResponse = _mapper.Map<IEnumerable<CustomerDtoResponse>>(resultDto);
            return customerDtoResponse;
            
        }

        public CustomerDtoResponse GetById(int id)
        {
            var customer = _unitOfWork.CustomerRepository.GetById(id);
            var customerDto = _mapper.Map<CustomerDto>(customer);
            var customerDtoResponse = _mapper.Map<CustomerDtoResponse>(customerDto);
            return customerDtoResponse;
        }

        public async Task<CustomerDto> InsertAsync(CustomerDto customerDto)
        {
            customerDto.CreatedDate = DateTime.Now;
            var customer = _mapper.Map<Customer>(customerDto);
            await _unitOfWork.CustomerRepository.InsertAsync(customer);
            await _unitOfWork.SaveAsync();
            return customerDto;
        }

        public List<CustomerDtoResponse> SearchName(string name)
        {
            var result = _unitOfWork.CustomerRepository.Where(x => x.Name == name);
            return _mapper.Map<List<CustomerDtoResponse>>(result);
        }

        public void Update(CustomerDto customerDto)
        {
            var customer = _mapper.Map<Customer>(customerDto);
            _unitOfWork.CustomerRepository.Update(customer);
            _unitOfWork.Save();
        }
    }
}
