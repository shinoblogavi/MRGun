using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fly : MonoBehaviour {

	// Use this for initialization
	void Start () {
        //gameObject.AddComponent<Rigidbody>();
        //gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(0, 200, 400));
        //Vector3 moveForward = Camera.main.transform.forward * 500;
        //this.GetComponent<Rigidbody>().AddForce(moveForward);
    }

    // Update is called once per frame
    void Update()
    {
        transform.SetPositionAndRotation(
            UnityEngine.XR.InputTracking.GetLocalPosition(UnityEngine.XR.XRNode.RightHand),
            UnityEngine.XR.InputTracking.GetLocalRotation(UnityEngine.XR.XRNode.RightHand)
            );
        transform.Rotate(new Vector3(1, 0, 0), 25);

        //if (Input.GetKeyDown("joystick button 15"))
        //{
        //    gameObject.AddComponent<Rigidbody>();
        //    gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(0, 200, 400));
        //}
    }

}
