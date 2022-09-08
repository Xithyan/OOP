using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Functions
    {
        Address address = new();

        public static List<Contact> PrivateContacts = new List<Contact>();
        public static List<Contact> BusinessContacts = new List<Contact>();
        public static List<Contact> WalletAddress = new List<Contact>();
        public static List<Contact> Contacts = PrivateContacts.Union(BusinessContacts).ToList();

        //Street
        //Housenumber
        //ZipCode
        //City
        //Province
        //Country
        //FirstName
        //MiddleName
        //LastName
        //Birthday

        public static void InputFirstName(string input, Contact contact = null)
        {
            if (contact == null)
                contact = new();

            contact.FirstName = input;
        }
        public static void InputMiddleName(string input, Contact contact)
        {
            contact.MiddleName = input;
        }
        public static void InputLastName(string input, Contact contact)
        {
            contact.LastName = input;
        }
        public static void InputBirthday(DateTime input, Contact contact)
        {
            contact.BirthDay = input;
        }
        public static void InputBusiness(string input, Contact contact)
        {
            contact.BusinessName = input;
        }
        public static void InputStreet(string input, Address address)
        {
            address.Street = input;
        }
        public static void InputHousenumber(string input, Address address)
        {
            address.Housenumber = input;
        }
        public static void InputZipCode(string input, Address address)
        {
            address.ZipCode = input;
        }
        public static void InputCity(string input, Address address)
        {
            address.City = input;
        }
        public static void InputProvince(string input, Address address)
        {
            address.Province = input;
        }
        public static void InputCountry(string input, Address address)
        {
            address.Country = input;
        }
        public static void InputWallet(string input, WalletAddress walletAddress)
        {
            walletAddress.Link = input;
        }
        public static void InputWalletPassword(string input, WalletAddress walletAddress)
        {
            walletAddress.Password = input;
        }
    }
}
