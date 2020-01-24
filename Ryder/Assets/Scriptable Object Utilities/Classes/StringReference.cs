using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class StringReference
{
    public bool UseConstant = false;
    public string ConstantValue;
    public StringVariable Variable;

    public string Value
    {
        get { return UseConstant ? ConstantValue : Variable.Value; }
    }
}
