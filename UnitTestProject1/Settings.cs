using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Serialization;



namespace MaslavyevAM
{
    public static class Settings
    {
        public static string file = "Settings.xml";

        #region Fields
        private static string baseUrl;
        private static string email;
        private static string password;
        private static string number;
        private static XmlDocument document;
        #endregion

        static Settings()
        {
            if (!System.IO.File.Exists(file)) { throw new Exception("Problem: settings file not found: " + file); }
            document = new XmlDocument();
            document.Load(file);
        }

        #region Properties
        public static string BaseUrl
        {
            get
            {
                if (baseUrl == null)
                {
                    XmlNode node = document.DocumentElement.SelectSingleNode("BaseUrl");
                    baseUrl = node.InnerText;
                }
                return baseUrl;
            }
        }


        public static string Email
        {
            get
            {
                if (password == null)
                {
                    XmlNode node = document.DocumentElement.SelectSingleNode("Email");
                    email = node.InnerText;
                }
                return email;
            }
        }


        public static string Password
        {
            get
            {
                if (password == null)
                {
                    XmlNode node = document.DocumentElement.SelectSingleNode("Password");
                    password = node.InnerText;
                }
                return password;
            }
        }


        public static string Number
        {
            get
            {
                if (password == null)
                {
                    XmlNode node = document.DocumentElement.SelectSingleNode("Number");
                    number = node.InnerText;
                }
                return number;
            }
        }

        public static string TextEmail
        {
            get
            {
                if (password == null)
                {
                    XmlNode node = document.DocumentElement.SelectSingleNode("TextField");
                    email = node.InnerText;
                }
                return email;
            }
        }

        #endregion
    }
}
