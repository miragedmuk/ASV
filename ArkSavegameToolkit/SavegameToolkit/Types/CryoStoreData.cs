﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SavegameToolkit.Types
{
    public class CryoStoreData
    {

        public GameObject ParentObject { get; set; }
        public int StoreDataIndex { get; set; } = 1;
        public long Offset { get; set; }
        public byte[] Data { get; set; }

    }
}
