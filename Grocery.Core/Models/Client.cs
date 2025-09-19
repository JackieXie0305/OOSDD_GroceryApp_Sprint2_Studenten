
using System.Net.Mail;

namespace Grocery.Core.Models
{
    public partial class Client : Model
    {
        public string emailAddress { get; set; } = string.Empty;
        public string password { get; set; } = string.Empty;
        public Client(int id, string name, string emailAddress, string password) : base(id, name)
        {
            this.emailAddress = emailAddress;
            this.password = password;
        }
    }
}
