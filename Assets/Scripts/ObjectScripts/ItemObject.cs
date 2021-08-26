using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static Colons;

public abstract class ItemObject : ScriptableObject
{
    public enum ItemTag
    {
        Combustible,
        Lubrifiant,
        Nourriture,
        Perissable
    }
    public enum ItemStackType
    {
        StackSolide,
        StackLiquide,
        StackPoudre,
        StackPoche
    }

    public Object itemImage;
    public List<ItemTag> itemTag = new List<ItemTag>();
    public List<ItemStackType> itemStackType = new List<ItemStackType>();

    [TextArea (10, 15)]
    public string itemDescription;


    public List<ColonStats> colonStatToAffect = new List<ColonStats>();
    public int statModifier;

    public float efficacity;

    public int power;
    public float duration;
}