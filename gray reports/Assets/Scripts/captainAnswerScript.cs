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
        Instance = this;
    }
    public string captainEmail()
    {
        foreach (string report in reportList)
        {
            switch (report)
            {
                case "":
                    captainsAnswer = "|";
                    break;
                case "Leader of the Future Party In Jail!": //day2
                    captainsAnswer = "Field Research-Field Research-I've read your report, Sergeant... It has come to my attention that you cannot conduct this investigation on your own, sitting behind a desktop, reading SlowKilo and The Times. Two deputies have been assigned to help you conduct field research. You can send these deputies on missions to uncover secrets in the wild. One more thing. I think you should stop looking into the suspect's affiliation to the Conservative party. Seems unimportant in my opinion.-Captain Schwarz";
                    break;
                case "Suspicious Activity at Government Weapons Storages": // day 2
                    captainsAnswer = "Field Research-Field Research-Good Job, Sergeant. It has come to my attention, though, that you cannot conduct this investigation on your own, sitting behind a desktop, reading up on The latest Times. I've assigned you two deputies to help you conduct field research. You can send these deputies on missions to uncover secrets in the wild. Keep doing what you're doing-/Captain Schwarz";
                    break;
                case "Graffiti": //day 2
                    captainsAnswer = "Field Research-Field Research-Good Job, Sergeant. It has come to my attention, though, that you cannot conduct this investigation on your own, sitting behind a desktop, reading up on The latest Times. I've assigned you two deputies to help you conduct field research. You can send these deputies on missions to uncover secrets in the wild. Keep doing what you're doing! This Graffiti might not be a good lead, I heard something about the weapon storage incident, lets focus on that-Captain Schwarz";
                    break;
                case "Government Scandal: Drugs, Money, Politicians and Hard Party": //day 3
                    captainsAnswer = "Conserning This Case's Current Direction-Conserning This Case's Current Direction-Sergeant, I assure you Mr Pikimusta has nothing to do with me or the suspect. This is a missunderstanding and is affecting you're performance in solwing this investigadion. Re direct your focus on hwat matters. I have importantt matters to atend today, so dont mess up.-Captain Schwarz";
                    break;
                case "A tip for the case": // day 3
                    captainsAnswer = "Conserning This Case's Current Direction-Conserning This Case's Current Direction-This is interesting but instead of reporting to me you should have sent one of youre deputies so I took it into my own hands. Deputy Black reports that the house was empty, his wife Ms Grau is the leader of the Future party and most importantly Mr Grau has ties to extremist groups around Crimebourgistan. Your deputies are yours, remember to use their experties-Captain Schwarz";
                    break;
                case "Fire at the Fishing Contest": // day 4
                    captainsAnswer = "Something Personal-<link=\"b\"><u>Something personal</u></link>-I admit it. I was paid to detain Ms Grau. I was influenced. Mr Pikimusta threatened me with my job if I didn't play along. I had no choice!-Captain Schwarz";
                    break;
                case "The People's Party Celebrates": //day 4
                    captainsAnswer = "Time To Finish The Job-<link=\"b\"><u>Time To Finish The Job</u></link>-Good job, Sergeant. Now that we know where Mr Grau is hiding, you can send a deputy to bring them in and jail them. May luck be on our side.-Captain Schwarz";
                    break;
                case "Something Personal":
                    captainsAnswer = "Excellent work, Sergeant-Excellent work, Sergeant-Captain Schwartz has been detained due to his ties with the corrupt politician Pikimusta. I'm writing you this message to congratulate you on the successful investigation. I see a bright future in front of you.-Liutenant Stadt";
                    break;
                case "Time To Finish The Job":
                    captainsAnswer = "The Investigation Comes To A Close-The Investigation Comes To A Close-Thank you, Sergeant. Your work has paved a way for the future of this country. I'm sure this is the best thing that could've come out of this investigation and am sure, that your help will be needed in the aftermath.-Captain Schwarz";
                    break;
            }
        }
        reportList.Clear();
        return captainsAnswer;
    }
}
