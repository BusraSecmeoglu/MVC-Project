using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVCApplication.LanguageProvider.Interface;

namespace MVCApplication.LanguageProvider.Classes
{
    public class ChangeMessageProvider
    {

        public IMessageProvider SetLanguage(int languageId)
        {
            if (languageId == 1)
            {
                return new GermanMessageProvider();

            }
            else if (languageId == 2)
            {
                return new TurkhishMessageProvider();
            }
            else
            {
                throw new Exception("UnDefined language");
            }
        }
    }
}