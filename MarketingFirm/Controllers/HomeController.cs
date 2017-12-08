using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MarketingFirm.Models;
using System.Data;
using Microsoft.AspNet.Identity;



namespace MarketingFirm.Controllers
{

    public class HomeController : Controller
    {
        DbCon aConnection = new DbCon();

        public ActionResult Index()
        {
            

            return View();
        }

        [Authorize]
        public ActionResult GetAllContacts()
        {
            List<Contact> aListOfContact = new List<Contact>();
            aListOfContact = aConnection.GetContact();

            ViewBag.ListOfContact = aListOfContact;
            return View();
        }
        [Authorize]
        public ActionResult InsertContact(string ContactName, string ContactEmail, string ContactPhone, string CompanyName, string JobFunc, string JobLevel, string Industry, string Employees, string Revenue, string ZipCode, string Country, string State, string City)
        {
            
            ViewBag.ContactName = ContactName;
            ViewBag.ContactEmail = ContactEmail;
            ViewBag.ContactPhone = ContactPhone;
            ViewBag.CompanyName = CompanyName;
            ViewBag.JobFunc = JobFunc;
            ViewBag.JobLevel = JobLevel;
            ViewBag.Industry = Industry;
            ViewBag.Employees = Employees;
            ViewBag.Revenue = Revenue;
            ViewBag.ZipCode = ZipCode;
            ViewBag.Country = Country;
            ViewBag.State = State;
            ViewBag.City = City;

            DbCon aConnection = new DbCon();

            aConnection.InsertContact(ContactName, ContactEmail, ContactPhone, CompanyName, JobFunc, JobLevel, Industry, Employees, Revenue, ZipCode, Country, State, City);

            return View();
        }
        [Authorize]
        public ActionResult InsertContactForm()
        {
            return View();
        }
      
        public ActionResult LinqIndustry()
        {
            List<Contact> aListOfContact = new List<Contact>();
            aListOfContact = aConnection.GetContact();

            ViewBag.ListOfContact = aListOfContact;
            return View();
        }

        public ActionResult LinqState()
        {
            List<Contact> aListOfContact = new List<Contact>();
            aListOfContact = aConnection.GetContact();

            ViewBag.ListOfContact = aListOfContact;
            return View();
        }

        public ActionResult ContactDetail(string Phone)
        {
            List<Contact> aListOfContact = new List<Contact>();
            aListOfContact = aConnection.GetContact();

            var contactDetails = from contact in aListOfContact
                                  where contact.ContactPhone == Phone
                                  select contact;

            ViewBag.ListOfContact = contactDetails;
            ViewBag.Phone = Phone;
            return View();
        }

        public ActionResult UpdateContact(string ContactName, string ContactEmail, string ContactPhone, string CompanyName, string JobFunc, string JobLevel, string Industry, string Employees, string Revenue, string ZipCode, string Country, string State, string City)
        {
            //So the end user knows his updates
            ViewBag.ContactName = ContactName;
            ViewBag.ContactEmail = ContactEmail;
            ViewBag.ContactPhone = ContactPhone;
            ViewBag.CompanyName = CompanyName;
            ViewBag.JobFunc = JobFunc;
            ViewBag.JobLevel = JobLevel;
            ViewBag.Industry = Industry;
            ViewBag.Employees = Employees;
            ViewBag.Revenue = Revenue;
            ViewBag.ZipCode = ZipCode;
            ViewBag.Country = Country;
            ViewBag.State = State;
            ViewBag.City = City;

            //backend
            aConnection.UpdateContact(ContactName, ContactEmail, ContactPhone, CompanyName, JobFunc, JobLevel, Industry, Employees, Revenue, ZipCode, Country, State, City);

            return View();
        }


    }
}