using DP.Decorator.DAL;

namespace DP.Decorator.DecoratorPattern
{
    public class CreateNewMessage : ISendMessage
    {
        Context context = new Context();
        public void SendMessage(Message message)
        {
            context.Messages.Add(message);
            context.SaveChanges();
        }
    }
}
