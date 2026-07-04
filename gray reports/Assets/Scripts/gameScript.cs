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

    public GameObject desktop;
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
}
