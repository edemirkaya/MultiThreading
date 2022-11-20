using MailCourier.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailCourier.MailProvider.Base
{
    public abstract class BaseProvider
    {
        public int Port { get; set; }
        public string ServerHostName { get; set; } = "smtp.google.com";
        public abstract Task Send(MailObject mailobject);
    }
}
