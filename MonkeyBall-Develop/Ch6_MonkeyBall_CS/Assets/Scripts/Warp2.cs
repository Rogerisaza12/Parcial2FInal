using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Warp2 : MonoBehaviour {

    public Transform point2;

    public void OnTriggerEnter(Collider other)
    {
        //move the monkey to the respawn point
        other.transform.position = point2.position;
        //stop them from moving wildly out of control
        other.attachedRigidbody.velocity = Vector3.zero;
    }
}
