using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment3_T1907A.Models;
namespace Assignment3_T1907A.ViewModels
{
    class ViewModel
    {
        public static List<Mail> MailList = new List<Mail>();
        public ViewModel()
        {
            if (MailList.Count == 0)
            {
                MailList.Add(new Mail("tung1@gmail.com",
                "subject", "description"));
                MailList.Add(new Mail("tung2@gmail.com",
                    "subject", "description"));
            }

        }

        public List<Mail> Mails
        {
            get => MailList;
        }
    }
}
