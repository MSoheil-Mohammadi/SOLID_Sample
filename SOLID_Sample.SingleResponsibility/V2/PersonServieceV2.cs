using SOLID_Sample.SingleResponsibility.Data;
using SOLID_Sample.SingleResponsibility.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Sample.SingleResponsibility.V2;
public class PersonServieceV2
{
    public async void AddToRepository(PersonV2 person)
    {
        StudentsRepositoryV2.People.Add(person);
    }

    private string SendEmail(string email, string subject, string message)
    {
        return $"email sender :{email}, email subject{subject}, email message{message}";
    }
}
