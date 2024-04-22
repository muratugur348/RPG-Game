using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestInteractionButton : MonoBehaviour
{
    private Camera _mainCam;
    private void Start()
    {
        _mainCam = Camera.main;
    }
    private void Update()
    {
        transform.LookAt(_mainCam.transform);
    }
}
