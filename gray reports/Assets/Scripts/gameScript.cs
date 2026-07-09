using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using System.Globalization;
using System;
using UnityEngine.UI;
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
    public AudioSource audioSource;
    public AudioClip clickSound;
    public AudioClip backgroundMusic;
    public TMP_Text timeText;
    private float timer;
    public bool startOfGame = false;
    public Image notif;
    public static bool reportDone = false;

    void Awake()
    {
        Instance = this;
    }
    void Start()
    {
        audioSource.clip = backgroundMusic;
        audioSource.loop = true;
        audioSource.Play();
    }
    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= 1f)
        {
            timer = 0f;
            timeText.text = DateTime.Now.ToString("HH:mm:ss");
        }
        if (Input.GetMouseButtonDown(0))
        {
            audioSource.PlayOneShot(clickSound);
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            closeApp();
        }
    }
    public void speakThis(string toBeSpoken)
    {
        StartCoroutine(speaking(toBeSpoken));
    }
    private IEnumerator speaking(string speak)
    {
        speechText.text = speak;
        yield return new WaitForSeconds(5f);
        speechText.text = "";
    }
    public void openEmailApp()
    {
        notif.gameObject.SetActive(false);
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
        int num = UnityEngine.Random.Range(0, 10);
        solitaireErrorApp.SetActive(true);
        if (1f == num)
        {
            speakThis("Yeah I should work instead");
        }
        if (2f == num)
        {
            speakThis("Damn");
        }
        else if (3f == num)
        {
            speakThis("I really wanted to relax");
        }
        else if (4f == num)
        {
            speakThis("Since when?");
        }
        else if (5f == num)
        {
            speakThis("Is this on all the computers");
        }
        else if (6f == num)
        {
            speakThis("Someone must have seen me play it yesterday");
        }
    }

    public void openNewsApp()
    {
        if (startOfGame)
        {
            speakThis("I should look for uselful informermation to report");
            startOfGame = false;
        }
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
        notesApp.SetActive(false);
        emailApp.SetActive(false);
        solitaireErrorApp.SetActive(false);
        desktop.SetActive(true);
    }
    public void logout()
    {
        if (reportDone)
        {
            int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
            SceneManager.LoadScene(currentSceneIndex + 1);
            reportDone = false;
            emailScript.alreadySent = 0;
        }
        else
        {
            speakThis("I need to finish my report before logging out");
        }
    }
    public void leavework()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex + 1);
    }
}
