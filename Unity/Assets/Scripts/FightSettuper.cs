using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FightSettuper : MonoBehaviour
{

    public FightManager fightManager;
    public PlayerDisplay player;
    public List<EnemyDisplay> enemies;
    public Stack stack;
    public Button endTurnButton;

    public void Start()
    {
        Setup();
    }

    private void Setup()
    {
        SetupPlayer();
        SetupEnemies();
        SetupFightManager();
    }

    private void SetupPlayer()
    {
        Instantiate(player, Vector2.zero - Vector2.right * 2, Quaternion.identity);
    }

    private void SetupEnemies()
    {
        for (int i = 0; i < enemies.Count; i++)
        {
            Instantiate(enemies[i], Vector2.zero - Vector2.left * (i + 1) * 3, Quaternion.identity);
        }
    }

    private void SetupFightManager()
    {
        fightManager.Setup(player, enemies, stack, endTurnButton);
    }
}