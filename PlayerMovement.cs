using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

	public float speed;
	public float jumpspeed;
	public bool isjumping;
	
	void Start (){
		}
	void Update () { 

		//moving left and right
				if (Input.GetKey (KeyCode.D)) {
						rigidbody2D.AddForce (Vector2.right * speed);

				}
				if (Input.GetKey (KeyCode.A)) {
						rigidbody2D.AddForce (-Vector2.right * speed);
				}

		//jumping
				if (Input.GetKey (KeyCode.W)) {

			if (isjumping==false){
						rigidbody2D.AddForce (Vector2.up * jumpspeed );
				isjumping = true;

				}

				//if (Input.GetKey (KeyCode.S)) {
						//rigidbody2D.AddForce (-Vector2.up * speed);
				}





	}
	void OnCollisionEnter2D (Collision2D col)
	{
		if(col.gameObject.tag == "ground")
		{
			isjumping = false;
		}}
}
