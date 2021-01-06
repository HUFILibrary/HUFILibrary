using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebHUFILibrary.Models
{
    public class SearchModel
    {
        public string _key { get; set; }
        public string _value { get; set; }

        public SearchModel(string key, string value)
        {
            _key = key;
            _value = value;
        }
    }
}