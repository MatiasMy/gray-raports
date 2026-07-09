using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class endingDataScript : MonoBehaviour
{
    public static List<string> headers = new List<string>();
    public static List<string> deputies = new List<string>();
    private int goodEnding;
    private int neutralEnding;
    public bool endofgame = false;
    public Image goodEndingImg;
    public Image neutralEndingImg;
    public Image badEndingImg;
    public TMP_Text desc;
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
            if (head == "Break in at the goverment weapon storage" || head == "Resulsts: Weapon storage incident" || head =="Home investigation results" || head =="A tip for the case")
            {
                neutralEnding++;
            }
        }
        if (goodEnding >= 3) //add ending images and text || add comics and posts for day 6 and 7
        {
            Debug.Log("goodending");
            goodEndingImg.gameObject.SetActive(true);
            desc.text="Mr Grau and Captain Schwarz have been put away for their crimes. A bomb was found at the docks and disarmed, you will get a promotion for this (good ending 1 of 3)";
        }
        else if (neutralEnding >= 3)
        {
            Debug.Log("neutralEnding");
            neutralEndingImg.gameObject.SetActive(true);
            desc.text="Mr Grau is behind bars, a bomb was found at the docks. Captain Schwarz got his job back and the first thing he did was to let you go. (neutral ending 1 of 3)";
        }
        else
        {
            Debug.Log("badEnding");
            badEndingImg.gameObject.SetActive(true);
            desc.text="Mr Grau was put behind bars, but his explosive was never found, the next day it blew up taking dozens of lives with it, you lost your job at the department (bad ending 1 of 3)";
        }
    }
}