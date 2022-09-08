using System.Threading.Tasks;

namespace MaloNj.Playground.WebApi.Core.Interfaces;

public interface IEmailSender
{
  Task SendEmailAsync(string to, string from, string subject, string body);
}
