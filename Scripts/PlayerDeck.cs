using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PlayerDeck : MonoBehaviour
{

    public List<Card> container = new List<Card>();
    public int x;
    public static int deckSize;
    public List<Card> deck = new List<Card>();
    public static List<Card> staticDeck = new List<Card>();

    public GameObject cardInDeck1;
    public GameObject cardInDeck2;
    public GameObject cardInDeck3;
    public GameObject cardInDeck4;

    public GameObject CardToHand;
    public GameObject[] Clones;
    public GameObject Hand;



    // Start is called before the first frame update
    void Start()
    {
        deckSize = deck.Count;

        x = 0;
        for(int i = 0; i < deckSize; i++)
        {
            x = Random.Range(1,5);
            deck[i] = CardDatabase.cardList[x];
        }

        StartCoroutine(StartGame());

    }

    // Update is called once per frame
    void Update()
    {

        staticDeck = deck;

        if(deckSize < (4))
        {
            cardInDeck1.SetActive(false);
        }
        if(deckSize < (3))
        {
            cardInDeck2.SetActive(false);
        }
        if(deckSize < (2))
        {
            cardInDeck3.SetActive(false);
        }
        if(deckSize < (1))
        {
            cardInDeck4.SetActive(false);
        }
    }

    IEnumerator StartGame() // Draws "StartingCardsDrawn" cards at the start of the game
    {
        int StartingCardsDrawn = 6; 
        for(int i = 1; i <= StartingCardsDrawn; i++)
        {
            yield return new WaitForSeconds(1); // Starts the game by drawing 4 cards
            //NEW
            //AudioSource.PlayOneShot(draw, lf);
            //NEW
            Instantiate(CardToHand, transform.position, transform.rotation);
        }
    }

    public void Shuffle()
    {
        for(int i = 0; i < deckSize; i++)
        {
            container[0] = deck[i];
            int randomIndex = Random.Range(i, deckSize);
            deck[i] = deck[randomIndex];
            deck[randomIndex] = container[0];
        }
    }
}
