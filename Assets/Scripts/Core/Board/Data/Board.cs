using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

[CreateAssetMenu(fileName = "Board", menuName = "Monopoly3D/Board", order = 1)]
public class Board : ScriptableObject
{
    public Avenue[] avenues;

    public Avenue GetAvenue(string name)
    {
        foreach (var avenue in avenues)
            if (string.Equals(avenue.name, name, System.StringComparison.InvariantCultureIgnoreCase))
                return avenue;

        return null;
    }
}
