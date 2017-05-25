using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Warp5 : MonoBehaviour {

    public Transform point1;

    public void OnTriggerEnter(Collider other)
    {
        //move the monkey to the respawn point
        other.transform.position = point1.position;
        //stop them from moving wildly out of control
        other.attachedRigidbody.velocity = Vector3.zero;
    }
}
