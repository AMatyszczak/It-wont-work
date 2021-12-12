using UnityEngine;
using UnityEngine.UI;

public class Player: MonoBehaviour {

    public Slider slider;

    private int _health = 100;
    public int Health
    {
        get => _health;
        set
        {
            _health = value;
            slider.value = value;
        }
    }

    private int _resources = 1;
    private int Resources
    {
        get => _resources;
        set => _resources = value;
    }


    public void HandleTurn()
    {
        this.Resources += 1;
    }
}