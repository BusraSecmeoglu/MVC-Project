using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVCApplication.LanguageProvider.Interface;

namespace MVCApplication.LanguageProvider.Classes
{
    public class GermanMessageProvider : IMessageProvider
    {
        public const string Contact = "Kontakt";
        public const string AboutUs = "Über uns";
        public const string Home = "Startseite";
    }
}