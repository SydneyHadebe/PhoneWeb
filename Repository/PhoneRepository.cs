using System;
using System.Collections.Generic;
using System.Linq;
using WebApplication.Model;

namespace WebApplication.Repository
{
    public class PhoneRepository : IPhoneRepository
    {
        private readonly PhoneContext _phoneContext = new PhoneContext();

        public void AddPhoneBook(PhoneEntry phoneBook)
        {
            if (string.IsNullOrEmpty(phoneBook.PhoneNumber))
            {
                return;
            }

            var add = _phoneContext.PhoneEntries.Add(phoneBook);
        }

        public List<PhoneEntry> GetAllPhoneBookEntries()
        {
            var results = _phoneContext.PhoneEntries.ToList();
            return results;
        }

        public PhoneEntry GetById(int id)
        {
            var results = _phoneContext.PhoneEntries.FirstOrDefault(a => a.Id == id);
            return results;


        }

        public PhoneEntry SearchPhoneBook(string phoneNumber)
        {
            if (phoneNumber is null)
            {
                throw new ArgumentNullException(nameof(phoneNumber));
            }

            var results = _phoneContext.PhoneEntries.FirstOrDefault(a => a.PhoneNumber == phoneNumber);
            return results;


        }

        public void Delete(int id)
        {
            var response = _phoneContext.PhoneEntries.FirstOrDefault(a => a.Id == id);
            if (response == null)
            {
                return;
            }
            var results = _phoneContext.PhoneEntries.Remove(response);

        }
    }
}