﻿//  
// Copyright (c) 2017 Nick Rimmer. All rights reserved.  
// Licensed under the MIT License. See LICENSE file in the project root for full license information.  
//

using ApiAi.Internal.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiAi.Internal.Enums
{
    internal enum ActionsEnum
    {
        [AlternativeValue("query")]
        Query,

        [AlternativeValue("entities")]
        Entities
    }
}
