using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable] //Lock the class

public class Stat
{
    [SerializeField] //Makes it possible to change the private int in the unity inpsctor
    private int baseValue;

    public int GetValue()
    {
        return baseValue;
    }

}
