using UnityEngine;
using System.Collections;

public class YFishGenerator : MonoBehaviour {

	public  GameObject fish;
	
	// Use this for initialization
	void Start()
	{
		InvokeRepeating("CreateObstacle", 1f, 3f);
	}
	
	void CreateObstacle()
	{
		Instantiate(fish);
	}

}
