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
    public static class IncorrectXML
    {
        public static string file = "IncorrectXML.xml";

        #region Fields
        private static string password;   
        private static string email;
        private static XmlDocument document;
        #endregion

        static IncorrectXML()
        {
            if (!System.IO.File.Exists(file)) { throw new Exception("Problem: settings file not found: " + file); }
            document = new XmlDocument();
            document.Load(file);
        }

        #region Properties


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

   

 
        #endregion
    }
 
}
