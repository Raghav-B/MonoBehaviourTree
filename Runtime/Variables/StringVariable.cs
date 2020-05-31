﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MBT
{
    [AddComponentMenu("")]
    public class StringVariable : Variable<string>
    {
        
    }

    [System.Serializable]
    public class StringReference : VariableReference<StringVariable>
    {
        
    }
}