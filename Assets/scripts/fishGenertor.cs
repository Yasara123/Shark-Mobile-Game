using UnityEngine;
using System.Collections;

public class fishGenertor : MonoBehaviour {

	public GameObject fish;
	
	// Use this for initialization
	void Start()
	{
		InvokeRepeating("CreateObstacle", 1f, 4f);
	}


	void CreateObstacle()
	{
		Instantiate(fish);
	}
}
