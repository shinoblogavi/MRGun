using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {

    public GameObject Prefab;

	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("joystick button 15"))
        {
            GameObject cube = Instantiate(
                Prefab,
                UnityEngine.XR.InputTracking.GetLocalPosition(UnityEngine.XR.XRNode.RightHand),
                UnityEngine.XR.InputTracking.GetLocalRotation(UnityEngine.XR.XRNode.RightHand)
                );
            cube.transform.Rotate(new Vector3(1, 0, 0), 25);
        }
    }
}