using System.Collections;
using System.Collections.Generic;
using RPG.Control;
using UnityEngine;

namespace RPG.Quests
{
    public class QuestGiver : MonoBehaviour
    {
        [SerializeField] Quest quest;

        public void GiveQuest()
        {
            QuestList questList = GameObject.FindGameObjectWithTag("Player").GetComponent<QuestList>();
            GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>().myQuest = quest;
            
            questList.AddQuest(quest);
        }

    }

}