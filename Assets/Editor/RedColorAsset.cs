using UnityEngine;
using UnityEditor;

public class RedColorAsset
{
    [MenuItem("Assets/Create/RedColor")]
    public static void CreateAsset()
    {
        ScriptableObjectUtility.CreateAsset<RedColor>();
    }
}