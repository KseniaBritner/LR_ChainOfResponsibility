using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CofResponsibility
{
    public class ButtonHelpHandler : HelpHandler
    {
        public ButtonHelpHandler(HelpHandler helpHandler)
            : base(helpHandler) { }
        protected override bool IsRequest(HelpRequest request)
        {
            if (request == null)
            {
                throw new ArgumentNullException(nameof(request));
            }
            char[] icons = { '+', '-', '*', ':' };
            return char.IsDigit(request.Sign) || icons.Contains(request.Sign);
        }
        protected override string HelpString(HelpRequest request)
        {
            if (request == null)
            {
                throw new ArgumentNullException(nameof(request));
            }
            return $"Символ '{request.Sign}'";
        }
        protected override string DefaultHelpString(HelpRequest request)
        {
            if (request == null)
            {
                throw new ArgumentNullException(nameof(request));
            }
            return "Кнопка вне калькулятора";
        }
    }
}
