﻿using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Xamarin.iOS.Binding.Transformer
{
    [XmlRoot(ElementName = "using")]
    public class ApiUsings
    {
        [XmlElement(ElementName = "using", Order = 0)]
        public List<ApiUsing> Items { get; set; }

        public ApiUsings()
        {
            Items = new List<ApiUsing>();
        }
    }
    [XmlRoot(ElementName = "using")]
    public class ApiUsing
    {
        [XmlAttribute(attributeName:"name")]
        public string Name { get; set; }

    }
}