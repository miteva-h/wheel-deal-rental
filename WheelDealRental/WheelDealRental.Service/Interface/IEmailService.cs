using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WheelDealRental.Domain.DomainModels;

namespace WheelDealRental.Service.Interface
{
    public interface IEmailService
    {
        Task SendEmailAsync(List<EmailMessage> allMails);
    }
}
