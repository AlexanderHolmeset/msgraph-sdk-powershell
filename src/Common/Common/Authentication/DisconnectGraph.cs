﻿// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------
namespace Microsoft.Graph.Common.Authentication
{
    using Microsoft.Graph.Common.Models;
    using System;
    using System.Management.Automation;
    [Cmdlet(VerbsCommunications.Disconnect, "Graph")]
    public class DisconnectGraph: PSCmdlet
    {
        protected override void BeginProcessing()
        {
            base.BeginProcessing();
        }

        protected override void EndProcessing()
        {
            base.EndProcessing();
        }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();

            AuthConfig authConfig = SessionState.PSVariable.GetValue(Constants.GraphAuthConfigId) as AuthConfig;

            if (authConfig == null)
                ThrowTerminatingError(
                    new ErrorRecord(new System.Exception("No application to sign out from."), Guid.NewGuid().ToString(), ErrorCategory.InvalidArgument, null));

            Authentication.Logout(authConfig);
        }

        protected override void StopProcessing()
        {
            base.StopProcessing();
        }
    }
}
