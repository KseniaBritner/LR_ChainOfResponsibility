using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CofResponsibility
{
    internal class IntButtonHelpHandler : ButtonHelpHandler
    {
        public IntButtonHelpHandler(HelpHandler helpHandler)
            : base(helpHandler) { }
        protected override bool IsRequest(HelpRequest request)
        {
            if (request == null)
            {
                throw new ArgumentNullException(nameof(request));
            }
            return char.IsDigit(request.Sign);
        }
        protected override string HelpString(HelpRequest request)
        {
            if (request == null)
            {
                throw new ArgumentNullException(nameof(request));
            }
            return $"Цифра '{request.Sign}'";
        }
        protected override string DefaultHelpString(HelpRequest request)
        {
            if (request == null)
            {
                throw new ArgumentNullException(nameof(request));
            }
            return "Нажмите на число";
        }
    }
}
