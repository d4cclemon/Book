using ConsoleApp.Extentions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp.Services
{
    public class Service
    {
        public IEnumerable<object> ConvertObjects(string[] args)
        {
            var list = args.Select(x => int.Parse(x));
            return null;
        }
    }
}
