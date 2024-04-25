using System;
using UnityEngine;
using UnityEngine.Networking;
using System.Collections;
using Inworld.Packet;
using RPG.Quests;

public class QuestManager : MonoBehaviour
{

    public void CharacterSelected(string goal)
    {
        //print("CharacterSelected " + goal);
    }
    public void CharacterDeselected(string goal)
    {
        //print("CharacterDeselected " + goal);
    }
    public void CharacterDestroyed(string goal)
    {
       // print("CharacterDestroyed " + goal);
    }
    public void OnBeginSpeaking(string goal)
    {
       // print("OnBeginSpeaking " + goal);
    }
    public void OnEndSpeaking(string goal)
    {
       // print("OnEndSpeaking " + goal);
    }
    public void OnPacketReceived(string goal)
    {
        //print("OnPacketReceived " + goal);
    }
    public void OnCharacterSpeaks(string goal)
    {
       // print("OnCharacterSpeaks " + goal);
    }
    public void OnEmotionChanged(string goal)
    {
       // print("OnEmotionChanged " + goal);
    }
    public void Goal(string goal, string trigger)
    {
        print("goal2 " + goal + " trigger " + trigger);
        if (trigger.Equals("accept_quest"))
        {
            GetComponent<QuestGiver>().GiveQuest();
        }
    }
    public void OnRelationUpdated(string goal)
    {
        //print("OnRelationUpdated " + goal);
    }
    public void DoubleString(string goal, string goal2)
    {
       // print("DoubleString " + goal + " string 2 " + goal2);
    }
}
