using OpenAI;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCInteractable : MonoBehaviour
{
    private void Start()
    {
        GameObject test = gameObject.transform.GetChild(3).gameObject;
        test.SetActive(false);
    }

    public void Interact()
    {
        GameObject test = gameObject.transform.GetChild(3).gameObject;
        test.SetActive(true);
    }
}
