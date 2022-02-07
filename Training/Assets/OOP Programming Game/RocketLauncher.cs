using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketLauncher : Gun
{
    public RocketLauncher() : base(1, 50, "RocketLauncher")
    {

    }
    void Shoot()
    {
        Debug.Log("RocketLauncher Shot");
    }
}
