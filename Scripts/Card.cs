using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]

public class Card
{
    public int id;
    public string cardName;
    public int cost;
    public int attack;
    public int health;
    public string cardDescription;
    public Sprite spriteImage;

    public Card(){

    }

    public Card(int Id, string CardName, int Cost, int Attack, int Health, string CardDescription, Sprite SpriteImage)
    {
        id = Id;
        cardName = CardName;
        cost = Cost;
        attack = Attack;
        health = Health;
        cardDescription = CardDescription;
        spriteImage = SpriteImage;
    }

}
