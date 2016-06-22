using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {
	private bool movimentovertical= true;

	float speed = 2f;
	float speedfrente = -1f;

	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (Vector2.up * speed);
		transform.Translate (Vector2.right *speedfrente );

		if(transform.position.y > 230f)
		{
			speed = -2f;
		}
		if(transform.position.y < 26f)
		{
			speed = 2f;
		}


	}

	void OnCollisionEnter2D(Collision2D coll)
	{
		//Debug.Log("LOL");
		Destroy (this.gameObject);
	}
}
