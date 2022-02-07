using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ak47 : Gun
{
    public Ak47() : base(5, 20, "Ak47")
    {

    }

    void Shoot()
    {
        Debug.Log("Ak47 Shot");
    }
}
