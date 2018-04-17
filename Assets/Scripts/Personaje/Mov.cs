using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mov : MonoBehaviour {
	public float rapidez = 5f;
	public float salto = 250f;
	public int b = 0;

	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update () {
		Movimiento();
		/**if (Input.GetKey (KeyCode.RightArrow)) {
			anim.SetInteger ("Estado", 2);
		}
		if(Input.GetKey(KeyCode.LeftArrow)){
			anim.SetInteger ("Estado", 1);
		}
		if(Input.GetKey(KeyCode.UpArrow) && b==0){
			anim.SetInteger ("Estado", 0);
		}*/
	}

	void Movimiento(){
		if (Input.GetKey (KeyCode.RightArrow)) {
			transform.Translate (Vector2.right * rapidez * Time.deltaTime);
		}

		if(Input.GetKey(KeyCode.LeftArrow)){
			transform.Translate (Vector2.left * rapidez * Time.deltaTime);
		}

		if(Input.GetKey(KeyCode.UpArrow) && b==0){
			b=1;
			GetComponent<Rigidbody2D>().AddRelativeForce(new Vector2(0, salto));
			GetComponent<Rigidbody2D>().AddRelativeForce(new Vector2(0, 0));
		}
	}

	void OnCollisionEnter2D(Collision2D collision)
	{
		if (collision.collider.CompareTag("Suelo")){
			b = 0;
		}
	}
}