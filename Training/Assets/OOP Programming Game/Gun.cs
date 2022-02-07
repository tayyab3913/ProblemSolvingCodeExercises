using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun
{
    int remainingBullets;
    int magazineSize;
    int gunPower;
    string gunName;

    public Gun()
    {
        this.magazineSize = 5;
        this.gunPower = 10;
        this.gunName = "Gun";
    }

    public Gun(int magazineSize, int gunPower, string gunName)
    {
        this.magazineSize = magazineSize;
        this.gunPower = gunPower;
        this.gunName = gunName;
    }
    
    public virtual void Shoot(Player enemy)
    {
        enemy.GetDamage(gunPower);
        remainingBullets--;
    }

    public void Reload()
    {
        remainingBullets = magazineSize;
    }

    public enum GunsType
    {
        Ak47, Smg, ShotGun, RocketLauncher, MachineGun
    }

    public virtual string ReturnGunName()
    {
        return gunName;
    }
}
