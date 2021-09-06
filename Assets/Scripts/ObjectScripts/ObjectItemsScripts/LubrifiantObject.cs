using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Lubrifiant Object", menuName = "ItemSystem/Items/Lubrifiant")]
public class LubrifiantObject : ItemObject
{
    private void Awake()
    {
        if (itemTag.Count == 0)
        {
            itemTag.Add(ItemTag.Lubrifiant);
        }

        if (itemStackType.Count == 0)
        {
            itemStackType.Add(ItemStackType.StackLiquide);
        }
    }
}
