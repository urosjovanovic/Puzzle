using UnityEngine;
using System.Collections;

public class GameMain : MonoBehaviour {
	
	public Transform[] parts = new Transform[5];
	int selected=0;
	
	// Use this for initialization
	void Start () {
		for(int i=0; i<parts.Length; i++)
		{
			if(parts[i]!=null)
			{
				parts[i].position = new Vector3(Mathf.Round(Random.Range(-5f,5f))+parts[i].localScale.x/2,
												0,
												Mathf.Round(Random.Range(-3f,3f))+parts[i].localScale.z/2);
				
				if(i==selected)
					parts[i].gameObject.GetComponent<Movement>().selected = true;
			}
		}
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.Tab))
		{
			parts[selected].gameObject.GetComponent<Movement>().selected = false;
			selected = (selected+1)%parts.Length;
			
			parts[selected].gameObject.GetComponent<Movement>().selected = true;
			
			//Debug.Log("Selected: " + parts[selected].gameObject.name);
		}
		
		if(Input.GetKeyDown(KeyCode.Escape))
		{
			Application.Quit();	
		}
	}
}
