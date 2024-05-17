using System.Collections;
using System.Collections.Generic;
using RPG.Quests;
using UnityEngine;

public class LineToJohn : MonoBehaviour
{
    public LineRenderer lineRenderer;

    public GameObject player;
    public QuestList playerQuestList;

    public GameObject john;
    public GameObject shop;

    public float offset;

    // Update is called once per frame
    void Update()
    {
        lineRenderer.SetPosition(0, player.transform.position + new Vector3(0, offset, 0));
        if (playerQuestList.statuses.Count == 1)
        {
            lineRenderer.SetPosition(1, shop.transform.position + new Vector3(0, offset, 0));
        }
        else
        {
            lineRenderer.SetPosition(1, john.transform.position + new Vector3(0, offset, 0));
        }
    }

    public void Close()
    {
        gameObject.SetActive(false);
    }
}