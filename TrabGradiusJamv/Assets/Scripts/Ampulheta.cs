using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ampulheta : MonoBehaviour {

	float speedbaixo = 30f;

	void Start () {
		
	}
	
	void Update () {
		transform.Translate (Vector2.down * speedbaixo * Time.deltaTime);

		if (transform.position.y <= -23)
		{
			Destroy (this.gameObject);
		}

		//GetComponentInChildren<Transform> ().Rotate (Vector3.forward * speedbaixo);
	}

	/*void OnColissionenter2D(Collider2D coll){
		Debug.Log ("bateu1");
		if (coll.gameObject.tag == "Player") {
			Debug.Log ("bateu1");
			SceneManager.ContagemReg += 15;
			Destroy (this);
		}
	}*/
}
