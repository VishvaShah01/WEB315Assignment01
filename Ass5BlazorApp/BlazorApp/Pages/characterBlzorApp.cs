using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace BlazorApp
{
    public class characterBlzorApp
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Profession { get; set; }
        public bool IsFictional { get; set; }
    }
}