using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class emailScript : MonoBehaviour
{

    public void openEmail(int emailID)
    {
        emailData selectedEmail = emailList.Find(email => email.ID == emailID);
        if (selectedEmail != null)
        {
            Debug.Log("Opening Email:");
            Debug.Log("Header: " + selectedEmail.header);
            Debug.Log("Text: " + selectedEmail.text);
            Debug.Log("From: " + selectedEmail.from);
        }
        else
        {
            Debug.LogWarning("Email with ID " + emailID + " not found.");
        }
    }
    [System.Serializable]
    public class emailData
    {
        public string header;
        public string text;
        public string from;
        public int ID = 0;
    }
    public List<emailData> emailList = new List<emailData>();
}
