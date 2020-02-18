using System;
using System.Collections.Generic;
using UnityEngine;
public class Deck //: MonoBehaviour
{
    private List<Card> deck;
    //private void ShuffleCards(){
    //    for (int i = 0; i < (deck.Count * 6); i++)
    //    {
    //        int index1 = UnityEngine.Random.Range(0, deck.Count - 1);
    //        int index2 = UnityEngine.Random.Range(0, deck.Count - 1);
    //        if (index1 == index2)
    //        {
    //            index2 = UnityEngine.Random.Range(0, deck.Count - 1);
    //        }
    //        Card temp = deck[index1];
    //        deck[index1] = deck[index2];
    //        deck[index2] = temp;
    //        //temp = null;
    //        //Destroy(temp);
    //    }
    //}
    public Deck(GameObject[] cards) {
        deck = new List<Card>();
        foreach (GameObject card in cards) {
            deck.Add(new Card(card));
        }
        
    }
    public Deck(GameObject[] cards, int numDecks) {
        deck = new List<Card>();
        while (numDecks-- > 0){
            foreach (GameObject card in cards) {
                deck.Add(new Card(card));
            }
        }
     
    }
    public Card DrawCard() {
        int index = UnityEngine.Random.Range(0, deck.Count - 1);
        Card chosen = deck[index];
        deck.RemoveAt(index);
        return chosen;
    }
}