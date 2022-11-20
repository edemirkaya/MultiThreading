using MailCourier.MailProvider.Base;
using MailCourier.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailCourier.MailProvider
{
    public class SmtpProvider : BaseProvider
    {
        public override async Task Send(MailObject mailobject)
        {
            //SEND EMAIL
            await Task.Delay(10);
            LogManager.Default.Log($"Smtp has send to{mailobject.To}");
        }
    }
}
