using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VR;

public class Affforce : MonoBehaviour {

	// Use this for initialization
	void Start () {
        //gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(0, 200, 400));
        //Vector3 moveForward = Camera.main.transform.forward * 1000;
        //Vector3 moveForward = UnityEngine.XR.InputTracking.GetLocalRotation(UnityEngine.XR.XRNode.RightHand).eulerAngles * 1000;
        //Debug.Log("controller : " + moveForward);
        //Debug.Log("head : " +Camera.main.transform.forward * 1000);
        this.GetComponent<Rigidbody>().AddForce(transform.forward * 5000);
    }

    // Update is called once per frame
    void Update () {
		
	}
}
