using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SphereController : MonoBehaviour {
	public Text textDesc;
	public Vector3 lastPosition;
	// Use this for initialization
	void Start () {
		lastPosition = transform.position;	
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void ZoomObj(){
		 /*if (lastPosition.z != -8) {
            lastPosition = new Vector3(lastPosition.x, lastPosition.y, lastPosition.z - 0.5f);
            transform.position = lastPosition;
        }*/
        textDesc.gameObject.SetActive(true);
	}

}
