using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deputyScript : MonoBehaviour
{
    public static deputyScript Instance;
    public static List<string> toDoList = new List<string>();
    private string emailAnswers = "";
    public static List<someScript.postData> savedPosts = new List<someScript.postData>();
    void Awake()
    {
        toDoList.Add("GraffitiMolly");
        Instance = this;
    }
    public string deputyEmails()
    {
        foreach (string todo in toDoList)
        {
            switch (todo)
            {
                case "GraffitiMolly":
                    emailAnswers = emailAnswers + "Update youre firewall/Update youre firewall/Update youre firewall it is going to expire on 6.7.2026/Team Fire Wall Fighters|";
                    break;
            }
        }
        toDoList.Clear();
        return emailAnswers;
    }
}
