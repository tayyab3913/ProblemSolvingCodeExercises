using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MachineGun : Gun
{
    public MachineGun() : base(10, 15, "MachinGun")
    {

    }
    void Shoot()
    {
        Debug.Log("Machine Gun Shot");
    }
}
