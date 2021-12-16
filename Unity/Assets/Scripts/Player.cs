using System;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "New Player", menuName = "Player")]

public class Player: ScriptableObject, ISerializationCallbackReceiver
{

    public int InitialHealth;
    [NonSerialized]
    public int RuntimeHealth;
    public int Resources;

    public void OnAfterDeserialize()
    {
        RuntimeHealth = InitialHealth;
    }

    public void OnBeforeSerialize() { }
}