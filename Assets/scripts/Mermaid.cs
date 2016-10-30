using UnityEngine;
using System.Collections;

public class Mermaid : MonoBehaviour {
	public GameObject Maid;
	// Use this for initialization
	void Start () {
		this.renderer.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (Score.score >= 25) {
			this.renderer.enabled =true;
		}

	}
	
	public static void OnCollisionEnter2D(string Obj)
	{	

		if (Obj.CompareTo ("Player") == 0) {
			GoodJob.OnCollisionEnter2D("Mermaid");

		}
	}
}
