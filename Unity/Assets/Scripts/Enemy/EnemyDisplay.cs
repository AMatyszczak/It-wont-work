using UnityEngine;
using UnityEngine.UI;


public class EnemyDisplay : MonoBehaviour
{
    public Enemy enemy;

    public Slider healthSlider;

    public void Start()
    {
        healthSlider.maxValue = enemy.maxHealth;
        healthSlider.value = enemy.health;
    }

    public void HandleTurn()
    {

    }
}