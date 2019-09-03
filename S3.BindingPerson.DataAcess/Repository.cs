
using S3.BindingPerson.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S3.BindingPerson.DataAcess
{
    public class Repository
    {
        PersonModel model = new PersonModel();

        public List<Person> GetAllPersons()
        {
            List<Person> allPersons = model.People.ToList();
            return allPersons;
        }

        public void Update(Person person)
        {
            model.People.AddOrUpdate(person);
            model.SaveChanges();
        }

        public void Insert(Person person)
        {
            model.People.Add(person);
            model.SaveChanges();
        }


    }
}
