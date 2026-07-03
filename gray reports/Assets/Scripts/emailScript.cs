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
    public TMP_Dropdown header3;
    public TMP_Dropdown toSend;
    public TMP_Text captainsNameTxt;
    public Button sendButton;
    public TMP_Text notEnoughHeadersTxt;
    public float timeToWait;
    private bool alreadySent = false;

    private List<string> savedHeaders = new List<string>();
    void Start()
    {
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
    public void openEmail(int emailID)
    {
        if (!alreadySent)
        {
            alreadySent = true;

            emailData email = new emailData
            {
                header = "qwerty",
                readHeader = "<link=\"e\"><u>qwerty</u></link>",
                text = "qretqret",
                from = "qwertiest",
                ID = 4
            };

            emailList.Add(email);

            foreach (Button button in emailButtons)
            {
                if (button.GetComponentInChildren<TextMeshProUGUI>().text == "")
                {
                    button.GetComponentInChildren<TextMeshProUGUI>().text = email.header;
                    StartCoroutine(newEmail(button.name));
                    break;
                }
            }
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
        notEnoughHeadersTxt.gameObject.SetActive(false);
        if (sendButton)
        {
            header1.value = 0;
            header1.RefreshShownValue();
            header2.value = 0;
            header2.RefreshShownValue();
            header3.value = 0;
            header3.RefreshShownValue();
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
                header3.options.Add(new TMP_Dropdown.OptionData(header));
                header3.RefreshShownValue();
            }
        }
    }

    public void raportOrEmail()
    {
        string selectedOption = headerDropdown.options[headerDropdown.value].text;
        if (selectedOption == "raport")
        {
            header1.gameObject.SetActive(true);
            header2.gameObject.SetActive(true);
            header3.gameObject.SetActive(true);
            toSend.gameObject.SetActive(false);
            captainsNameTxt.gameObject.SetActive(true);
        }
        if (selectedOption != "raport")
        {
            header1.gameObject.SetActive(false);
            header2.gameObject.SetActive(false);
            header3.gameObject.SetActive(false);
            toSend.gameObject.SetActive(true);
            captainsNameTxt.gameObject.SetActive(false);
        }
    }
    public void sendEmail()
    {
        string selectedOption = headerDropdown.options[headerDropdown.value].text;
        if (selectedOption == "raport")
        {
            if (header1.value == 0 || header2.value == 0 || header3.value == 0)
            {
                StartCoroutine(notEnoughHeaders());
                return;
            }
            string header1Text = header1.options[header1.value].text;
            endingDataScript.headers.Add(header1Text);
            string header2Text = header2.options[header2.value].text;
            endingDataScript.headers.Add(header2Text);
            string header3Text = header3.options[header3.value].text;
            endingDataScript.headers.Add(header3Text);
        }
        else
        {
            string toSendText = toSend.options[toSend.value].text;
            Debug.Log("Email sent to: " + toSendText);
        }
    }
    private IEnumerator notEnoughHeaders()
    {
        notEnoughHeadersTxt.gameObject.SetActive(true);
        yield return new WaitForSeconds(3f);
        notEnoughHeadersTxt.gameObject.SetActive(false);
    }
    private IEnumerator newEmail(string buttonName)
    {
        yield return new WaitForSeconds(timeToWait);
        foreach (Button button in emailButtons)
        {
            if (button.name == buttonName)
            {
                button.gameObject.SetActive(true);
                break;
            }
        }
    }

    [System.Serializable]
    public class emailData
    {
        public string header;
        public string readHeader; //<link="a"><u>clickable text</u></link>    link="a" is the link ID
        public string text;
        public string from;
        public int ID = 0;
    }
    public List<emailData> emailList = new List<emailData>();
}
