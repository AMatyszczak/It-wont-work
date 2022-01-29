using UnityEngine;
using UnityEngine.UI;

public class PlayerDisplay : MonoBehaviour
{
    public Player player;
    public Slider healthSlider;

    public void Start()
    {
        healthSlider.maxValue = player.InitialHealth;
        healthSlider.value = player.InitialHealth;
    }

    public void Update()
    {
        healthSlider.value = player.RuntimeHealth;
    }
}
