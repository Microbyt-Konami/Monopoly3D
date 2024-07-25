using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

[CreateAssetMenu(fileName = "Board", menuName = "Monopoly3D/Board", order = 1)]
public class Board : ScriptableObject
{
    //public AvenueDictionary avenues;
    public Avenue[] avenues;
}
