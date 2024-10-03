using DP.Decorator.DAL;
using Microsoft.AspNetCore.Mvc;
using DP.Decorator.DecoratorPattern;

namespace DP.Decorator.Controllers
{
    public class DefaultController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Message message)
        {
            CreateNewMessage createNewMessage = new CreateNewMessage();
            createNewMessage.SendMessage(message);
            return View();
        }

        [HttpGet]
        public IActionResult Index2()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index2(Message message)
        {
            CreateNewMessage createNewMessage = new CreateNewMessage();
            EncryptoBySubjectDecorator subject = new EncryptoBySubjectDecorator(createNewMessage);
            subject.SendMessageByEncryptoSubject(message);
            return View();
        }

        [HttpGet]
        public IActionResult Index3()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index3(Message message)
        {
            CreateNewMessage createNewMessage = new CreateNewMessage();
            SubjectIdDecorator subjectIdDecorator = new SubjectIdDecorator(createNewMessage);
            subjectIdDecorator.SendMessageIdSubject(message);
            return View();
        }
    }
}
