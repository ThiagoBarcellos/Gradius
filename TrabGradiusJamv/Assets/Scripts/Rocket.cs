using UnityEngine;
using System.Collections;

public class Rocket : MonoBehaviour {
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate(Vector2.up /* Time.deltaTime */* 3);
		if (transform.position.x >= 610)
		{
			MovimentoNave.Ntiros -= 1;
			Destroy (this.gameObject);
		}
	}

	void OnCollisionEnter2D(Collision2D coll)
	{
		//if(gameObject.tag != "rocket")
		//{
			MovimentoNave.Ntiros -= 1;
			Destroy (this.gameObject);
		//}
		

	}	

	/*void OnBecameInvisible()
	{
		Destroy (gameObject);
		MovimentoNave.Ntiros -= 1;
	}*/
}
