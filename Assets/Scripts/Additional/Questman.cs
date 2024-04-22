using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Questman : MonoBehaviour
{
    public GameObject interactionButton;
    
    public void ChangeActivityOfButton(bool value)
    {
        interactionButton.SetActive(value);
    }
}
