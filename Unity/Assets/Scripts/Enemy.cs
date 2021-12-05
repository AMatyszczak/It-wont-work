using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;


public class Enemy: MonoBehaviour
{

    public Slider slider;

    private int Health {
        get => Health;
        set {
            Health = value;
            slider.value = value;
        }
    }
    private int Damage {
        get => Damage;
        set => Damage = value;
    }

    public Enemy(int health, int damage)
    {
        this.Health = health;
        this.Damage = damage;
    }
}