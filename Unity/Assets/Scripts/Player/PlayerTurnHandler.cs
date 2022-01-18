using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTurnHandler : MonoBehaviour
{
    public Player player;

    public void HandleTurn()
    {
        player.RuntimeHealth -= 10;
    }
}
