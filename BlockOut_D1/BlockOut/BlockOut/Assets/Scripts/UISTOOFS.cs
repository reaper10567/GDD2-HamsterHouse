using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class UISTOOFS : MonoBehaviour {
	bool showGui = false;
	Transform character;
	GameObject[] interactables;
	// Use this for initialization
	void Start () {
		character = GameObject.FindGameObjectWithTag("Player").transform;
		interactables = GameObject.FindGameObjectsWithTag("Interactable");
	}
	
	// Update is called once per frame
	void Update () {
		for(int i=0; i < interactables.Length; i++)
		{
			if(Vector3.Distance(interactables[i].transform.position, character.position)<= 5)
			{
				showGui = true;
				if(Input.GetKeyDown(KeyCode.E))
				{
					interactables[i].SetActive(false);
					GameObject.Destroy(interactables[i]);
					interactables[i]=null;
					showGui = false;
				}
				return;
			}
		}
		showGui = false;
	}

	void OnGUI()
	{
		print(showGui);
		if(showGui)
		{
			GUI.Box(new Rect(0,880,1920,200),"Press E to interact with the object");
		}
	}
}
