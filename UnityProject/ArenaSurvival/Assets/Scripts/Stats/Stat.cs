using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable] //Lock the class

public class Stat
{
    [SerializeField] //Makes it possible to change the private int in the unity inpsctor
    private int baseValue;

    private List<int> modifiers = new List<int>();

    public int GetValue()
    {

        int finalValue = baseValue;
        modifiers.ForEach(x => finalValue += x);

        return finalValue;
    }

    public void AddModifier (int modifier)
    {
        if (modifier != 0)
        {
            modifiers.Add(modifier);
        }
    }

    public void RemoveModifier (int modifer)
    {
        if (modifer != 0)
        {
            modifiers.Remove(modifer);
        }
    }

}
