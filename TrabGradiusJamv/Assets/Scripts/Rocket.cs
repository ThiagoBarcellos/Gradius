using UnityEngine;
using System.Collections;

public class Rocket : MonoBehaviour {
	void Start () {
	
	}
	void Update () {
			transform.Translate(Vector2.up * Time.deltaTime * 50f);
			if (transform.position.y >= 280)
			{
				MovimentoNave.Ntiros -= 1;
				Destroy (this.gameObject);
			}
	}

	void OnCollisionEnter2D(Collision2D coll)
	{
			if(coll.gameObject.tag != "Player" && coll.gameObject.tag != "rocket"){
				MovimentoNave.Ntiros -= 1;
				Destroy (this.gameObject);
			}
	}	
}
