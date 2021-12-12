using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FightManager: MonoBehaviour
{ 
    public TurnState currentTurnState;
    public List<Enemy> enemies;
    public Player player;
    public Stack stack;

    public FightManager(Player player, List<Enemy> enemies, Stack stack)
    {
        currentTurnState = TurnState.START;
        this.enemies = enemies;
        this.stack = stack;
    }

    public void Start()
    {
        //StartPlayerTurn();
    }

    private void StartPlayerTurn()
    {
        this.currentTurnState = TurnState.PLAYERTURN;
        HandlePlayerTurn();
    }

    private void StartEnemyTurn()
    {
        this.currentTurnState = TurnState.ENEMYTURN;
        HandleEnemyTurn();
    }

    private void HandleEnemyTurn()
    {
        FulfillEnemiesActions();
        StartPlayerTurn();
    }

    private void HandlePlayerTurn()
    {
        player.HandleTurn();
        StartEnemyTurn();
    }

    private void FulfillEnemiesActions()
    {
        enemies.ForEach(enemy => { enemy.HandleTurn(); });
    }
}