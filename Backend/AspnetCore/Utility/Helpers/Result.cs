using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Utility.Helpers
{
    public class Result<T>
    {
        public T Data { get; set; }

        public bool HasError => Errors.Any();

        public int StatusCode { get; set; }

        public string Message { get; set; }
        public List<string> Errors { get; set; } = new List<string>();


    }
}
