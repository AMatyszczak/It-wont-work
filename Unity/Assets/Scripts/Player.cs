using UnityEngine;
using UnityEngine.UI;

public class Player: MonoBehaviour {

    public Slider slider;
    private int Health {
        get => Health;
        set {
            Health = value;
            slider.value = value;
        }
    }

    private int Resources {
        get => Resources;
        set => Resources = value;
    }

    public Player(int health, int resources)
    {
        this.Health = health;
        this.Resources = resources;
    }

    public void HandleTurn()
    {
        this.Resources += 1;
    }
}