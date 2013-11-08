using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {
	
	public bool selected=false;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
		if(!selected)
		{
			(this.gameObject.GetComponent("Halo") as Behaviour).enabled = false;
			return;
		}
		
		(this.gameObject.GetComponent("Halo") as Behaviour).enabled = true;
		
		if(Input.GetKeyDown(KeyCode.UpArrow))
		{
			transform.position += new Vector3(0,0,1);	
		}
		if(Input.GetKeyDown(KeyCode.DownArrow))
		{
			transform.position += new Vector3(0,0,-1);	
		}
		if(Input.GetKeyDown(KeyCode.LeftArrow))
		{
			transform.position += new Vector3(-1,0,0);	
		}
		if(Input.GetKeyDown(KeyCode.RightArrow))
		{
			transform.position += new Vector3(1,0,0);	
		}
	}
}
