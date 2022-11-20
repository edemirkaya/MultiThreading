using MailCourier.MailProvider;
using MailCourier.MailProvider.Base;
using MailCourier.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailCourier
{
    public static  class MailProviderFactory
    {
        public static BaseProvider CreateProvider(MailProviderType mailProviderType)
        {
            if (mailProviderType == MailProviderType.Smtp)
                return new SmtpProvider();

            return null;
        }
    }
}
