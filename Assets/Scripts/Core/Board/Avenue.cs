using System;
using UnityEngine;

[CreateAssetMenu(fileName = "Avenue", menuName = "Monopoly3D/Avenue", order = 1)]
[Serializable]
public class Avenue : ScriptableObject
{    
    public Material blockMaterial;
    public string Title;
    public int Money;
}
