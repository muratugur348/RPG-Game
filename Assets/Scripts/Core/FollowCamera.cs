using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace RPG.Core
{
public class FollowCamera : MonoBehaviour
{
    [SerializeField] private Transform _target;

    private Camera _mainCam;

    private void Start()
    {
        _mainCam = Camera.main;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = _target.position;
    }
}
}