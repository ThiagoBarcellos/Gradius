using UnityEngine;
using System.Collections;

public class Rocket : MonoBehaviour {
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate(Vector2.up /* Time.deltaTime */* 3);
	}

	void OnCollisionEnter2D(Collision2D coll)
	{
		if(GameObject.FindGameObjectWithTag("inimigo"))
		{
			MovimentoNave.Ntiros -= 1;
			Destroy (this.gameObject);
		}
		if(GameObject.FindGameObjectWithTag("rocket"))
		{
			
		}
	}	

	/*void OnBecameInvisible()
	{
		Destroy (gameObject);
		MovimentoNave.Ntiros -= 1;
	}*/
}
