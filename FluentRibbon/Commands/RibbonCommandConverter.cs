using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.SharePoint.WebControls;

namespace FluentRibbon.Commands
{
    /// <summary>
    /// This helps to convert FluentRibbonCommand class instances to SPRibbonCommand instances.
    /// Note: We are using FluentRibbonCommand to allow SharePoint sandboxed solutions.
    /// </summary>
    internal class RibbonCommandConverter
    {
        public static IEnumerable<IRibbonCommand> Convert(IEnumerable<FluentRibbonCommand> commands)
        {
            return commands.Select<FluentRibbonCommand, IRibbonCommand>(c => new SPRibbonCommand(
                c.Id,
                c.HandlerStatement,
                c.EnabledStatement));
        }

    }
}
