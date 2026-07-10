using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deputyScript : MonoBehaviour
{
    public static deputyScript Instance;
    public static List<string> toDoList = new List<string>();
    private string emailAnswers = "";

    void Awake()
    {
        Instance = this;
    }
    public string deputyEmails()
    {
        foreach (string todo in toDoList)
        {
            switch (todo)
            {
                case "":
                    emailAnswers = emailAnswers + "|";
                    break;
                case "A tip for the caseDeputy Weiß"://day 3
                    emailAnswers = emailAnswers + "Home investigation results_<link=\"b\"><u>Home investigation results</u></link>_Hi, Weiß here. I checked out Grau's house as you asked. The whole place felt like it'd been abandoned a while ago: there was noBODY there! There were a lot of crazy documents though, something about explosives and guns but I wasnt able to make anything proper out of it. Like how his wife is the leader of the Future party and some documents related to some weird people not connected to the Future party. Sucks that the wife's locked up for doing something illegal. I also brained together that these weird extremists may have a place near the docks but im not sure where exactly, I can go chat them up next, or I mean investigate them if you wish._Deputy Weiß|";
                    Debug.Log("A tip for the caseDeputy Weiß");
                    break;
                case "A tip for the caseDeputy Black": //day 3
                    emailAnswers = emailAnswers + "Results: Home Investigation_Results: Home Investigation_The suspect's home seems to have been empty for longer than a day. That's not to say it's without clues. The suspect's wife is the leader of the Future party and Mr Grau has ties to extremist groups around Crimebourgistan. I've singled out the most likely connection to yield us results quickly. I suggest we move on these contacts without delay to learn more._Deputy Black|";
                    Debug.Log("A tip for the caseDeputy Black");
                    break;
                case "Local parks tree has been cut downDeputy Weiß"://day 3
                    emailAnswers = emailAnswers + "Strange tree incident_Strange tree incident_Hi, Weiß here. I dont think this tree has anything to do with our case, might just be an act of vandalisim._Deputy Weiß|";
                    Debug.Log("Local parks tree has been cut downDeputy Weiß");
                    break;
                case "Local parks tree has been cut downDeputy Black": //day 3
                    emailAnswers = emailAnswers + "Results: Park tree_Results: Home Park tree_This tree is nothing, we should leave it and focus on the case._Deputy Black|";
                    Debug.Log("Local parks tree has been cut downDeputy Black");
                    break;
                case "Fire at the Fishing ContestDeputy Weiß": //day 4
                    emailAnswers = emailAnswers + "The fire was a set up_The fire was a set up_I think someone has left a rotten egg here, because this fire smells off. Like, all the major clues point to this being a some sort of revenge by Mr Grau on the People's Party, but It's just... Off! Some of the people running this event smile when I look away and guide me to look at the same, obvious clues over and over again. And I can't just say that to their face. It's so stupid! I can't get more out of this scene, but I think we should look into some government officials, especially the ones responsible for this fishing event in this private forest._Deputy Weiß|";
                    Debug.Log("Fire at the Fishing ContestDeputy Weiß");
                    break;
                case "The People's Party CelebratesDeputy Weiß": // day 4
                    emailAnswers = emailAnswers + "The peoples party is full of assholes_The peoples party is full of assholes_These people are crazy! I interrogated the ties found in. I don't know what to make of this other than the scale of their operation: we've stepped into something huge! We must catch Mr Grau before anything more serious comes out of this._Deputy Weiß|";
                    Debug.Log("The People's Party CelebratesDeputy Weiß");
                    break;
                case "Injustice!Deputy Weiß": // day 4
                    emailAnswers = emailAnswers + "Protest notes_Protest notes_Hi sergeant!I stuck to the sidelines of the protest, nothing really noteworthy happend, but I do have strong feelings towards Ms Graus detainment. No signes of Mr Grau_Deputy Weiß|";
                    Debug.Log("Injustice!Deputy Weiß");
                    break;
                case "Home investigation resultsDeputy Weiß": // day 4
                    emailAnswers = emailAnswers + "More graffiti_More graffiti_I wasnt able to find where Mr Grau or his associates may be stationed up but there was this huge mural made for Ms Grau about her wrongful imprisonment._Deputy Weiß|";
                    Debug.Log("Home investigation resultsDeputy Weiß");
                    break;
                case "Home investigation resultsDeputy Black": // day 4
                    emailAnswers = emailAnswers + "Results: Docks_Results: Docks_Nothing to report, no indications of suspicious activity._Deputy Weiß|";
                    Debug.Log("Home investigation resultsDeputy Black");
                    break;
                case "Fire at the Fishing ContestDeputy Black": // day 4
                    emailAnswers = emailAnswers + "Results: Fire Investigation_Results: Fire Investigation_The suspect has seemingly left many tracks at this burned fishing contest. I should note that all evidence regarding Mr Grau was pointed out to me by someone already there. There was no involved thinking on my part; everything was done for me, which leaves me with suspicions._Deputy Black|";
                    Debug.Log("Fire at the Fishing ContestDeputy Black");
                    break;
                case "The People's Party CelebratesDeputy Black":// day 4
                    emailAnswers = emailAnswers + "Results: Ties Investigation_Results: Ties Investigation_The suspect's ties lips remained somewhat sealed regarding our suspect. They know, however, where the suspect is, and so do we. I should note that this is information they freely gave out, while basically everything else was sealed from me. I suggest we might be stepping into a trap, Sergeant. Even still, I think we should spring their trap with a sure stomp._Deputy Black|";
                    Debug.Log("The People's Party CelebratesDeputy Black");
                    break;
                case "Injustice!Deputy Black":// day 4
                    emailAnswers = emailAnswers + "Results: Protest investigation_Results: Protest investigation_I saw Mr Grau at the protest, he wasnt taking part in it but he was there talking to some people. The person he was talking to was dressed in black and had his face covered. Mr Grau is planning something big._Deputy Black|";
                    Debug.Log("Injustice!Deputy Black");
                    break;
                case "DJ blueberry shot found deadDeputy Black": // day 5
                    emailAnswers = emailAnswers + "Results: Body in the river_<link=\"b\"><u>Results: Body in the river</u></link>_Asking around led me to nothing, so I took things into my own hands. I found a bullet casing on the ground in the same caliber that the stolen weapons would use. Something fishy is going on in the docks._Deputy Black|";
                    Debug.Log("DJ blueberry shot found deadDeputy Black");
                    break;
                case "Break in at the goverment weapon storageDeputy Weiß": // day 5
                    emailAnswers = emailAnswers + "Nothing to report_Nothing to report_The army wouldnt let me near the storage or answer my questions. I snooped around for a bit but got nothing, sorry_Molly Weiß|";
                    Debug.Log("Break in at the goverment weapon storageDeputy Weiß");
                    break;
                case "DJ blueberry shot found deadDeputy Weiß": // day 5
                    emailAnswers = emailAnswers + "Dead DJ_Dead DJ_I asked around the station and the other deputies at the site but there are no leads to the killer yet. I dont think theres anythin to be found here_Molly Weiß|";
                    Debug.Log("DJ blueberry shot found deadDeputy Weiß");
                    break;
                case "Break in at the goverment weapon storageDeputy Black": // day 5
                    emailAnswers = emailAnswers + "Resulsts: Weapon storage incident_<link=\"c\"><u>Resulsts: Weapon storage incident</u></link>_The army wont let anyone near the site. Looking around a bit I found a pair of cutters, they could have finger prints on them?. Nothing else notewrothy was found._Deputy Black|";
                    Debug.Log("Break in at the goverment weapon storageDeputy Black");
                    break;
                case "Corruption rumorsDeputy Weiß": // day 5
                    emailAnswers = emailAnswers + "Nothing found_Nothing found_I wasnt able to find anything regarding this rumor, but Mr Pikimusta sure seems fishy to me._Molly Weiß|";
                    Debug.Log("Corruption rumorsDeputy Weiß");
                    break;
                case "Corruption rumorsDeputy Black": // day 5
                    emailAnswers = emailAnswers + "Results: Rumors_Results: Rumors_I could not get any info on this rumor, maybe we should focus on the real criminal instead of chasing fairytale leads._Deputy Black|";
                    Debug.Log("Corruption rumorsDeputy Black");
                    break;
                case "Results: Body in the riverDeputy Black": // day 6
                    emailAnswers = emailAnswers + "Results: Dock search_Results: Dock search_Yes sergeant, theres definitely something here. One of the halls on the south side is locked but had activity inside late into the night. I also found a mural for Ms Grau so some of Mr Graus associates have atleast been here._Deputy Black|";
                    Debug.Log("Results: Body in the riverDeputy Black");
                    break;
                case "Results: Body in the riverDeputy Weiß": // day 6
                    emailAnswers = emailAnswers + "Somethings here_Somethings here_Sergeant, Mr Grau is definitely hiding somewhere in the docks. Im sure we can catch him here in one of the halls._Molly Weiß|";
                    Debug.Log("Results: Body in the riverDeputy Weiß");
                    break;
                case "Shooting at the docks!Deputy Black": // day 6
                    emailAnswers = emailAnswers + "Results: Shooting_Results: Shooting_I can confirm sergeant that Mr Grau is behind this shooting, his associates and possibly him are still held up inside that hall. If you let me take my team there we can fucking put an end to this finally! These assholes deserve to go down._Deputy Black|";
                    Debug.Log("Shooting at the docks!Deputy Black");
                    break;
                case "Shooting at the docks!Deputy Weiß": // day 6
                    emailAnswers = emailAnswers + "Mr Grau is part of this_Mr Grau is part of this_Im curtain that Mr Grau is part of this shooting. Let me take a team in and end this madness._Molly Weiß|";
                    Debug.Log("Shooting at the docks!Deputy Weiß");
                    break;
                case "Mr pikimusta causes corruption?Deputy Black": // day 6
                    emailAnswers = emailAnswers + "Results: Corruption_Results: Corruption_Captain Schwarz has been put into questioning, we'll get all the information out of him_Deputy Black|";
                    Debug.Log("Mr pikimusta causes corruption?Deputy Black");
                    break;
                case "Mr pikimusta causes corruption?Deputy Weiß": // day 6
                    emailAnswers = emailAnswers + "I dont trust him_I dont trust him_ captain Schwarz was placed into questioning today regarding his corruption and ties to Ms Grauses case, she deserves justice._Molly Weiß|";
                    Debug.Log("Mr pikimusta causes corruption?Deputy Weiß");
                    break;
                case "Mr pikimusta questionable interviewDeputy Black": // day 6
                    emailAnswers = emailAnswers + "Results: Corruption_Results: Corruption_Captain Schwarz has been put into questioning, we'll get all the information out of him_Deputy Black|";
                    Debug.Log("Mr pikimusta questionable interviewDeputy Black");
                    break;
                case "Mr pikimusta questionable interviewDeputy Weiß": // day 6
                    emailAnswers = emailAnswers + "I dont trust him_I dont trust him_ captain Schwarz was placed into questioning today regarding his corruption and ties to Ms Grauses case, she deserves justice._Molly Weiß|";
                    Debug.Log("Mr pikimusta questionable interviewDeputy Weiß");
                    break;
                case "Resulsts: Weapon storage incidentDeputy Black": // day 6
                    emailAnswers = emailAnswers + "Results: explosive search_Results: explosive search_Sir, I wasnt able to find anything related to this explosive device. Shooting at the docks may have something to do with it tho._Deputy Black|";
                    Debug.Log("Resulsts: Weapon storage incidentDeputy Black");
                    break;
                case "Resulsts: Weapon storage incidentDeputy Weiß": // day 6
                    emailAnswers = emailAnswers + "Hi serg, I wasnt able to find any indications of any bombs. There was shooting at the docks, maybe something could be there?_Molly Weiß|";
                    Debug.Log("Resulsts: Weapon storage incidentDeputy Weiß");
                    break;
                case "Finish the jobDeputy Weiß": // day 7
                    emailAnswers = emailAnswers + "Im leaving_Im leaving_Sergeant, we got the bastard, but ive realized policework isnt for me. Im leaving to go help The future party and Ms Grau in getting out of prison._Molly Weiß|";
                    Debug.Log("Finish the jobDeputy Weiß");
                    break;
                case "Time to finish the jobDeputy Weiß": // day 7
                    emailAnswers = emailAnswers + "Im leaving_Im leaving_Sergeant, we got the bastard, but ive realized policework isnt for me. Im leaving to go help The future party and Ms Grau in getting out of prison._Molly Weiß|";
                    Debug.Log("Time to finish the jobDeputy Weiß");
                    break;
                case "Finish the jobDeputy Black": // day 7
                    emailAnswers = emailAnswers + "Mixed news_Mixed news_We were able to get Mr Grau and put him into jail with the help of deputy Black but unfortunately he lost his life in the fight. If you need support be sure to contact me._Lieutenant Stadt|";
                    Debug.Log("Finish the jobDeputy Black");
                    break;
                case "Time to finish the jobDeputy Black": // day 7
                    emailAnswers = emailAnswers + "Mixed news_Mixed news_We were able to get Mr Grau and put him into jail with the help of deputy Black but unfortunately he lost his life in the fight. If you need support be sure to contact me._Lieutenant Stadt|";
                    Debug.Log("Time to finish the jobDeputy Black");
                    break;
            }
        }
        toDoList.Clear();
        return emailAnswers;
    }
}