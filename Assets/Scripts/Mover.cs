﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Mover : MonoBehaviour

{
  [SerializeField] Transform target;

  void Update()
  {
    if (Input.GetMouseButtonDown(0))
    {
      MoveToMousePosition();
    }
  }

  private void MoveToMousePosition()
  {
    Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition); ;
    RaycastHit hit;
    bool hasHit = Physics.Raycast(ray, out hit);

    if (hasHit)
    {
      GetComponent<NavMeshAgent>().destination = hit.point;
    }
  }
}