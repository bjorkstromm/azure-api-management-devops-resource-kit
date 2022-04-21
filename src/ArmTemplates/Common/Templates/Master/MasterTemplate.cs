// --------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation. All rights reserved.
//  Licensed under the MIT License.
// --------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Azure.Management.ApiManagement.ArmTemplates.Common.Templates.Abstractions;
using Newtonsoft.Json;

namespace Microsoft.Azure.Management.ApiManagement.ArmTemplates.Common.Templates.Master
{
    public class MasterTemplate
    {
        [JsonProperty(PropertyName = "$schema", Order = -10)]
        public string Schema { get; set; }

        public string ContentVersion { get; set; }
        public TemplateResource[] Resources { get; set; }
    }
}
