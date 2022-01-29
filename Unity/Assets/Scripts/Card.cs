using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
[System.Serializable]





public class Card 
{


    public int id;
    public string cardName;
    public int cost;
    public int level;
    public bool isPlayable;
    public string description;
    public Sprite cardSprite;



    public Card()
    {

    }

    public Card(int id, string cardName, int cost, int level, bool isPlayable, string description , Sprite cardSprite)
    {
        this.id = id;
        this.cardName = cardName;
        this.level = level;
        this.isPlayable = isPlayable;
        this.description = description;
        this.cardSprite = cardSprite;

    }


}
