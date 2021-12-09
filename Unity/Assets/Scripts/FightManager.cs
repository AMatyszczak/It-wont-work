using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FightManager : MonoBehaviour
{
    private Stack stack;
    private Player player;

    public FightManager(Stack stack, Player player) 
    {
        this.stack = stack;
        this.player = player;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
