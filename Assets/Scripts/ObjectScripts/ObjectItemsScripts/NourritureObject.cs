using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Nourriture Object", menuName = "ItemSystem/Items/Nourriture")]
public class NourritureObject : ItemObject
{
    private void Awake()
    {
        if (itemTag.Count == 0)
        {
            itemTag.Add(ItemTag.Nourriture);
        }

        if (itemStackType.Count == 0)
        {
            itemStackType.Add(ItemStackType.StackSolide);
        }
    }
}