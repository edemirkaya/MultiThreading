using MailCourier.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailCourier
{
    public  class FakeDataCreator
    {
        public static IEnumerable<MailObject> GetSmtpMails(int number)
        {
           return GetMails(number, MailProviderType.Smtp);
        }

        public static IEnumerable<MailObject> GetMails(int number, MailProviderType? mailProviderType = null)
        {
            Bogus.Faker<MailObject> Faker = new Bogus.Faker<MailObject>()
                .RuleFor(i => i.To, y => y.Internet.Email())
                .RuleFor(i => i.ProviderType, y => !mailProviderType.HasValue
                ? y.PickRandom<MailProviderType>()
                : mailProviderType);

            return Faker.Generate(number);
        }
    }
}
