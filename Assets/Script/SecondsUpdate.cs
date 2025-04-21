using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondsUpdate : MonoBehaviour
{
    float timeStartOffSet = 0;
    bool gotStartTime = false;
    public float movementSpeed = 0.5f;

    void Update()
    {
        if(!gotStartTime) {
            timeStartOffSet = Time.realtimeSinceStartup;
            gotStartTime = true;
        }

        this.transform.position = new Vector3(this.transform.position.x,
                                            this.transform.position.y,
                                            (Time.realtimeSinceStartup - timeStartOffSet)*movementSpeed);
    }
}
