using System;

namespace PatikaHomework.DataModel
{
    public class CustomerDtoResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string UserName { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
