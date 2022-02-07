using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class GunsFactory
{
    public static Gun GetGunOfType(Gun.GunsType type)
    {
        switch (type)
        {
            case Gun.GunsType.Ak47:
                return new Ak47();
            case Gun.GunsType.MachineGun:
                return new MachineGun();
            case Gun.GunsType.RocketLauncher:
                return new RocketLauncher();
            case Gun.GunsType.ShotGun:
                return new RocketLauncher();
            case Gun.GunsType.Smg:
                return new Smg();
            default:
                return new Gun();
        }
    }
}
