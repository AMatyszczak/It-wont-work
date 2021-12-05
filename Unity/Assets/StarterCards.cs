using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Klasa do tworzenia startowego decku
public class StarterCards : MonoBehaviour
{

    public Card karta1;
    // Start is called before the first frame update
    void Start()
    {
        Deck.instance.Add(karta1);
    }


}
