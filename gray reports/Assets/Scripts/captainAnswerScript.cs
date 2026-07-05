using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class captainAnswerScript : MonoBehaviour
{
    public static captainAnswerScript Instance;
    public static List<string> reportList = new List<string>();
    private string captainsAnswer = "";
    void Awake()
    {
        reportList.Add("previousEmail");
        Instance = this;
    }
    public string captainEmail()
    {
        foreach (string report in reportList)
        {
            switch (report)
            {
                case "previousEmail":
                    captainsAnswer = captainsAnswer + "A New case/A New case/Sergeant, I have a new job for you. I've gotten a request from our dear city of Crimebourgistan to bring question and detain suspect Mr Grau.I expect you to give reports daily on youre progress./Captain Swarchz";
                    break;
            }
        }
        reportList.Clear();
        return captainsAnswer;
    }
}
