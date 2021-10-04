using System;
using System.Collections.Generic;
using System.Linq;
using WebApplication.Model;

namespace WebApplication.Repository
{
    public interface IPhoneRepository
    {
        public List<PhoneEntry> GetAllPhoneBookEntries();

        public PhoneEntry SearchPhoneBook(string phoneNumber);

        public void AddPhoneBook(PhoneEntry phoneBook);

        public void Delete(int id);

        public PhoneEntry GetById(int id);
    }
}