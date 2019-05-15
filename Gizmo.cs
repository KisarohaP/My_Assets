﻿using UnityEngine;
using System.Collections;

//for dabag

public class Gizmo : MonoBehaviour
{

    public float gizmoSize = 0.3f;
    public Color gizmoColor = Color.yellow;

    void OnDrawGizmos()
    {
        Gizmos.color = gizmoColor;
        Gizmos.DrawWireSphere(transform.position, gizmoSize);
    }
}
