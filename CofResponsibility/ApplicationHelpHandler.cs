﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CofResponsibility
{
    public class ApplicationHelpHandler : HelpHandler
    {
        public ApplicationHelpHandler(HelpHandler helpHandler)
            : base(helpHandler) { }
        protected override bool IsRequest(HelpRequest request)
        {
            if (request == null)
            {
                throw new ArgumentNullException(nameof(request));
            }
            return true;
        }
        protected override string HelpString(HelpRequest request)
        {
            if (request == null)
            {
                throw new ArgumentNullException(nameof(request));
            }
            return "Кнопка вне калькулятора";
        }
        protected override string DefaultHelpString(HelpRequest request)
        {
            if (request == null)
            {
                throw new ArgumentNullException(nameof(request));
            }
            return "Привет! Перед тобой базовый калькулятор!";
        }
    }
}
