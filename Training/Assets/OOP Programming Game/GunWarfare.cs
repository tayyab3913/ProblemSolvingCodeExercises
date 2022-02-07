using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunWarfare : MonoBehaviour
{
    Player firstPlayer = new Player();
    Player secondPlayer = new Player();
    Player[] allPlayers;

    void Start()
    {
        allPlayers = new Player[] { firstPlayer, secondPlayer };
        
        firstPlayer.InitializePlayer(100, "Atif");
        firstPlayer.AssignGun(GunsFactory.GetGunOfType(Gun.GunsType.Ak47));

        secondPlayer.InitializePlayer(150, "Aslam");
        secondPlayer.AssignGun(GunsFactory.GetGunOfType(Gun.GunsType.MachineGun));

        DisplayGameData();

        firstPlayer.Attack(secondPlayer);
        firstPlayer.AddItemToInventory(Gun.GunsType.RocketLauncher);
        firstPlayer.AddItemToInventory(Gun.GunsType.ShotGun);

        DisplayGameData();

        firstPlayer.Attack(secondPlayer);
        secondPlayer.Attack(firstPlayer);
        secondPlayer.AddItemToInventory(Gun.GunsType.Smg);
        secondPlayer.AddItemToInventory(Gun.GunsType.RocketLauncher);
        secondPlayer.EquipItemWithId(0);
        secondPlayer.Attack(firstPlayer);
        firstPlayer.EquipItemWithId(1);
        secondPlayer.Attack(firstPlayer);
        firstPlayer.Attack(secondPlayer);

        DisplayGameData();
    }

    void DisplayGameData()
    {
        for(int i = 0; i<allPlayers.Length; i++)
        {
            allPlayers[i].DisplayPlayerInfo();
        }
    }
}
