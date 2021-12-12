using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hand : MonoBehaviour
{
    public static Hand instance;
    void Awake()
    {
        if (instance != null)
        {
            Debug.LogWarning("Wykryto wiêcen ni¿ 1 REKE w grze.A grasz jednorêkim bandyt¹.");
            return;
        }
        instance = this;
    }

    //Funkcja dodana by ³atwiej manipulowaæ reka, gdy zagrywamy, dobieramy, ulepszamy karty mo¿emy j¹ u¿yæ by zmieniæ coœ w rêce.
    public delegate void OnDeckChanged();
    public OnDeckChanged onDeckChangedCallback;

    //maksymalny rozmiar rêki
    public int maxSize = 8;

    //lista przechowuj¹ca wszystkie karty w rêce(karta jest obiektem Card z ewentualnymi parametrami)
    public List<Card> cards = new List<Card>();


    //Funkcja do dodawania kart z drowu co ture  / innych kart / etc.
    public void Add(Card card)
    {
        if (!card.isDefaultCard)
        {
            if (cards.Count >= maxSize)
            {
                Debug.LogWarning("Przekroczono maxymalny rozmiar reki karty nalezy odrzuciæ.");
                return;
            }
            cards.Add(card);
            if (onDeckChangedCallback != null)
                onDeckChangedCallback.Invoke();

        }
    }


    //Funkcje do usuwania kart z reki (pozniej dodanie do stosu odrzyconych)
    //
    public void Remove(Card card)
    {
        if (cards.Count <= 0)
        {
            Debug.LogWarning("Brak kart do usuniecia");
            return;
        }
        cards.Remove(card);
    }

}
