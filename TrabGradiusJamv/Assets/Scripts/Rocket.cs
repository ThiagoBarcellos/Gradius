using UnityEngine;
using System.Collections;

public class Rocket : MonoBehaviour {
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(gameObject.tag == "rocket");
		{
			transform.Translate(Vector2.up /* Time.deltaTime */* 3);
			if (transform.position.x >= 610)
			{
				MovimentoNave.Ntiros -= 1;
				Destroy (this.gameObject);
			}
		}

	if(gameObject.tag == "laser")
		{
		transform.Translate(Vector2.right * -5);
			if (transform.position.x <= -80)
			{
				Destroy (this.gameObject);
			}
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
