using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class MovimentoNave : MonoBehaviour {

	public static int Ntiros = 0;
	public GameObject missil;
	public GameObject nave;
	private float speed = 2;

	[SerializeField]
	private GameObject spawnPoint;
	
	void Start () {

	}

	void OnCollisionEnter2D(Collision2D coll)
	{
		if (coll.gameObject.tag == "inimigo1" || coll.gameObject.tag == "inimigo2" || coll.gameObject.tag == "inimigo3") {
			Destroy (this.gameObject);
			if (SceneManager.PontuacaoMax < SceneManager.Pontuacao) {
				SceneManager.PontuacaoMax = SceneManager.Pontuacao;
				UnityEngine.SceneManagement.SceneManager.LoadScene (2);
			} 
			else {
				UnityEngine.SceneManagement.SceneManager.LoadScene (2);
			}
		}
		if (coll.gameObject.tag == "ampulheta") {
			SceneManager.ContagemReg += 15;
			Destroy (coll.gameObject);
		}
	}
	
	void Update ()
	{
		float upDown = Input.GetAxis ("Vertical") * speed * -40f * Time.deltaTime;
		float rightLeft = Input.GetAxis ("Horizontal") * speed * -40f * Time.deltaTime;
		this.transform.Translate (rightLeft, upDown, 0f);

		if (Ntiros < 5 && Input.GetKeyDown (KeyCode.Space)) {
			Instantiate (missil, spawnPoint.transform.position, missil.transform.localRotation);
			Ntiros++;
		}

		if (this.transform.position.x <= 178f) {
			this.transform.position = new Vector2(178f,this.transform.position.y);
		}
		if (this.transform.position.x >= 403f) {
			this.transform.position = new Vector2(403f,this.transform.position.y);
		}
		if (this.transform.position.y >= 220f) {
			this.transform.position = new Vector2(this.transform.position.x,220f);
		}
		if (this.transform.position.y <= -17f) {
			this.transform.position = new Vector2(this.transform.position.x,-17f);
		}
	}
}