using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car
{
    string carName;
    int health;
    int speed;
    int damagePower;
    int shield;
    int posX;
    int posY;

    void InitializeCar(string carName, int health, int speed, int damagePower, int shield, int posX, int posY)
    {
        this.carName = carName;
        this.health = health;
        this.speed = speed;
        this.damagePower = damagePower;
        this.shield = shield;
        this.posX = posX;
        this.posY = posY;
    }

    public void MoveForward(int distance)
    {
        posX += distance;
    }

    void Attack(Car opponent)
    {
        opponent.getDamage(damagePower);
    }

    void getDamage(int attackPower)
    {
        health += attackPower;
        Destroy();
    }

    void Destroy()
    {
        if(health<0)
        {
            Debug.Log("This car has blasted: " + carName);
        }
    }

    void DisplayCarData()
    {
        Debug.Log("Name: " + carName);
        Debug.Log("Health: " + health);
        Debug.Log("Damage Power: " + damagePower);
        Debug.Log("Position X: " + posX);
        Debug.Log("Position Y: " + posY);
    }
}
