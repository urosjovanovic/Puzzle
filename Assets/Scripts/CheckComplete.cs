using UnityEngine;
using System.Collections;

public class CheckComplete : MonoBehaviour {
	
	public Transform gamedone;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		bool solved = true;

		foreach(Transform child in gameObject.transform)
		{
		        if(child.gameObject.GetComponent<CellCheck>().filled == false)
					solved = false;
		}
		
		if(solved)
		{
			Debug.Log ("YOU COMPLETED THE GAME!");
			gamedone.gameObject.SetActive(true);
		}
		
	}
}
