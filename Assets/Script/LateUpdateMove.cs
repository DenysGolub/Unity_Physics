﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LateUpdateMove : MonoBehaviour
{
    public float movementSpeed = 0.5f;
    void LateUpdate()
    {
        this.transform.Translate(0, 0, Time.deltaTime*movementSpeed);
    }
}
