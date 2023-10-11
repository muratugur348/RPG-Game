using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Mover : MonoBehaviour
{
    [SerializeField] private Transform _target;

    [SerializeField] private NavMeshAgent _navMeshAgent;

    private Ray _ray;
    private Camera _mainCam;

    private void Start()
    {
        _mainCam = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        SendRay();
        //Move();
    }

    private void SendRay()
    {
        if (Input.GetMouseButtonDown(0))
        {
            _ray = _mainCam.ScreenPointToRay(Input.mousePosition);
            MoveToCursor();
        }

        Debug.DrawRay(_ray.origin, _ray.direction, Color.green, 50);
    }

    private void MoveToCursor()
    {
        bool hasHit = Physics.Raycast(_ray, out RaycastHit hit);
        if (hasHit)
        {
            _navMeshAgent.SetDestination(hit.point);
            print(hit.point);
        }
    }

    private void Move()
    {
        _navMeshAgent.SetDestination(_target.position);
    }
}