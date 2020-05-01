using RestWebAPI.Models;
using System;
using System.Collections.Generic;


namespace RestWebAPI.Services.Implementations
{
    public class PersonServiceImpl : IPersonService
    {
        public Person Create(Person person)
        {
            return person;
        }

        public void Delete(long id)
        {
            
        }

        public List<Person> FindAll()
        {
            return new List<Person>();
        }

        public Person FindById(long id)
        {
            return new Person
            {
                Id = 1,
                FirstName = "Juliano",
                LastName = "Nascimento",
                Address = "São Paulo - São Paulo - Brasil",
                Gender = "Male"
            };
        }

        public Person Update(Person person)
        {
            return person;
        }
    }
}
