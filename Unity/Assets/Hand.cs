using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//Klasa odpowiedzialna za nasz� r�ke(deck moze byc tylko 1 w trakcie rozgrywki mo�na dobiera� u�ywa� odrzuca� karty oraz je modyfikowa�.
//ma przechowywac ich stan ,ma maksymalny oraz minimalny rozmiar(0).
//ma przechowywa� miejsce gdzie wy�wietlaj� si� karty w zale�no�ci od ilo�ci kart w r�ce
public class Hand : MonoBehaviour
{

    //Instancja dodana by mozna �atwo z ka�dego miejsca rozgrywki odwo�a� si� do reki, Ogranicza tez tworzenie wiekszej ilosc r�k co by�oby nieporz�dane.
    public static Hand instance;
    void Awake()
    {
        if (instance != null)
        {
            Debug.LogWarning("Wykryto wi�cen ni� 1 REKE w grze.A grasz jednor�kim bandyt�.");
            return;
        }
        instance = this;
    }

    //Funkcja dodana by �atwiej manipulowa� reka, gdy zagrywamy, dobieramy, ulepszamy karty mo�emy j� u�y� by zmieni� co� w r�ce.
    public delegate void OnDeckChanged();
    public OnDeckChanged onDeckChangedCallback;

    //maksymalny rozmiar r�ki
    public int maxSize = 8;
    //minimalny rozmiar decky
    public int minSize = 0;

    //lista przechowuj�ca wszystkie karty w r�ce(karta jest obiektem Card z ewentualnymi parametrami)
    public List<Card> cards = new List<Card>();


    //Funkcja do dodawania kart z drowu co ture  / innych kart / etc.
    public void Add(Card card)
    {
        if (!card.isDefaultCard)
        {
            if (cards.Count >= maxSize)
            {
                Debug.LogWarning("Przekroczono maxymalny rozmiar reki karty nalezy odrzuci�.");
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
            Debug.LogWarning("Przekroczono minimalny rozmiar reki nie ma czego usuwa� ?.");
            return;
        }
        cards.Remove(card);
    }

}
