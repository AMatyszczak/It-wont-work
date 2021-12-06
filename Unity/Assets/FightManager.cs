using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FightManager : MonoBehaviour
{
    private Stack stack;
    private Tossed tossed;
    private Player player;

    public FightManager(Stack stack, Tossed tossed, Player player) 
    {
        this.stack = stack;
        this.tossed = tossed;
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
