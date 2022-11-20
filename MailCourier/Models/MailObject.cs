using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailCourier.Models
{
    public  class MailObject
    {
        public string To { get; set; }
        public string From { get; set; } = "ertugrulldemirkaya@gmail.com";
        public MailProviderType ProviderType { get; set; }
    }

    public enum MailProviderType
    {
        Smtp
    }
}
