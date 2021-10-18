using rife_rafe_backend.Common.Models;

namespace rife_rafe_backend.Helpers
{
    public interface IMailHelper
    {
        Response SendMail(string to, string subject, string body);
    }
}
