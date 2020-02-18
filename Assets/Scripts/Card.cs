using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card //: MonoBehaviour
{
    private GameObject card;
    private int point;
    public int Point { get { return this.point; } }
    public GameObject Image { get { return this.card; } }

    public Card(GameObject prefab) {
        this.card = prefab;
        string name = prefab.name;
        int point;
        switch (name.Substring(name.Length - 1))
        {
            // ace
            case "e":
                point = 11;
                break;
            case "k": // jacK
            case "g": // kinG
            case "n": // queeN
            case "0": // 10
                point = 10;
                break;
            default:
                // other remaining possible cards, 2 - 9
                point = Convert.ToInt16(name.Substring(name.Length - 1));
                break;
        }
        this.point = point;
    }
}