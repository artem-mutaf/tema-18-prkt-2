﻿using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tema18prkt2
{
    class DOCHandler:AbstractHandler
    {
        public override void Open()
        {
            Console.WriteLine("Open document format DOC");
        }
        public override void Create()
        {
            Console.WriteLine("Create document format DOC");
        }
        public override void Change()
        {
            Console.WriteLine("Change document format DOC");
        }
        public override void Save()
        {
            Console.WriteLine("Save document format DOC");
        }
    }
}
