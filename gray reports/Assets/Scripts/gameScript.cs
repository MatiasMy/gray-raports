using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
public class gameScript : MonoBehaviour
{
    public GameObject emailApp;
    public GameObject notesApp;
    public GameObject solitaireErrorApp;
    public GameObject newsApp;
    public GameObject someApp;
    public GameObject canApp;
    public TMP_Text speechText;

    public GameObject desktop;
    public static gameScript Instance;
    void Awake()
    {
        Instance = this;
    }
    public void speakThis(string toBeSpoken)
    {
        StartCoroutine(speaking(toBeSpoken));
    }
    private IEnumerator speaking(string speak)
    {
        speechText.text = speak;
        yield return new WaitForSeconds(4f);
        speechText.text = "";
    }
    public void openEmailApp()
    {
        emailApp.SetActive(true);
        desktop.SetActive(false);
    }

    public void openNotesApp()
    {
        notesApp.SetActive(true);
        desktop.SetActive(false);
    }

    public void openSolitaireErrorApp()
    {
        solitaireErrorApp.SetActive(true);
        desktop.SetActive(false);
    }

    public void openNewsApp()
    {
        newsApp.SetActive(true);
        desktop.SetActive(false);
    }

    public void openSomeApp()
    {
        someApp.SetActive(true);
        desktop.SetActive(false);
    }

    public void openCanApp()
    {
        canApp.SetActive(true);
        desktop.SetActive(false);
    }
    public void closeApp()
    {
        canApp.SetActive(false);
        someApp.SetActive(false);
        newsApp.SetActive(false);
        solitaireErrorApp.SetActive(false);
        notesApp.SetActive(false);
        emailApp.SetActive(false);
        desktop.SetActive(true);
    }
}
