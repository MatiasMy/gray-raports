using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class endingDataScript : MonoBehaviour
{
    public static List<string> headers = new List<string>();
    public static List<string> deputies = new List<string>();
    private int goodEnding;
    private int badEnding;
    public bool endofgame = false;
    void Start()
    {
        if (endofgame)
        {
            calculateEnding();
        }
    }
    public void calculateEnding()
    {
        foreach (string head in headers)
        {
            if (head == "Mr pikimusta causes corruption?" || head == "Mr pikimusta questionable interview" || head == "Corruption rumors" || head == "The People's Party Celebrates" || head == "Government Scandal: Drugs, Money, Politicians and Hard Party")
            {
                goodEnding++;
            }
        }
        foreach (string head in headers)
        {
            if (head == "Graffiti" || head == "Fire at the Fishing Contest" || head == "Local parks tree has been cut down" || head == "DJ blueberry shot found dead")
            {
                badEnding++;
            }
        }
        if (goodEnding >= 3) //add ending images and text || add comics and posts for day 6 and 7
        {
            Debug.Log("goodending");
        }
        else if (badEnding >= 3)
        {
            Debug.Log("goodending");
        }
        else
        {
            Debug.Log("ending");
        }
    }
}