﻿// Copyright (c) .NET Foundation and contributors. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
//

using System.CommandLine;

using static Microsoft.DotNet.Tools.Format.FormatCommandCommon;

namespace Microsoft.DotNet.Tools.Format
{
    internal static class FormatStyleCommandParser
    {
        private static readonly FormatStyleHandler s_styleHandler = new();

        private static readonly Command Command = ConstructCommand();

        public static Command GetCommand()
        {
            return Command;
        }

        private static Command ConstructCommand()
        {
            var command = new Command("style", LocalizableStrings.Run_code_style_analyzers_and_apply_fixes)
            {
                DiagnosticsOption,
                SeverityOption,
            };
            command.AddCommonOptions();
            return command;
        }
    }
}
