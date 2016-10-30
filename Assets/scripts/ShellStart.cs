using UnityEngine;
using System.Collections;

public class ShellStart : MonoBehaviour {
	public GameObject Shell;

	// Use this for initialization
	void Start () {
		this.renderer.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (Score.score >= 15) {
			this.renderer.enabled =true;
		}
		if (Score.score >= 25) {
			this.renderer.enabled =false;
		}
	}

	public static void OnCollisionEnter2D(string Obj)
	{	

		Player.OnCollisionEnter2D("Pearl");
	}
}
