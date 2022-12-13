namespace Erp2.Services
{
    public class SendGridEmailService :IEmailService
    {
        public void To(string to, string message, string topic)
        {
            Console.WriteLine($"{to}-{topic}{message}");
        }
        public void Send(string to, string message, string topic)
        {
            To(to, message, topic);
        }
    }
}
