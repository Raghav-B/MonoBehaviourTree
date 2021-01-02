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
    public class StringReference : VariableReference<StringVariable, string>
    {
        public StringReference(VarRefMode mode = VarRefMode.EnableConstant)
        {
            SetMode(mode);
        }
        
        public StringReference(string defaultConstant)
        {
            useConstant = true;
            constantValue = defaultConstant;
        }

        public string Value
        {
            get
            {
                return (useConstant)? constantValue : this.GetVariable().Value;
            }
            set
            {
                if (useConstant)
                {
                    constantValue = value;
                }
                else
                {
                    this.GetVariable().Value = value;
                }
            }
        }
    }
}