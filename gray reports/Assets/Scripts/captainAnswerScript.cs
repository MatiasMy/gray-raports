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
                    captainsAnswer = "Field Research_Field Research_I've read your report, Sergeant... It has come to my attention that you cannot conduct this investigation on your own, sitting behind a desktop, reading SlowKilo and The Times. Two deputies have been assigned to help you conduct field research. You can send these deputies on missions to uncover secrets in the wild. One more thing. I think you should stop looking into the suspect's affiliation to the Conservative party. Seems unimportant in my opinion._Captain Schwarz";
                    break;
                case "Suspicious Activity at Government Weapons Storages": // day 2
                    captainsAnswer = "Field Research_Field Research_Good Job, Sergeant. It has come to my attention, though, that you cannot conduct this investigation on your own, sitting behind a desktop, reading up on The latest Times. I've assigned you two deputies to help you conduct field research. You can send these deputies on missions to uncover secrets in the wild. Keep doing what you're doing_/Captain Schwarz";
                    break;
                case "Graffiti": //day 2
                    captainsAnswer = "Field Research_Field Research_Good Job, Sergeant. It has come to my attention, though, that you cannot conduct this investigation on your own, sitting behind a desktop, reading up on The latest Times. I've assigned you two deputies to help you conduct field research. You can send these deputies on missions to uncover secrets in the wild. Keep doing what you're doing! This Graffiti might not be a good lead, I heard something about the weapon storage incident, lets focus on that_Captain Schwarz";
                    break;
                case "Government Scandal: Drugs, Money, Politicians and Hard Party": //day 3 (good ending)
                    captainsAnswer = "Conserning This Case's Current Direction_Conserning This Case's Current Direction_Sergeant, I assure you Mr Pikimusta has nothing to do with me or the suspect. This is a missunderstanding and is affecting you're performance in solwing this investigadion. Re direct your focus on hwat matters. I have importantt matters to atend today, so dont mess up. Im leaving for an event tonight so leave your report to Lieutenant Stadt instead._Captain Schwarz";
                    break;
                case "A tip for the case": // day 3
                    captainsAnswer = "Conserning This Case's Current Direction_Conserning This Case's Current Direction_This is interesting but instead of reporting to me you should have sent one of youre deputies so I took it into my own hands. Deputy Black reports that the house was empty, his wife Ms Grau is the leader of the Future party and most importantly Mr Grau has ties to extremist groups around Crimebourgistan. Your deputies are yours, remember to use their experties. Im leaving for an event tonight so leave your report to Lieutenant Stadt instead._Captain Schwarz";
                    break;
                case "Local parks tree has been cut down": // day 3
                    captainsAnswer = "Conserning This Case's Current Direction_Conserning This Case's Current Direction_I dont think this park tree leads to anything useful... If you think otherwise on future leads send a deputy to look into it first, report to me the most useful cases. Im leaving for an event tonight so leave your report to Lieutenant Stadt instead._Captain Schwarz";
                    break; 
                case "Fire at the Fishing Contest": // day 4
                    captainsAnswer = "Great lead_Great lead_If that nasty Mr Grau is really behind this fire, we sure have ground to put him behind bars now! Keep looking into this sergeant, if you find out where Mr Grau may hide be sure to report to me._Captain Schwarz";
                    break;
                case "The People's Party Celebrates": //day 4 (good ending)
                    captainsAnswer = "This doesnt concern you_This doesnt concern you_The peoples party isnt what youre meant to be looking into sergeant, youre trying to catch Mr Grau. Find out something we can use against him immediately or we'll have someone else put on this case._Captain Schwarz";
                    break;
                case "Injustice!": //day 4
                    captainsAnswer = "Focus sergeant_Focus sergeant_This protest is not as important as catching Mr Grau. Makes haste Mr Grau could have been behind the fire that took place at the fishing contest, we need to know what hes going to do next and stop him!_Captain Schwarz";
                    break;
                case "Home investigation results": //day 4
                    captainsAnswer = "Good info for later_Good info for later_Lets keep in mind where Mr Grau may be hiding, when the time comes we know where to look first! And be careful, deputy Weiß seems to be an avid supporter of the future partya and that might interfere with her work._Captain Schwarz";
                    break;
                case "Break in at the goverment weapon storage": // day 5
                    captainsAnswer = "This is serious_This is serious_This weapon strorage thing is bad, people could get hurt. Look into this properly, we must catch this criminal before anything else happens._Captain Schwarz";
                    break;
                case "DJ blueberry shot found dead": // day 5
                    captainsAnswer = "DJ blueberry shot??_DJ blueberry shot??_Sergeant are you forgetting what your task was? Forget this DJ someone else will handle it. There was a break in at the weapon storage, look into that if possible._Captain Schwarz";
                    break;
                case "Corruption rumors": // day 5 (good ending)
                    captainsAnswer = "Rumors a rumor_Rumors a rumor_Sergeant a rumor is just that, a rumor. This isnt a good lead. There was a break in at the weapons storage, look into that before anything serious happens._Captain Schwarz";
                    break;
                case "Results: Body in the river": // day 6
                    captainsAnswer = "Finish the job_<link=\"a\"><u>Finish the job<u/><link/>_Multiple sources seem to point out that Mr Grau might have a secret station in the docks LIKE THE SHOOTING AT THE DOCKS!!Did you not read my email yesterday? Theyre obviously there, the situation is still ongoing. Send one of your deputies to finish the job, personally i would choose deputy Black._Captain Schwarz";
                    break;
                case "Shooting at the docks!": // day 6
                    captainsAnswer = "Finish the job_<link=\"a\"><u>Finish the job<u/><link/>_Good job sergeant, the shooting has died down but the situation is still ongoing. Send one of your deputies to finish the job, personally i would choose deputy Black._Captain Schwarz";
                    break;
                case "Mr pikimusta causes corruption?": // day 6 (good ending)
                    captainsAnswer = "Time to finish the job_<link=\"a\"><u>Time to finish the job<u/><link/>_Captain Schwarz has bee nput into questioning regarding his connections to Mr Pikimusta and Ms Graus case. As you probably know there was some shooting at the docks, the situation is still going on, you should send one of youre deputies there to finish this._Lieutenant Stadt";
                    break;
                case "Mr pikimusta questionable interview": // day 6 (good ending)
                    captainsAnswer = "Time to finish the job_<link=\"a\"><u>Time to finish the job<u/><link/>_Captain Schwarz has bee nput into questioning regarding his connections to Mr Pikimusta and Ms Graus case. As you probably know there was some shooting at the docks, the situation is still going on, you should send one of youre deputies there to finish this._Lieutenant Stadt";
                    break;
                case "Finish the job": // day 7
                    captainsAnswer = "Its done_Its done_Great job sergeant, Mr Grau is going away. Captain Schwarz is in questioning as of right now, we'll see what comes out of it. No need for a report today, go home._Lieutenant Stadt";
                    break;
                case "Time to finish the job": // day 7
                    captainsAnswer = "Its done_Its done_Great job sergeant, Mr Grau is going away. Captain Schwarz is in questioning as of right now, we'll see what comes out of it. No need for a report today, go home._Lieutenant Stadt";
                    break;
            }
        }
        reportList.Clear();
        return captainsAnswer;
    }
}
