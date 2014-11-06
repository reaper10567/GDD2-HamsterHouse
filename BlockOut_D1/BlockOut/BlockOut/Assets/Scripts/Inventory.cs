using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Inventory : MonoBehaviour {
	List<GameObject> theInventory;
	Transform character;
	GameObject[] allItemsInScene;
	// Use this for initialization
	void Start () {
		theInventory = new List<GameObject>();
		character = GameObject.Find("3rd Person Controller").transform;
		allItemsInScene = GameObject.FindGameObjectsWithTag("Item");
	}
	
	// Update is called once per frame
	void Update () {
		for(int i = 0; i < allItemsInScene.Length;i++)
		{
			if(allItemsInScene[i] != null)
			{
			//print(Vector3.Distance(go.transform.position,character.position));
				if(Vector3.Distance(allItemsInScene[i].transform.position,character.position) <= 5)
				{
					//print("Bitchin'");
					if(Input.GetKeyDown(KeyCode.E))
					{
						//print(o);
						theInventory.Add(allItemsInScene[i]);
						allItemsInScene[i].SetActive(false);
						GameObject.Destroy(allItemsInScene[i].renderer);
						allItemsInScene[i] = null;
						return;
					}
				}
			}
		}
	}

	void OnGUI()
	{
		for(int i =0; i < theInventory.Count; i++)
		{
			print("THERES SOMETHING HERE!");
			if(GUI.Button(new Rect(Screen.width-(100*(i+1)),Screen.height-100,100,100),theInventory[i].name))
			{
				break;
			}
		}
	}
}
