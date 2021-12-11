using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardDataBase : MonoBehaviour
{
        

    public static List<Card> cardList =new List<Card>();
    // Start is called before the first frame update
    void Awake()
    {
        cardList.Add(new Card(0,"Slash",2,1,true,"opis1",Resources.Load<Sprite>("card_img/karta1")));
        cardList.Add(new Card(1, "Slash2", 2, 1, true, "opis2", Resources.Load<Sprite>("card_img/karta2")));
    }
}
