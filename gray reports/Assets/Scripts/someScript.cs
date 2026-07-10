using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class someScript : MonoBehaviour, IPointerClickHandler
{
    public List<Image> posts;
    [SerializeField] private TMP_Text[] texts;
    public AudioClip savedHeader;
    public AudioSource audioSource;
    void Start()
    {
        for (int i = 0; i < postList.Count; i++)
        {
            postList[i].ID = i;
        }
        for (int i = 0; i < postList.Count; i++)
        {
            posts[i].gameObject.SetActive(true);
            TMP_Text profileNameTxt = posts[i].transform.Find("profileNameTxt").GetComponent<TMP_Text>();
            profileNameTxt.text = postList[i].profileName;
            Image pfp = posts[i].transform.Find("profilePicture").GetComponent<Image>();
            pfp.sprite = postList[i].profilePicture;
            Image image = posts[i].transform.Find("postImage").GetComponent<Image>();
            image.sprite = postList[i].image;
            TMP_Text text = posts[i].transform.Find("description").GetComponent<TMP_Text>();
            text.text = postList[i].textWithLink;
        }
    }
    public void OnPointerClick(PointerEventData eventData)
    {
        Debug.Log("clicked");
        foreach (TMP_Text text in texts)
        {
            int linkIndex = TMP_TextUtilities.FindIntersectingLink(
                text,
                eventData.position,
                eventData.pressEventCamera);

            if (linkIndex != -1)
            {
                TMP_LinkInfo linkInfo = text.textInfo.linkInfo[linkIndex];
                audioSource.PlayOneShot(savedHeader);
                switch (linkInfo.GetLinkID())
                {
                    case "a":
                        emailScript.savedHeaders.Add(postList[0].text);
                        break;
                    case "b":
                        emailScript.savedHeaders.Add(postList[1].text);
                        break;
                    case "c":
                        emailScript.savedHeaders.Add(postList[2].text);
                        break;
                    case "d":
                        emailScript.savedHeaders.Add(postList[3].text);
                        break;
                    case "e":
                        emailScript.savedHeaders.Add(postList[4].text);
                        break;
                    case "f":
                        emailScript.savedHeaders.Add(postList[5].text);
                        break;
                    case "g":
                        emailScript.savedHeaders.Add(postList[6].text);
                        break;
                    case "h":
                        emailScript.savedHeaders.Add(postList[7].text);
                        break;
                    case "i":
                        emailScript.savedHeaders.Add(postList[8].text);
                        break;
                    case "j":
                        emailScript.savedHeaders.Add(postList[9].text);
                        break;
                }

                break; // Stop once we've found the clicked link.
            }
        }
    }
    public void like(Button button)
    {
        button.image.color = Color.red;
        if (2f > Random.Range(0, 10))
        {
            gameScript.Instance.speakThis("I should get back to work");
        }
        else if (8f < Random.Range(0, 10))
        {
            gameScript.Instance.speakThis("Thats dumb, I have a case to solve");
        }
    }
    [System.Serializable]
    public class postData
    {
        public Sprite image;
        [Header("textWithLink to be displayd")]
        public string textWithLink; //<link="a"><u>clickable text</u></link>    link="a" is the link ID
        [Header("identical but without the link to be sent on a report or like that")]
        public string text;
        public string profileName;
        public Sprite profilePicture;
        [Header("dont touch ID")]
        public int ID = 0;
    }
    public List<postData> postListTemp = new List<postData>();
    public List<postData> postList = new List<postData>();
}