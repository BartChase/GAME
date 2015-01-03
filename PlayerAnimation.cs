using UnityEngine;
using System.Collections;

public class PlayerAnimation : MonoBehaviour {

	public Animator anim;

	void Start () {
		anim = GetComponent<Animator>();
	
	}

	void Update () {
		if(Input.GetKey(KeyCode.A)){
			anim.SetBool("left", true);
			anim.SetBool("right", false);
			}
		if(Input.GetKey(KeyCode.D)){
			anim.SetBool("right", true);
			anim.SetBool("left", false);
		}
		if(Input.GetKey(KeyCode.W)){
			anim.SetBool("jump", true);
			anim.SetBool("left", false);
			anim.SetBool("right", false);
		}

		if (Input.GetKey (KeyCode.A)) {
			anim.SetBool ("walkleft", true);
		} else {
			anim.SetBool ("walkleft", false);
		}
		if (Input.GetKey (KeyCode.D)) {
			anim.SetBool ("walkright", true);
		} else {
			anim.SetBool ("walkright", false);
		}
		if (Input.GetKey (KeyCode.W)) {
			anim.SetBool ("jump", true);
		} else {
			anim.SetBool ("jump", false);
		}

		}
}
