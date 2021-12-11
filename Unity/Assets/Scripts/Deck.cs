using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Deck : MonoBehaviour
{

    public List<Card> deck = new List <Card>();
 

    public int cardID;
    public int dataBaseID;
    public string cardName;
    public int cost;
    public int level;
    public bool isPlayable;
    public string description;
    public Sprite cardSprite;


    public Text nameText;
    public Text costText;
    public Text descriptionText;


    public Sprite thisSprite;
    public Image thisImage;


    void Start()
    {
        deck[0] = CardDataBase.cardList[dataBaseID];
        cardID = deck[0].id;
        cardName = deck[0].cardName;
        cost = deck[0].cost;
        level = deck[0].level;
        isPlayable = deck[0].isPlayable;
        description = deck[0].description;
        cardSprite = deck[0].cardSprite;
        nameText.text = "" + cardName;
        costText.text = "" + cost;
        descriptionText.text = "" + description;
    }

    
    void Update()
    {

    }
}
