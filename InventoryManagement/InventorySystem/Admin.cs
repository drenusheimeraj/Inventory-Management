﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InventorySystem
{
    class Admin : User
    {
        public override UserRole getRole()
        {
            return UserRole.Admin;
        }
    }
}
