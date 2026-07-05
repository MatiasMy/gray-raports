using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class emailScript : MonoBehaviour, IPointerClickHandler
{
    public List<Button> emailButtons;
    public Image readEmailBackGround;
    public Image sentEmailBackGround;
    public GameObject emailApp;
    public GameObject desktop;
    public TMP_Dropdown headerDropdown;
    public TMP_Dropdown header1;
    public TMP_Dropdown header2;
    public TMP_Dropdown toSend;
    public TMP_Text captainsNameTxt;
    public Button sendButton;
    public float timeToWait;
    public emailData email1;
    private bool alreadySent = false;
    public static List<string> savedHeaders = new List<string>();
    private List<string> missionsToBe = new List<string>();
    void Start()
    {
        missionsToBe.Add("jokemission");
        string captainAnswer = captainAnswerScript.Instance.captainEmail();
        receiveCaptainsEmail(captainAnswer);
        string emailAnswer = deputyScript.Instance.deputyEmails();
        receivedDeputyEmails(emailAnswer);
        sentEmailBackGround.gameObject.SetActive(false);
        for (int i = 0; i < emailList.Count; i++)
        {
            emailButtons[i].GetComponentInChildren<TextMeshProUGUI>().text = emailList[i].header;
        }
        foreach (Button button in emailButtons)
        {
            if (button.GetComponentInChildren<TextMeshProUGUI>().text == "")
            {
                button.gameObject.SetActive(false);
            }
        }
    }
    public void receiveCaptainsEmail(string emailAnswer)
    {
        string[] parts = emailAnswer.Split('/');
        emailData newEmail = new emailData
        {
            header = parts[0],
            readHeader = parts[1],
            text = parts[2],
            from = parts[3],
            ID = 0
        };
        emailList.Add(newEmail);
    }
    public void receivedDeputyEmails(string emailAnswer)
    {
        emailAnswer = emailAnswer.Substring(0, emailAnswer.Length - 1);
        string[] emails = emailAnswer.Split('|');

        foreach (string email in emails)
        {
            string[] parts = email.Split('/');
            emailData newEmail = new emailData
            {
                header = parts[0],
                readHeader = parts[1],
                text = parts[2],
                from = parts[3],
                ID = 0
            };
            emailList.Add(newEmail);
        }
    }
    public void openEmail(int emailID)
    {
        if (!alreadySent)
        {
            StartCoroutine(newEmail());
            alreadySent = true;
        }
        for (int i = 0; i < emailList.Count; i++)
        {
            emailList[i].ID = i;
        }
        sendButton.gameObject.SetActive(false);
        readEmailBackGround.gameObject.SetActive(true);
        sentEmailBackGround.gameObject.SetActive(false);
        emailData selectedEmail = emailList.Find(email => email.ID == emailID);
        if (selectedEmail != null)
        {
            readEmailBackGround.gameObject.SetActive(true);
            TMP_Text headerTxt = readEmailBackGround.transform.Find("header").GetComponent<TMP_Text>();
            headerTxt.text = selectedEmail.readHeader;
            TMP_Text textTxt = readEmailBackGround.transform.Find("text").GetComponent<TMP_Text>();
            textTxt.text = selectedEmail.text;
            TMP_Text fromTxt = readEmailBackGround.transform.Find("from").GetComponent<TMP_Text>();
            fromTxt.text = selectedEmail.from;
        }
        else
        {
            Debug.LogWarning("Email with ID " + emailID + " not found.");
        }
    }
    public void closeEmailApp()
    {
        emailApp.SetActive(false);
        desktop.SetActive(true);
    }
    public void OnPointerClick(PointerEventData eventData)
    {
        TMP_Text text = readEmailBackGround.transform.Find("header").GetComponent<TMP_Text>();
        text.ForceMeshUpdate();
        int linkIndex = TMP_TextUtilities.FindIntersectingLink(
            text,
            eventData.position,
            eventData.pressEventCamera);
        if (linkIndex != -1)
        {
            TMP_LinkInfo linkInfo = text.textInfo.linkInfo[linkIndex];

            switch (linkInfo.GetLinkID())
            {
                case "a":
                    savedHeaders.Add(emailList[0].header);
                    break;
                case "b":
                    savedHeaders.Add(emailList[1].header);
                    break;
                case "c":
                    savedHeaders.Add(emailList[2].header);
                    break;
                case "d":
                    savedHeaders.Add(emailList[3].header);
                    break;
                case "e":
                    savedHeaders.Add(emailList[4].header);
                    break;
                case "f":
                    savedHeaders.Add(emailList[5].header);
                    break;
                case "g":
                    savedHeaders.Add(emailList[6].header);
                    break;
                case "h":
                    savedHeaders.Add(emailList[7].header);
                    break;
                case "i":
                    savedHeaders.Add(emailList[8].header);
                    break;
                case "j":
                    savedHeaders.Add(emailList[9].header);
                    break;
            }
        }
    }
    public void openSendEmail()
    {
        if (sendButton)
        {
            header1.value = 0;
            header1.RefreshShownValue();
            header2.value = 0;
            header2.RefreshShownValue();
        }
        sendButton.gameObject.SetActive(true);
        readEmailBackGround.gameObject.SetActive(false);
        sentEmailBackGround.gameObject.SetActive(true);
        foreach (string header in savedHeaders)
        {
            if (!headerDropdown.options.Exists(option => option.text == header))
            {
                headerDropdown.options.Add(new TMP_Dropdown.OptionData(header));
                headerDropdown.RefreshShownValue();
                header1.options.Add(new TMP_Dropdown.OptionData(header));
                header1.RefreshShownValue();
                header2.options.Add(new TMP_Dropdown.OptionData(header));
                header2.RefreshShownValue();
            }
        }
    }

    public void reportOrEmail()
    {
        string selectedOption = headerDropdown.options[headerDropdown.value].text;
        if (selectedOption == "report")
        {
            header1.gameObject.SetActive(true);
            header2.gameObject.SetActive(true);
            toSend.gameObject.SetActive(false);
            captainsNameTxt.gameObject.SetActive(true);
        }
        if (selectedOption != "report")
        {
            header1.gameObject.SetActive(false);
            header2.gameObject.SetActive(false);
            toSend.gameObject.SetActive(true);
            captainsNameTxt.gameObject.SetActive(false);
        }
    }
    public void sendEmail()
    {
        string selectedOption = headerDropdown.options[headerDropdown.value].text;
        if (selectedOption == "report")
        {
            if (header1.value == 0 || header2.value == 0)
            {
                gameScript.Instance.speakThis("My report should contain two subtitles");
                return;
            }
            string header1Text = header1.options[header1.value].text;
            endingDataScript.headers.Add(header1Text);
            string header2Text = header2.options[header2.value].text;
            endingDataScript.headers.Add(header2Text);
            captainAnswerScript.reportList.Add(header1Text + header2Text);
            gameScript.Instance.speakThis("Thats it for today, time to head for home");
        }
        else
        {
            toSend.RefreshShownValue();
            string toSendString = toSend.options[toSend.value].text;
            int selectedIndex = toSend.value;
            string toDoString = headerDropdown.options[headerDropdown.value].text;
            if (toSend.options[toSend.value].text == "-")
            {
                gameScript.Instance.speakThis("I should select who to send this to");
                return;
            }
            else
            {
                string mission = toDoString + toSendString;
                foreach (string Mission in missionsToBe)
                {
                    if (Mission == mission)
                    {
                        gameScript.Instance.speakThis("Ive already sent an email like this");
                        break;
                    }
                    else
                    {
                        gameScript.Instance.speakThis("pussy");
                        deputyScript.toDoList.Add(mission);
                        float num = Random.Range(0, 10);
                        if (1f == num)
                        {
                            gameScript.Instance.speakThis("Hope this isnt a waste of time");
                        }
                        if (2f == num)
                        {
                            gameScript.Instance.speakThis("Am I going to regret this");
                        }
                        else if (3f == num)
                        {
                            gameScript.Instance.speakThis("Can " + toSendString + " be trusted to get this done");
                        }
                        else if (4f == num)
                        {
                            gameScript.Instance.speakThis("Could be nothing, but I'll never know if I dont send someone");
                        }
                        else if (5f == num)
                        {
                            gameScript.Instance.speakThis("Wish I was still on the streets");
                        }
                        else if (6f == num)
                        {
                            gameScript.Instance.speakThis("Should I take a break");
                        }
                        else if (7f == num)
                        {
                            gameScript.Instance.speakThis(toSendString + " better get me something useful");
                        }
                        else if (8f == num)
                        {
                            gameScript.Instance.speakThis("Hope " + toSendString + " isnt slow with this");
                        }
                        else if (9f == num)
                        {
                            gameScript.Instance.speakThis("I expect alot out of this");
                        }
                        else if (10f == num)
                        {
                            gameScript.Instance.speakThis("I might need a holiday, I talk alot to myself");
                        }
                    }
                }
                missionsToBe.Add(mission);
            }
            toSend.value = 0;
        }
    }
    private IEnumerator newEmail()
    {
        Button emptyButton = null;
        foreach (Button button in emailButtons)
        {
            if (button.GetComponentInChildren<TextMeshProUGUI>().text == "")
            {
                button.GetComponentInChildren<TextMeshProUGUI>().text = email1.header;
                emptyButton = button;
                break;
            }
        }
        yield return new WaitForSeconds(timeToWait);
        foreach (Button button in emailButtons)
        {
            if (button.name == emptyButton.name)
            {
                button.gameObject.SetActive(true);
                emailList.Add(email1);
                break;
            }
        }
    }


    [System.Serializable]
    public class emailData
    {
        [Header("readHeader displayed, header sent on a report")]
        public string header;
        public string readHeader; //<link="a"><u>clickable text</u></link>    link="a" is the link ID
        public string text;
        public string from;
        [Header("dont touch ID")]
        public int ID = 0;
    }
    public List<emailData> emailList = new List<emailData>();
}
