﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenLeaf.Core
{
    public interface INavigationService
    {
        void GoForward();
        void GoBack();
        bool Navigate(string page);
    }
}