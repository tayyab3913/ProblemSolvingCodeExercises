using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotGun : Gun
{
    public ShotGun() : base(3, 25, "ShotGun")
    {

    }
    void Shoot()
    {
        Debug.Log("Shotgun Shot");
    }
}
