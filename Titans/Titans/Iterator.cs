﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Titans
{
    interface Iterator
    {
        bool hasNext();
        bool isEmpty();
        void Add();
        void Remove();
    }
}
