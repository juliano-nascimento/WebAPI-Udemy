using RestWebAPI.Models;
using RestWebAPI.Models.Context;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RestWebAPI.Services.Implementations
{
    public class PersonServiceImpl : IPersonService
    {
        private MySQLContext _context;
        public PersonServiceImpl(MySQLContext context)
        {
            _context = context;
        }
        public Person Create(Person person)
        {
            try
            {
                _context.Add(person);
                _context.SaveChanges();
            }
            catch(Exception ex)
            {
                throw ex;
            }

            return person;
        }

        public void Delete(long id)
        {
            
        }

        public List<Person> FindAll()
        {
            return _context.Persons.ToList();
        }

        public Person FindById(long id)
        {
            return _context.Persons.FirstOrDefault(p => p.Id == id);
        }

        public Person Update(Person person)
        {
            if (!Exist(person.Id)) return new Person();
            var result = _context.Persons.FirstOrDefault(p => p.Id.Equals(person.Id));
            try
            {
                _context.Entry(result).CurrentValues.SetValues(person);
                _context.SaveChanges();
            }
            catch(Exception ex)
            {
                throw ex;
            }
            return person;
        }

        private bool Exist(long id)
        {
            return _context.Persons.Any(p => p.Id == id);
        }
    }
}
