using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class Storage : MonoBehaviour
{
    public string storageName = "Storage01";

    public InputField storageInput;

    public int woodAmount;
    public int stoneAmount;
    public int bottleAmout;

    public void ModifyStorageName()
    {
        storageName = storageInput.text;
    }
}
