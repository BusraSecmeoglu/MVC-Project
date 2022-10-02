using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVCApplication.LanguageProvider.Interface;

namespace MVCApplication.LanguageProvider.Classes
{
    public class TurkhishMessageProvider : IMessageProvider
    {
        public const string Contact = "İletişim";
        public const string AboutUs = "Hakkımızda";
        public const string Home = "Anasayfa";
    }
}