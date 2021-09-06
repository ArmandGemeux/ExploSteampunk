using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Combustible Object", menuName = "ItemSystem/Items/Combustible")]
public class CombustibleObject : ItemObject
{
    private void Awake()
    {
        if (itemTag.Count == 0)
        {
            itemTag.Add(ItemTag.Combustible);
        }

        if (itemStackType.Count == 0)
        {
            itemStackType.Add(ItemStackType.StackSolide);
        }
    }
}