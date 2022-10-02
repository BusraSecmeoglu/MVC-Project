using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVCApplication.LanguageProvider.Interface;

namespace MVCApplication.LanguageProvider.Classes
{
    public class MessageProvider
    {
        IMessageProvider _IMessageProvider;
        public MessageProvider()
        {
            _IMessageProvider = new TurkhishMessageProvider();
        }

        public void SetLanguage(IMessageProvider messageProvider)
        {
            _IMessageProvider = messageProvider;
        }

    }
}