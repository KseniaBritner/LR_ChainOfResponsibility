using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CofResponsibility
{
    public class OperationButtonHelpHandler : ButtonHelpHandler
    {
        public OperationButtonHelpHandler(HelpHandler helpHandler)
            : base(helpHandler) { }
        protected override bool IsRequest(HelpRequest request)
        {
            if (request == null)
            {
                throw new ArgumentNullException(nameof(request));
            }
            char[] icons = { '+', '-', '*', ':' };
            return icons.Contains(request.Sign);
        }
        protected override string HelpString(HelpRequest request)
        {
            if (request == null)
            {
                throw new ArgumentNullException(nameof(request));
            }
            return $"Операция '{request.Sign}'";
        }
        protected override string DefaultHelpString(HelpRequest request)
        {
            if (request == null)
            {
                throw new ArgumentNullException(nameof(request));
            }
            return "Нажмите на операцию";
        }
    }
}
