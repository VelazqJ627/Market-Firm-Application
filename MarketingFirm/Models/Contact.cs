using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MarketingFirm.Models
{
    public class Contact
    {
        //private Variable
        private int contactId = 0;
        private string contactName = "n/a";
        private string contactEmail = "n/a";
        private string contactPhone = "n/a";
        private string companyName = "n/a";
        private string jobFunc = "n/a";
        private string jobLevel = "n/a";
        private string industry = "n/a";
        private string employees = "n/a";
        private string revenue = "n/a";
        private string zipCode = "n/a";
        private string country = "n/a";
        private string state = "n/a";
        private string city = "n/a";

        //gets and sets

        public int ContactId { get { return this.contactId; } set { this.contactId = value; } }
        public string ContactName { get { return this.contactName; } set { this.contactName = value; } }
        public string ContactEmail { get { return this.contactEmail; } set { this.contactEmail = value; } }
        public string ContactPhone { get { return this.contactPhone; } set { this.contactPhone = value; } }
        public string CompanyName { get { return this.companyName; } set { this.companyName = value; } }
        public string JobFunc { get { return this.jobFunc; } set { this.jobFunc = value; } }
        public string JobLevel { get { return this.jobLevel; } set { this.jobLevel = value; } }
        public string Industry { get { return this.industry; } set { this.industry = value; } }
        public string Employees { get { return this.employees; } set { this.employees = value; } }
        public string Revenue { get { return this.revenue; } set { this.revenue = value; } }
        public string ZipCode { get { return this.zipCode; } set { this.zipCode = value; } }
        public string Country { get { return this.country; } set { this.country = value; } }
        public string State { get { return this.state; } set { this.state = value; } }
        public string City { get { return this.city; } set { this.city = value; } }

        //ToString

        public override string ToString()
        {
            string aMessage = "n/a";
            aMessage = aMessage + "Contact ID: " + ContactId + "<br />";
            aMessage = aMessage + "Contact Name: " + ContactName + "<br />";
            aMessage = aMessage + "Contact Email: " + ContactEmail + "<br />";
            aMessage = aMessage + "Contact Phone: " + ContactPhone + "<br />";
            aMessage = aMessage + "Company Name: " + CompanyName + "<br />";
            aMessage = aMessage + "Job Function: " + JobFunc + "<br />";
            aMessage = aMessage + "Job Level: " + JobLevel + "<br />";
            aMessage = aMessage + "Industry: " + Industry + "<br />";
            aMessage = aMessage + "Employees: " + Employees + "<br />";
            aMessage = aMessage + "Revenue: " + Revenue + "<br />";
            aMessage = aMessage + "Zip Code: " + ZipCode + "<br />";
            aMessage = aMessage + "Country: " + Country + "<br />";
            aMessage = aMessage + "State: " + State + "<br />";
            aMessage = aMessage + "City: " + City + "<br />";
            return aMessage;
        }

        //COnstructors 

        public Contact()
        { }

        public Contact(int aContactId, string aContactName, string aContactEmail, string aContactPhone, string aCompanyName, string aJobFunc, string aJobLevel, string aIndustry, string aEmployees, string aRevenue, string aZipCode, string aCountry, string aState, string aCity)
        {
            this.ContactId = aContactId;
            this.ContactName = aContactName;
            this.ContactEmail = aContactEmail;
            this.ContactPhone = aContactPhone;
            this.CompanyName = aCompanyName;
            this.JobFunc = aJobFunc;
            this.JobLevel = aJobLevel;
            this.Industry = aIndustry;
            this.Employees = aEmployees;
            this.Revenue = aRevenue;
            this.ZipCode = aZipCode;
            this.Country = aCountry;
            this.State = aState;
            this.City = aCity;
        }

        public Contact(int aContactId, string aContactName, string aContactEmail, string aContactPhone, string aCompanyName, string aJobFunc, string aJobLevel, string aIndustry, string aEmployees, string aRevenue, string aZipCode, string aCountry, string aState)
            : this(aContactId,aContactName,aContactEmail,aContactPhone, aCompanyName, aJobFunc, aJobLevel,aIndustry,aEmployees,aRevenue,aZipCode,aCountry,aState, "n/a")
        { }

        public Contact(int aContactId, string aContactName, string aContactEmail, string aContactPhone, string aCompanyName,string aJobFunc, string aJobLevel, string aIndustry, string aEmployees, string aRevenue, string aZipCode, string aCountry)
            : this(aContactId, aContactName, aContactEmail, aContactPhone, aCompanyName, aJobFunc, aJobLevel, aIndustry, aEmployees, aRevenue, aZipCode, aCountry, "n/a", "n/a")
        { }

        public Contact(int aContactId, string aContactName, string aContactEmail, string aContactPhone,string aCompanyName, string aJobFunc, string aJobLevel, string aIndustry, string aEmployees, string aRevenue, string aZipCode)
            : this(aContactId, aContactName, aContactEmail, aContactPhone, aCompanyName, aJobFunc, aJobLevel, aIndustry, aEmployees, aRevenue, aZipCode, "n/a", "n/a", "n/a")
        { }

        public Contact(int aContactId, string aContactName, string aContactEmail, string aContactPhone,string aCompanyName, string aJobFunc, string aJobLevel, string aIndustry, string aEmployees, string aRevenue)
            : this(aContactId, aContactName, aContactEmail, aContactPhone, aCompanyName, aJobFunc, aJobLevel, aIndustry, aEmployees, aRevenue, "n/a", "n/a", "n/a", "n/a")
        { }

        public Contact(int aContactId, string aContactName, string aContactEmail, string aContactPhone,string aCompanyName, string aJobFunc, string aJobLevel, string aIndustry, string aEmployees)
            : this(aContactId, aContactName, aContactEmail, aContactPhone, aCompanyName,aJobFunc, aJobLevel, aIndustry, aEmployees, "n/a", "n/a", "n/a", "n/a", "n/a")
        { }

        public Contact(int aContactId, string aContactName, string aContactEmail, string aContactPhone, string aCompanyName, string aJobFunc, string aJobLevel, string aIndustry)
            : this(aContactId, aContactName, aContactEmail, aContactPhone, aCompanyName, aJobFunc, aJobLevel, aIndustry, "n/a", "n/a", "n/a", "n/a", "n/a", "n/a")
        { }

        public Contact(int aContactId, string aContactName, string aContactEmail, string aContactPhone, string aCompanyName, string aJobFunc, string aJobLevel)
            : this(aContactId, aContactName, aContactEmail, aContactPhone, aCompanyName,aJobFunc, aJobLevel, "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a")
        { }

        public Contact(int aContactId, string aContactName, string aContactEmail, string aContactPhone, string aCompanyName,string aJobFunc)
            : this(aContactId, aContactName, aContactEmail, aContactPhone, aCompanyName, aJobFunc, "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a")
        { }

        public Contact(int aContactId, string aContactName, string aContactEmail, string aContactPhone, string aCompanyName)
            : this(aContactId, aContactName, aContactEmail, aContactPhone, aCompanyName,"n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a")
        { }

        public Contact(int aContactId, string aContactName, string aContactEmail)
            : this(aContactId, aContactName, aContactEmail, "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a")
        { }

        public Contact(int aContactId, string aContactName)
            : this(aContactId, aContactName, "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a")
        { }

        public Contact(int aContactId)
           : this(aContactId, "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a")
        { }

    }
}