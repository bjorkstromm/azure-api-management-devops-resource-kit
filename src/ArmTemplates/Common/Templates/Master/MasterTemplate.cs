// --------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation. All rights reserved.
//  Licensed under the MIT License.
// --------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Azure.Management.ApiManagement.ArmTemplates.Common.Templates.Abstractions;

namespace Microsoft.Azure.Management.ApiManagement.ArmTemplates.Common.Templates.Master
{
    public class MasterTemplate
    {
        public string ContentVersion { get; set; }
        public TemplateResource[] Resources { get; set; }
    }
}
