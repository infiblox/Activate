using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlinesService.Helpers
{
    public static class ConfigurationHelper
    {
        public static IConfiguration config;
        public static void Initialize(IConfiguration Configuration)
        {
            config = Configuration;
        }
    }
}
