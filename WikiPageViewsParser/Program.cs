﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WikiPageViewsParser
{
    class Program
    {
        static void Main(string[] args)
        {
            String str = WikiDigger.QuotedPrintable.EncodeQuotedPrintable("Крым");
           Tasks.DoExtraction(new DateTime(2013, 1, 1), new DateTime(2016, 5, 1));
        }
    }
}
