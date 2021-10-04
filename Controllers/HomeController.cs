using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebApplication.Model;
using WebApplication.Models;
using WebApplication.Repository;

namespace WebApplication.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPhoneRepository _phoneRepository;

        public HomeController(IPhoneRepository phoneRepository)
        {
            _phoneRepository = phoneRepository;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AddDetails(PhoneEntry phoneEntry)
        {
            _phoneRepository.AddPhoneBook(phoneEntry);
            return View();
        }

        public IActionResult DeleteDetails(int phoneEntry)
        {
            _phoneRepository.Delete(phoneEntry);
            return View();
        }

        public IActionResult EditDetails(int phoneEntry)
        {
            var response = _phoneRepository.GetById(phoneEntry);
            return View(response);
        }

        public IActionResult SearchList(int id)
        {
            var response = _phoneRepository.GetById(id);
            return View(response);
        }

        public IActionResult ViewList()
        {
            var response = _phoneRepository.GetAllPhoneBookEntries();
            return View(response);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}