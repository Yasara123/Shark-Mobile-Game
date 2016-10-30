using UnityEngine;
using System.Collections;

public class JellyFishAction : MonoBehaviour {
	public GameObject JellyFish;
	int score = 0;
	
	// Use this for initialization
	void Start()
	{
		InvokeRepeating("CreateObstacle", 2f, 6f);
	}
	
	// Update is called once per frame
	void OnGUI () 
	{
		Score.Display ();
	}
	
	void CreateObstacle()
	{
		Instantiate(JellyFish);
	}
}
