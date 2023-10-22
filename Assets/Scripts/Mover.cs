using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using UnityEngine;
using UnityEngine.AI;

public class Mover : MonoBehaviour
{
    [SerializeField] private NavMeshAgent _navMeshAgent;

    [SerializeField] private Animator _animator;

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
        if (Input.GetMouseButton(0))
        {
            _ray = _mainCam.ScreenPointToRay(Input.mousePosition);
            MoveToCursor();
        }

        UpdateAnimator();
    }

    private void MoveToCursor()
    {
        bool hasHit = Physics.Raycast(_ray, out RaycastHit hit);
        if (hasHit)
        {
            _navMeshAgent.SetDestination(hit.point);
        }
    }

    private void UpdateAnimator()
    {
        Vector3 velocity = _navMeshAgent.velocity;
        Vector3 localVelocity = transform.InverseTransformDirection(velocity);
        float speed = localVelocity.z;
        _animator.SetFloat("forwardSpeed", speed);
    }
}