using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class EmailManager
    {
        private string from { get; set; }
        private string to { get; set; }
        private string subject { get; set; }
        private string body { get; set; }

        public EmailManager From(string from)
        {
            this.from = from;
            return this;
        }
        public EmailManager To (string to)
        {
            this.to = to;
            return this;
        }
        public EmailManager Subject (string subject)
        {
            this.subject = subject;
            return this;
        }
        public EmailManager Body (string body)
        {
            this.body = body;
            return this;
        }
    }
}
