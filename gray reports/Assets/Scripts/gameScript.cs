using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
public class gameScript : MonoBehaviour
{
    public GameObject emailApp;
    public GameObject desktop;
    public void openEmailApp()
    {
        emailApp.SetActive(true);
        desktop.SetActive(false);
    }
}
