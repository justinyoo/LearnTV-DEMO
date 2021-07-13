using Microsoft.Azure.WebJobs.Extensions.OpenApi.Core.Configurations;

using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace FunctionApp3
{
    public class OpenApiCustomUIOptions : DefaultOpenApiCustomUIOptions
    {
        public OpenApiCustomUIOptions(Assembly assembly)
            : base(assembly)
        {
        }

        // Declare if you want to change the custom CSS file name.
        public override string CustomStylesheetPath { get; } = "dist.my-custom.css";

        // Declare if you want to change the custom JavaScript file name.
        public override string CustomJavaScriptPath { get; } = "dist.my-custom.js";
    }
}
