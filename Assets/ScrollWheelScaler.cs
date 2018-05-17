using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollWheelScaler : MonoBehaviour {

    public float scaleMin = 0.5f;
    public float scaleMax = 2.0f;
    public float currentScale = 0.81f;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        currentScale = Mathf.Clamp(currentScale - Input.GetAxis("Mouse ScrollWheel") * 2.5f, scaleMin, scaleMax);
        transform.localScale = new Vector3(currentScale, currentScale, currentScale);
        if(Input.GetKeyDown(KeyCode.R))
        {
            currentScale = 0.81f;
        }
    }
}
