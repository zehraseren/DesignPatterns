using DP.ChainOfResponsibility.DAL;
using DP.ChainOfResponsibility.Models;

namespace DP.ChainOfResponsibility.ChainOfResponsibility
{
    public class Manager : Employee
    {
        public override void ProcessRequest(CustomerProcessViewModel request)
        {
            Context context = new Context();
            if (request.Amount <= 250000)
            {
                CustomerProcess customerProcess = new CustomerProcess();
                customerProcess.Amount = request.Amount.ToString();
                customerProcess.Name = request.Name;
                customerProcess.EmployeeName = "Şube Müdürü - Hatice Sarı";
                customerProcess.Description = "Para çekme işlemi onaylandı, müşterinin talep ettiği tutar ödendi.";
                context.CustomerProcesses.Add(customerProcess);
                context.SaveChanges();
            }
            else if (NextApprover != null)
            {
                CustomerProcess customerProcess = new CustomerProcess();
                customerProcess.Amount = request.Amount.ToString();
                customerProcess.Name = request.Name;
                customerProcess.EmployeeName = "Şube Müdürü - Hatice Sarı";
                customerProcess.Description = "Para çekme tutarı, şube müdürünün günlük ödeyebileceği limiti aştığı için işlem bölge müdürüne yönlendirildi.";
                context.CustomerProcesses.Add(customerProcess);
                context.SaveChanges();
                NextApprover.ProcessRequest(request);
            }
        }
    }
}
