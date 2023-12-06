using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CofResponsibility
{
    public abstract class HelpHandler
    {
        private HelpHandler _helpHandler;
        protected abstract bool IsRequest(HelpRequest request);
        protected abstract string HelpString(HelpRequest request);
        protected abstract string DefaultHelpString(HelpRequest request);
        public HelpHandler(HelpHandler helpHandler)
        {
            _helpHandler = helpHandler;
        }
        public virtual string Handler(HelpRequest request)
        {
            if (request == null)
            {
                throw new ArgumentNullException(nameof(request));
            }
            if (IsRequest(request))
            {
                return HelpString(request);
            }
            if (_helpHandler != null)
            {
                return _helpHandler.Handler(request);
            }
            return DefaultHelpString(request);
        }
        
    }
}
