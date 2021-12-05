using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//Klasa odpowiedzialna za nasz¹ rêke(deck moze byc tylko 1 w trakcie rozgrywki mo¿na dobieraæ u¿ywaæ odrzucaæ karty oraz je modyfikowaæ.
//ma przechowywac ich stan ,ma maksymalny oraz minimalny rozmiar(0).
//ma przechowywaæ miejsce gdzie wyœwietlaj¹ siê karty w zale¿noœci od iloœci kart w rêce
public class Hand : MonoBehaviour
{

    //Instancja dodana by mozna ³atwo z ka¿dego miejsca rozgrywki odwo³aæ siê do reki, Ogranicza tez tworzenie wiekszej ilosc r¹k co by³oby nieporz¹dane.
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
    //minimalny rozmiar decky
    public int minSize = 0;

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
        if (cards.Count <= minSize)
        {
            Debug.LogWarning("Przekroczono minimalny rozmiar reki nie ma czego usuwaæ ?.");
            return;
        }
        cards.Remove(card);
    }

}
