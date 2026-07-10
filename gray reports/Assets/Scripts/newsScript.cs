using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class newsScript : MonoBehaviour, IPointerClickHandler
{
    public List<Image> articles;
    [SerializeField] private TMP_Text[] texts;
    public Sprite comicOfTheDay;
    public Image comic;
    public AudioClip savedHeader;
    public AudioSource audioSource;
    void Start()
    {
        comic.sprite = comicOfTheDay;
        for (int i = 0; i < newsList.Count; i++)
        {
            newsList[i].ID = i;
        }
        for (int i = 0; i < newsList.Count; i++)
        {
            articles[i].gameObject.SetActive(true);
            TMP_Text headerTxt = articles[i].transform.Find("headerText").GetComponent<TMP_Text>();
            headerTxt.text = newsList[i].readHeader;
            TMP_Text textTxt = articles[i].transform.Find("textText").GetComponent<TMP_Text>();
            textTxt.text = newsList[i].text;
            TMP_Text fromTxt = articles[i].transform.Find("writerText").GetComponent<TMP_Text>();
            fromTxt.text = newsList[i].writer;
        }
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            float num = Random.Range(0, 10);
            if (1f == num)
            {
                gameScript.Instance.speakThis("Hmmmm");
            }
            else if (10f == num)
            {
                gameScript.Instance.speakThis("Intresting");
            }
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
                        emailScript.savedHeaders.Add(newsList[0].header);
                        break;
                    case "b":
                        emailScript.savedHeaders.Add(newsList[1].header);
                        break;
                    case "c":
                        emailScript.savedHeaders.Add(newsList[2].header);
                        break;
                    case "d":
                        emailScript.savedHeaders.Add(newsList[3].header);
                        break;
                    case "e":
                        emailScript.savedHeaders.Add(newsList[4].header);
                        break;
                    case "f":
                        emailScript.savedHeaders.Add(newsList[5].header);
                        break;
                    case "g":
                        emailScript.savedHeaders.Add(newsList[6].header);
                        break;
                    case "h":
                        emailScript.savedHeaders.Add(newsList[7].header);
                        break;
                    case "i":
                        emailScript.savedHeaders.Add(newsList[8].header);
                        break;
                    case "j":
                        emailScript.savedHeaders.Add(newsList[9].header);
                        break;
                }

                break; // Stop once we've found the clicked link.
            }
            else
            {
                int i = 0;
                i++;
            }
        }
    }

    [System.Serializable]
    public class newsData
    {
        [Header("readHeader displayed, header sent on a report")]
        public string header;
        public string readHeader; //<link="a"><u>clickable text</u></link>    link="a" is the link ID
        public string text;
        public string writer;
        [Header("keep ID at 0")]
        public int ID = 0;
    }
    public List<newsData> newsList = new List<newsData>();
}
