using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {
	float speedbaixo = 45f ;

	void Start () {

	}

	void Update () {
		transform.Translate (Vector2.down * speedbaixo * Time.deltaTime);

		if (transform.position.y <= -23)
		{
			Destroy (this.gameObject);
		}
	}

	void OnCollisionEnter2D(Collision2D coll)
	{
		if (coll.gameObject.tag == "rocket") {
			if (this.gameObject.tag == "inimigo1") {
				SceneManager.Pontuacao += 1;
				Destroy (this.gameObject);
			} 
			else if (this.gameObject.tag == "inimigo2") {
				SceneManager.Pontuacao += 2;
				Destroy (this.gameObject);
			} 
			else {
				SceneManager.Pontuacao += 3;
				Destroy (this.gameObject);
			}
		} 
	}
}
