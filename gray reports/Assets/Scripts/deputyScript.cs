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
                case "A tip for the caseDeputy Weiß":
                    emailAnswers = emailAnswers + "Home investigation results-Home investigation results-Hi, Weiß here. I checked out Grau's house as you asked. The whole place felt like it'd been abandoned a while ago: there was noBODY there! There were a lot of crazy documents though. Like how his wife is the leader of the Future party and some documents related to someweird people not connected to the Future party. Sucks that the wife's locked up for doing something illegal. I also brained together where these weird extremist people live, so I can go chat them up next, I mean investigate them.-Deputy Weiß|";
                    break;
                case "A tip for the caseDeputy Black":
                    emailAnswers = emailAnswers + "Results: Home Investigation-Results: Home Investigation-The suspect's home has been empty for a roughly 3 days. That's not to say it's without clues. The suspect's wife is the leader of the Future party and Mr Grau has ties to extremist groups around Crimebourgistan. I've singled out the most likely connection to yield us results quickly. I suggest we move on these contacts without delay to learn more.-Deputy Black|";
                    break;
                case "Fire at the Fishing ContestDeputy Weiß":
                    emailAnswers = emailAnswers + "The fire was a set up-The fire was a set up-I think someone has left a rotten egg here, because this fire smells off. Like, all the major clues point to this being a some sort of revenge by Mr Grau on the People's Party, but It's just... Off! Some of the people running this event smile when I look away and guide me to look at the same, obvious clues over and over again. And I can't just say that to their face. It's so stupid! I can't get more out of this scene, but I think we should look into some government officials, especially the ones responsible for this fishing event in this private forest.-Deputy Weiß|";
                    break;
                case "The People's Party CelebratesDeputy Weiß":
                    emailAnswers = emailAnswers + "Mr Grau is connected with assholes-Mr Grau is connected with assholes-These people are crazy! I interrogated the ties found in. I don't know what to make of this other than the scale of their operation: we've stepped into something huge! Oh, and I found out where Mr Grau is hiding. Now we can go talk to him and see what this is all about.-Deputy Weiß|";
                    break;
                case "Fire at the Fishing ContestDeputy Black":
                    emailAnswers = emailAnswers + "Results: Fire Investigation-Results: Fire Investigation-The suspect has seemingly left many tracks at this burned fishing contest. I should note that all evidence regarding Mr Grau was pointed out to me by someone already there. There was no involved thinking on my part; everything was done for me, which leaves me with suspicions.-Deputy Black|";
                    break;
                case "The People's Party CelebratesDeputy Black":
                    emailAnswers = emailAnswers + "Results: Ties Investigation-Results: Ties Investigation-The suspect's ties lips remained somewhat sealed regarding our suspect. They know, however, where the suspect is, and so do we. I should note that this is information they freely gave out, while basically everything else was sealed from me. I suggest we might be stepping into a trap, Sergeant. Even still, I think we should spring their trap with a sure stomp.-Deputy Black|";
                    break;
                case "Time To Finish The JobDebuty Weiß":
                    emailAnswers = emailAnswers + "I'm leaving-I'm leaving-You are wrong, the captain is wrong and Black is wrong! Mr Grau is right and he'll help us reach a utopia without corruption or inequality. I've decided to join him and leave to police force for good. Goodbye-Molly Weiß|";
                    break;
                case "Time To Finish The JobDebuty Black":
                    emailAnswers = emailAnswers + "I'm leaving-I'm leaving-I've come to despise the police work in this town. I thought we relied on facts and truth, but it seems that's not the case. I cannot in good conscience remain at this establishment with what I suspect to be true.-Deputy Black|";
                    break;
            }
        }
        toDoList.Clear();
        return emailAnswers;
    }
}