using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FightManager: MonoBehaviour
{ 
    private TurnState currentTurnState;
    private List<EnemyTurnHandler> enemies;
    private PlayerTurnHandler player;
    private Stack stack;
    private Button endTurnButton;
    

    public void Setup(PlayerTurnHandler player, List<EnemyTurnHandler> enemies, Stack stack, Button endTurnButton)
    {
        currentTurnState = TurnState.START;
        this.enemies = enemies;
        this.stack = stack;
        this.player = player;
        this.endTurnButton = endTurnButton;
        ListenOnEndTurnButtonClick();
    }

    public void HandleTurnChange(TurnState turnState)
    {
        this.currentTurnState = turnState;
        switch (turnState)
        {
            case TurnState.PLAYERTURN:
                player.HandleTurn();
                break;
            case TurnState.ENEMYTURN:
                FulfillEnemiesActions();
                HandleTurnChange(TurnState.PLAYERTURN);
                break;
        }
    }

    private void FulfillEnemiesActions()
    {
        enemies.ForEach(enemy => { enemy.HandleTurn(); });
    }

    private void ListenOnEndTurnButtonClick()
    {
        endTurnButton.onClick.AddListener(delegate { 
            HandleTurnChange(TurnState.ENEMYTURN); 
        });
    }
}