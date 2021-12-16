using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "New Enemy", menuName = "Enemy")]
public class Enemy: ScriptableObject
{
    public new string name;

    public Sprite artWork;
    public int maxHealth;
    public int health;
    public int damage;
}