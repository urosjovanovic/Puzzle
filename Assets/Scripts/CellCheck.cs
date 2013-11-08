using UnityEngine;
using System.Collections;

public class CellCheck : MonoBehaviour {
	public bool filled = false;
	
	void OnTriggerEnter(Collider other)
	{
		filled = true;
		//Debug.Log (other.gameObject.name);
	}
	
	void OnTriggerStay(Collider other)
	{
		filled = true;
	}
	
	void OnTriggerExit(Collider other)
	{
		filled = false;
	}
}
