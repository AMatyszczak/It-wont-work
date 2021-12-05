using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//Klasa odpowiedzialna za nasz deck (deck moze byc tylko 1 w trakcie rozgrywki mozna  do niego dodawac/  uwuwac z niego karty / karty w nim moga byc zmodyfikowane
//ma przechowywac ich stan ma maksymalny oraz minimalny rozmiar.
public class Deck : MonoBehaviour
{

    //Instancja dodana by mozna �atwo z ka�dego miejsca rozgrywki odwo�a� si� do decku, Ogranicza tez tworzenie wiekszej ilosc deckow co by�oby nieporz�dane.
    public static Deck instance;
    void Awake()
    {
        if (instance != null)
        {
            Debug.LogWarning("Wykryto wi�cen ni� 1 DECK w grze.");
            return;
        }
        instance = this;
    }

    //Funkcja dodana by �atwiej manipulowa� deckiem, gdy dodajemy, usuwamy, ulepszamy karte mo�emy j� u�y� by zmieni� co� w decku.
    public delegate void OnDeckChanged();
    public OnDeckChanged onDeckChangedCallback;

    //maksymalny rozmiar decku
    public int maxSize = 15;
    //minimalny rozmiar decky
    public int minSize = 5;

    //lista przechowuj�ca wszystkie karty w decku(karta jest obiektem Card z ewentualnymi parametrami)
    public List<Card> cards = new List<Card>();


    //Funkcja do dodawania kart z decky z eventow / po walce / sklep etc.
    public void Add(Card card)
    {
        if (!card.isDefaultCard)
        {
            if (cards.Count >= maxSize)
            {
                Debug.LogWarning("Przekroczono maxymalny rozmiar decku nie mozna dodac karty.");
                return;
            }
            cards.Add(card);
            if (onDeckChangedCallback != null)
            onDeckChangedCallback.Invoke();
            
        }
    }


    //Funkcje do usuwania kart z decku z evenetow / sklep etc.
    public void Remove(Card card)
    {
        if (cards.Count <= minSize)
        {
            Debug.LogWarning("Przekroczono minimalny rozmiar decku nie mozna usunac karty.");
            return;
        }
        cards.Remove(card);
    }

}
