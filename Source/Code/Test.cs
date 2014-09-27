using UnityEngine;
using System.Collections;

public class Test : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnGUI(){
		if (GUILayout.Button ("Shake")) {
			StartCoroutine(CameraShake.Shake(this.transform));
		}

		if (GUILayout.Button ("Shake")) {
			StartCoroutine(CameraShake.Shake(this.transform,0.15f));
		}
	}
}
