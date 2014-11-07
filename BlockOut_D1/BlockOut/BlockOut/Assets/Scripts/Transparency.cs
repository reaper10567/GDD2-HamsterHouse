using UnityEngine;
using System.Collections;

public class Transparency : MonoBehaviour {

	// Use this for initialization
	void Start () {
		if (this.gameObject.tag == "window") {
			Color color1 = this.renderer.material.color;
			color1.a = 0.9f; 
			this.renderer.material.color = color1;
		}
		Color color2 = this.renderer.material.color;
		color2.a = 0.5f; 
		this.renderer.material.color = color2;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
