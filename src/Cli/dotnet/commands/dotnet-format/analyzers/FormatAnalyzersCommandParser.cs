﻿// Copyright (c) .NET Foundation and contributors. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
//

using System.CommandLine;

using static Microsoft.DotNet.Tools.Format.FormatCommandCommon;

namespace Microsoft.DotNet.Tools.Format
{
    internal static class FormatAnalyzersCommandParser
    {
        private static readonly FormatAnalyzersHandler s_analyzerHandler = new();

        private static readonly Command Command = ConstructCommand();

        public static Command GetCommand()
        {
            return Command;
        }

        private static Command ConstructCommand()
        {
            var command = new Command("analyzers", LocalizableStrings.Run_3rd_party_analyzers__and_apply_fixes)
            {
                DiagnosticsOption,
                SeverityOption,
            };
            command.AddCommonOptions();
            return command;
        }
    }
}
