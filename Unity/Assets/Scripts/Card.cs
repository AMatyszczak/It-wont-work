using UnityEngine;


//Umozliwia nam szybkie dodawania obiektow Kart przez PPM na Projekcie
[CreateAssetMenu(fileName ="New Card",menuName ="Card")]

//Obiekt Karty posiada wspolna ceche wszytkich kart
//Nazwa , cena , poziom karty , czy Bazowa, czy zagrywalna.
public class Card : ScriptableObject
{
    public string cardName = "CARD";
    public int cost = 0;
    public int level = 1;
    public bool isDefaultCard = false;
    public bool isPlayable = true;
    public Sprite cardSprite = null;
    public string description = "NULL";
}
