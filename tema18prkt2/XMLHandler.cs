﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tema18prkt2
{
    
    class XMLHandler:AbstractHandler
    {
        public override void Open()
        {
            Console.WriteLine("Open document format XML");
        }
        public override void Create()
        {
            Console.WriteLine("Create document format XML");
        }
        public override void Change()
        {
            Console.WriteLine("Change document format XML");
        }
        public override void Save()
        {
            Console.WriteLine("Save document format XML");
        }
    }
}
