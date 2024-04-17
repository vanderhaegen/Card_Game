using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class DisplayCard : MonoBehaviour
{
    public List<Card> displayCard = new List<Card>();
    public int displayId;

    public int id;
    public string cardName;
    public int cost;
    public int attack;
    public int health;
    public string cardDescription;
    public Sprite spriteImage;

    public Text nameText;
    public Text costText;
    public Text attackText;
    public Text healthText;
    public Text descriptionText;
    public Image artImage;

    public bool cardBack;
    public static bool staticCardBack;

    public GameObject Hand;
    public int numberOfCardsInDeck;

    // Start is called before the first frame upgrade
    void Start()
    {
        numberOfCardsInDeck = PlayerDeck.deckSize;

        displayCard[0] = CardDatabase.cardList[displayId];
    }

    // Update is called once per frame
    void Update()
    {
        id = displayCard[0].id;
        cardName = displayCard[0].cardName;
        cost = displayCard[0].cost;
        attack = displayCard[0].attack;
        health = displayCard[0].health;
        cardDescription = displayCard[0].cardDescription;
        spriteImage = displayCard[0].spriteImage;

        nameText.text = " " + cardName;
        costText.text = " " + cost;
        attackText.text = " " + attack;
        healthText.text = " " + health;
        descriptionText.text = " " + cardDescription;
        artImage.sprite = spriteImage;

        
        Hand = GameObject.Find("Hand") ;
        if(this.transform.parent == Hand.transform.parent)
        {
            cardBack = false;            
        }


        staticCardBack = cardBack;

        if(this.CompareTag("Clone"))
        {
            displayCard[0] = PlayerDeck.staticDeck[numberOfCardsInDeck - 1];
            numberOfCardsInDeck -= 1;
            PlayerDeck.deckSize -= 1;
            cardBack = false;
            this.tag = "Untagged";
        }
    }
}
