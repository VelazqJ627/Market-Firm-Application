using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Oracle.DataAccess.Client;

namespace MarketingFirm.Models
{
    public class DbCon
    {
        private List<Contact> aListOfContact = new List<Contact>();

        public List<Contact> GetContact()
        {

            //Oracle is a tool/technology which is the license to the DB
            OracleConnection aConnection = new OracleConnection();
            //basic sql
            string aSQL = "SELECT ContactName,ContactEmail,ContactPhone,CompanyName,JobFunc,JobLevel,Industry,Employees,Revenue,ZipCode,Country,CState,City  FROM CONTACT";
            //@"provider etc = depends on your driver ;Data SOurce=connection to the database string 
            aConnection.ConnectionString = @"Data Source=localhost:1521/Contact; User Id=System; Password=140885;";
            aConnection.Open();
            //aCommand tells the database what to do
            OracleCommand aCommand = aConnection.CreateCommand();
            //which is to do the sql statement
            aCommand.CommandText = aSQL;

            //run sql and run it into aReader variable which turns it into a spreadsheet
            OracleDataReader aReader = aCommand.ExecuteReader();

            // Read the data and store it in a list
            while (aReader.Read())
            {

                //int aContactId = Convert.ToInt32((long)(aReader)["CONTACTID"]);
                //string aContactName = (string)aReader["ContactName"];

                string aContactName = "n/a";
                if (aReader["ContactName"] != System.DBNull.Value)
                { aContactName = (string)aReader["ContactName"]; }


                string aContactEmail = "n/a";
                if (aReader["ContactEmail"] != System.DBNull.Value)
                { aContactEmail = (string)aReader["ContactEmail"]; }

                // string aContactPhone = (string)aReader["ContactPhone"];
                string aContactPhone = "n/a";
                if (aReader["ContactPhone"] != System.DBNull.Value)
                { aContactPhone = (string)aReader["ContactPhone"]; }

                //string aCompanyName = (string)aReader["CompanyName"];
                string aCompanyName = "n/a";
                if (aReader["CompanyName"] != System.DBNull.Value)
                { aCompanyName = (string)aReader["CompanyName"]; }


                //string aJobFunc = (string)aReader["JobFunc"];
                string aJobFunc = "n/a";
                if (aReader["JobFunc"] != System.DBNull.Value)
                { aJobFunc = (string)aReader["JobFunc"]; }

                //string aJobLevel = (string)aReader["JobLevel"];
                string aJobLevel = "n/a";
                if (aReader["JobLevel"] != System.DBNull.Value)
                { aJobLevel = (string)aReader["JobLevel"]; }

                //string aIndustry = (string)aReader["Industry"];
                string aIndustry = "n/a";
                if (aReader["Industry"] != System.DBNull.Value)
                { aIndustry = (string)aReader["Industry"]; }

                //string aEmployees = (string)aReader["EMPLOYEES"];
                string aEmployees = "n/a";
                if (aReader["Employees"] != System.DBNull.Value)
                { aEmployees = (string)aReader["Employees"]; }

                //string aRevenue = (string)aReader["REVENUE"];
                string aRevenue = "n/a";
                if (aReader["Revenue"] != System.DBNull.Value)
                { aRevenue = (string)aReader["Revenue"]; }

                //string aZipCode = (string)aReader["ZipCode"];
                string aZipCode = "n/a";
                if (aReader["ZipCode"] != System.DBNull.Value)
                { aZipCode = (string)aReader["ZipCode"]; }

               // string aCountry = (string)aReader["Country"];
                string aCountry = "n/a";
                if (aReader["Country"] != System.DBNull.Value)
                { aCountry = (string)aReader["Country"]; }

                //string aState = (string)aReader["CState"];
                string aState = "n/a";
                if (aReader["CState"] != System.DBNull.Value)
                { aState = (string)aReader["CState"]; }

               // string aCity = (string)aReader["City"];
                string aCity = "n/a";
                if (aReader["City"] != System.DBNull.Value)
                { aCity = (string)aReader["City"]; }


                Contact aContact = new Contact();

               // aContact.ContactId = aContactId;
                aContact.ContactName = aContactName;
                aContact.ContactEmail = aContactEmail;
                aContact.ContactPhone = aContactPhone;
                aContact.CompanyName = aCompanyName;
                aContact.JobFunc = aJobFunc;
                aContact.JobLevel = aJobLevel;
                aContact.Industry = aIndustry;
                aContact.Employees = aEmployees;
                aContact.Revenue = aRevenue;
                aContact.ZipCode = aZipCode;
                aContact.Country = aCountry;
                aContact.State = aState;
                aContact.City = aCity;

                aListOfContact.Add(aContact);
            }
            aConnection.Close();

            return aListOfContact;
        }

        public bool InsertContact(string ContactName, string ContactEmail, string ContactPhone, string CompanyName, string JobFunc, string JobLevel, string Industry, string Employees, string Revenue, string ZipCode, string Country, string State, string City)
        {
        
            bool aFlag = false;
            string aSQL = "INSERT INTO Contact (ContactName,ContactEmail,ContactPhone,CompanyName,JobFunc,JobLevel,Industry,Employees,Revenue,ZipCode,Country,CState,City )";
            aSQL = aSQL + "VALUES('" + ContactName + "', '" + ContactEmail + "','" + ContactPhone + "','" + CompanyName + "', '" + JobFunc + "','" + JobLevel + "','" + Industry + "','" + Employees + "', '" + Revenue + "','" + ZipCode + "','" + Country + "', '" + State + "','" + City + "') ";

            //oledb is a tool/technology which is the license to the DB
            OracleConnection aConnection = new OracleConnection();
            //CHANGE ME
            aConnection.ConnectionString = @"Data Source=localhost:1521/Contact; User Id=System; Password=140885;";
            aConnection.Open();
            //aCommand tells the database what to do
            OracleCommand aCommand = aConnection.CreateCommand();
            //which is to do the sql statement
            aCommand.CommandText = aSQL;
            aCommand.ExecuteNonQuery();

            aFlag = true;
            aConnection.Close();
            return aFlag;
        }

        public bool UpdateContact(string ContactName, string ContactEmail, string ContactPhone, string CompanyName, string JobFunc, string JobLevel, string Industry, string Employees, string Revenue, string ZipCode, string Country, string State, string City)
        {
            bool aFlag = false;
  

            string aSQL = "UPDATE CONTACT SET ContactName = '" + ContactName + "', ContactEmail = '" + ContactEmail + "', CompanyName = '" + CompanyName + "' , JobFunc = '" + JobFunc + "' , Industry = '" + Industry + "' , Employees = '" + Employees + "' , Revenue = '" + Revenue + "' , ZipCode = '" + ZipCode + "', Country = '" + Country + "', CState = '" + State + "' , City = '" + City + "'Where ContactPhone = '" + ContactPhone + "' ";
            //oledb is a tool/technology which is the license to the DB


            OracleConnection aConnection = new OracleConnection();
            aConnection.ConnectionString = @"Data Source=localhost:1521/Contact; User Id=System; Password=140885;";

            aConnection.Open();
            //aCommand tells the database what to do
            OracleCommand aCommand = aConnection.CreateCommand();
            //which is to do the sql statement
            aCommand.CommandText = aSQL;
            aCommand.ExecuteNonQuery();

            aFlag = true;
            aConnection.Close();
            return aFlag;
        }


    }
}