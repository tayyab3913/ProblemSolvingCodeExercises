using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerItems
{
    Gun[] playerGuns = new Gun[4];
    int inventorycounter = 0;

    public void AddGunToInventory(Gun.GunsType type)
    {
        playerGuns[inventorycounter] = GunsFactory.GetGunOfType(type);
        inventorycounter++;
    }

    public Gun EquipItem(int i)
    {
        return playerGuns[i];
    }
}
