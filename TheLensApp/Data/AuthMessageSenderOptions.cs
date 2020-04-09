using System;
namespace TheLensApp.Data
{
    public class AuthMessageSenderOptions
    {
        public AuthMessageSenderOptions()
        {
        }

        public string SendGridUser { get; set; }
        public string SendGridKey { get; set; }
    }
}
