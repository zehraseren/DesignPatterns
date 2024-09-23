using DP.ChainOfResponsibility.DAL;
using DP.ChainOfResponsibility.Models;

namespace DP.ChainOfResponsibility.ChainOfResponsibility
{
    public class AssistantManager : Employee
    {
        public override void ProcessRequest(CustomerProcessViewModel request)
        {
            Context context = new Context();
            if (request.Amount <= 150000)
            {
                CustomerProcess customerProcess = new CustomerProcess();
                customerProcess.Amount = request.Amount.ToString();
                customerProcess.Name = request.Name;
                customerProcess.EmployeeName = "Şube Müdür Yardımcısı - Melike Öztürk";
                customerProcess.Description = "Para çekme işlemi onaylandı, müşterinin talep ettiği tutar ödendi.";
                context.CustomerProcesses.Add(customerProcess);
                context.SaveChanges();
            }
            else if (NextApprover != null)
            {
                CustomerProcess customerProcess = new CustomerProcess();
                customerProcess.Amount = request.Amount.ToString();
                customerProcess.Name = request.Name;
                customerProcess.EmployeeName = "Şube Müdür Yardımcısı - Melike Öztürk";
                customerProcess.Description = "Para çekme tutarı, şube müdür yardımcısının günlük ödeyebileceği limiti aştığı için işlem şube müdürüne yönlendirildi.";
                context.CustomerProcesses.Add(customerProcess);
                context.SaveChanges();
                NextApprover.ProcessRequest(request);
            }
        }
    }
}
