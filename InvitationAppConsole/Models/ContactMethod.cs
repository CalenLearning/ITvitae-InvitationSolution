﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvitationAppConsole.Models
{
    [Flags]
    enum ContactMethod
    {
        Mail = 1,
        Email = 2,
        Phone = 4,
        Whatsapp = 8
    }
}
