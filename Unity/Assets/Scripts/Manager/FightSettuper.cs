using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FightSettuper : MonoBehaviour
{

    public FightManager fightManager;
    public PlayerTurnHandler player;
    public List<EnemyTurnHandler> enemies;
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
        Instantiate(player, CalculatePlayerSetupPosition(), Quaternion.identity);
    }

    private void SetupEnemies()
    {
        for (int i = 0; i < enemies.Count; i++)
        {
            Instantiate(enemies[i], CalculateEnemySetupPosition(i), Quaternion.identity);
        }
    }

    private void SetupFightManager()
    {
        fightManager.Setup(player, enemies, stack, endTurnButton);
    }

    private Vector3 CalculatePlayerSetupPosition()
    {
        return Vector2.zero - Vector2.right * 2;
    }

    private Vector3 CalculateEnemySetupPosition(int index)
    {
        return Vector2.zero - Vector2.left * (index + 1) * 3;
    }
}