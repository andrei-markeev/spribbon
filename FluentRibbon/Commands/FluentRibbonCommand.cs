using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FluentRibbon.Commands
{
    internal class FluentRibbonCommand
    {
        public string EnabledStatement { get; private set; }
        public string HandlerStatement { get; private set; }
        public string Id { get; private set; }

        public FluentRibbonCommand(string id, string handlerStatement, string enabledStatement)
        {
            Id = id;
            HandlerStatement = handlerStatement;
            EnabledStatement = enabledStatement;
        }

    }
}
