using System;
using UnityEngine;
using UnityEngine.Networking;
using System.Collections;
using Inworld.Packet;
using RPG.Quests;

public class QuestManager : MonoBehaviour
{


    public void Goal(string goal, string trigger)
    {
        print("goal2 " + goal + " trigger " + trigger);
        if (trigger.Equals("accept_quest"))
        {
            GetComponent<QuestGiver>().GiveQuest();
        }
    }
   
}
