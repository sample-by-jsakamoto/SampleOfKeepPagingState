using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SampleOfKeepPagingState.Models
{
    public class PersonRepository
    {
        public IEnumerable<Person> GetAll()
        {
            return new[] { 
                new Person{Id=1, Name="Peter"},
                new Person{Id=2, Name="Mike"},
                new Person{Id=3, Name="Jhon"},
                new Person{Id=4, Name="Anna"},
                new Person{Id=5, Name="Steve"},
            };
        }

        public Person FindById(int id)
        {
            return GetAll().FirstOrDefault(p => p.Id == id);
        }
    }
}