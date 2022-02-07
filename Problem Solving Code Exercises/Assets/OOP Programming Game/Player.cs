using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player
{
    Gun activeGun;
    PlayerItems playerItems = new PlayerItems();

    int health;
    string playerName;

    public void InitializePlayer(int health, string playerName)
    {
        this.health = health;
        this.playerName = playerName;
    }

    public void DisplayPlayerInfo()
    {
        Debug.Log("Player Name: " + playerName + " Health: " + health + " Active: " + activeGun.ReturnGunName());
    }

    public void AssignGun(Gun gun)
    {
        activeGun = gun;
    }

    public void Attack(Player enemy)
    {
        activeGun.Shoot(enemy);
    }

    public void GetDamage(int value)
    {
        health -= value;
        IsKilled();
    }

    void IsKilled()
    {
        if(health<0)
        {
            Debug.Log(playerName + " is killed.");
        }
    }

    public void EquipItemWithId(int i)
    {
        activeGun = playerItems.EquipItem(i);
    }

    public void AddItemToInventory(Gun.GunsType type)
    {
        playerItems.AddGunToInventory(type);
    }

}
