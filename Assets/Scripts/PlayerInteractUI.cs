using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteractUI : MonoBehaviour
{
    [SerializeField] private GameObject containerGameObject;
    [SerializeField] private PlayerInteract playerInteract;


    private void Update()
    {
        if(playerInteract.GetInteractableObject() != null)
        {
            Show();
        }
        else
        {
            Hide();
        }
    }
    void Show()
    {
        containerGameObject.SetActive(true);
    }

   
    void Hide()
    {
        containerGameObject.SetActive(false);
    }
}
