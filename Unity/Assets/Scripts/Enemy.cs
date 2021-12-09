using UnityEngine;
using UnityEngine.UI;


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

    public void HandleTurn()
    {
        this.Health--;
    }
}