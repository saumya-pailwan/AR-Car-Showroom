using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class infoPanelAnim : MonoBehaviour {
	
	Animator anim;
	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	public void playSlide () {
		anim.Play ("infoPanel");
	}

	public void closeSlide () {
		anim.Play ("infoPanelRev");
	}
}

