using DP.Decorator.DAL;

namespace DP.Decorator.DecoratorPattern
{
    public class Decorator : ISendMessage
    {
        private readonly ISendMessage _sendMessage;

        public Decorator(ISendMessage sendMessage)
        {
            _sendMessage = sendMessage;
        }

        virtual public void SendMessage(Message message)
        {
            message.MessageReceiver = "Everybody";
            message.MessageSender = "Admin";
            message.MessageSubject = "Toplantı";
            message.MessageContent = "Merhaba bu bir toplantı mesajıdır.";
            _sendMessage.SendMessage(message);
        }
    }
}
