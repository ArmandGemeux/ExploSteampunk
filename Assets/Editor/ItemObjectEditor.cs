using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(ItemObject), true)]
public class ItemObjectEditor : Editor
{
    public SerializedProperty

        spriteProperty,

        itemImage_Prop,
        itemDescription_Prop,

        itemStackType_Prop,
        itemTag_Prop,

        colonStatToAffect_Prop,
        statModifier_Prop,

        efficacity_Prop,

        power_Prop,
        duration_Prop;

    private void OnEnable()
    {
        itemImage_Prop = serializedObject.FindProperty("itemImage");

        itemDescription_Prop = serializedObject.FindProperty("itemDescription");

        itemStackType_Prop = serializedObject.FindProperty("itemStackType");
        itemTag_Prop = serializedObject.FindProperty("itemTag");

        colonStatToAffect_Prop = serializedObject.FindProperty("colonStatToAffect");
        statModifier_Prop = serializedObject.FindProperty("statModifier");

        efficacity_Prop = serializedObject.FindProperty("efficacity");

        power_Prop = serializedObject.FindProperty("power");
        duration_Prop = serializedObject.FindProperty("duration");
    }

    public override void OnInspectorGUI()
    {
        // Setup the SerializedProperties
        EditorStyles.textField.wordWrap = true;

        ItemObject itemObject = (ItemObject)target;

        /*
        itemObject.itemDescription = EditorGUILayout.TextField(itemObject.itemDescription, GUILayout.Width(350), GUILayout.MinHeight(50), GUILayout.MaxHeight(150));*/

        EditorGUILayout.PropertyField(itemImage_Prop, new GUIContent("Icone  :"));
        Texture2D myTexture = AssetPreview.GetAssetPreview(itemObject.itemImage);
        GUILayout.Label(myTexture, GUILayout.Height(64), GUILayout.Width(64));

        //EditorGUILayout.ObjectField(itemObject.itemImage, typeof(Sprite), allowSceneObjects: false, GUILayout.Width(32), GUILayout.Height(32));

        EditorGUILayout.PropertyField(itemDescription_Prop, new GUIContent("Description :"));

        EditorGUILayout.PropertyField(itemTag_Prop);

        /*EditorGUILayout.BeginHorizontal();
        EditorGUILayout.PrefixLabel("Icone");
        itemImage_Prop = (Sprite)EditorGUILayout.ObjectField(itemImage_Prop, typeof(Sprite), allowSceneObjects: false);
        EditorGUILayout.EndHorizontal();*/

        for (int i = 0; i < itemObject.itemTag.Count; i++)
        {
            switch (itemObject.itemTag[i])
            {
                case ItemObject.ItemTag.Combustible:
                    EditorGUILayout.IntSlider(power_Prop, 0, 100, new GUIContent("Power :"));
                    EditorGUILayout.Slider(duration_Prop, 0, 100, new GUIContent("Duration :"));
                    EditorGUILayout.Space(15);
                    break;

                case ItemObject.ItemTag.Lubrifiant:
                    EditorGUILayout.Slider(efficacity_Prop, 0, 100, new GUIContent("Efficacity :"));
                    EditorGUILayout.Space(15);
                    break;

                case ItemObject.ItemTag.Nourriture:
                    EditorGUILayout.IntSlider(statModifier_Prop, 0, 10, new GUIContent("Modifier Value :"));
                    EditorGUILayout.Space(15);
                    //EditorGUILayout.EnumPopup("Stat to affect", cs);
                    break;
            }
        }

        EditorGUILayout.PropertyField(itemStackType_Prop);

        serializedObject.ApplyModifiedProperties();
    }
}