using UnityEngine;
using UnityEngine.UI;
public class Enemy: MonoBehaviour
{
    public Slider slider;

    private int _health = 100;
    public int Health {
        get => _health;
        set {
            _health = value;
            slider.value = value;
        }
    }

    private int _damage = 5;

    public int Damage {
        get => _damage;
        set => _damage = value;
    }

    public void HandleTurn()
    {
        this.Health -= 10;
    }
}