﻿using PHS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PHS.Interfaces
{
   public interface ISubcounty
    {
        List<JDropdown> Get(int CountyID);
    }
}
