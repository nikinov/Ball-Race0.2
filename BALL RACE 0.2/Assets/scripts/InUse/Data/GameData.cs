using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class GameData
{
    public int Pink;
    private GameData playerData;
    private GameData player;

    public GameData (Player player)
    {
        Pink = player.BeachSkin;
    }
}
