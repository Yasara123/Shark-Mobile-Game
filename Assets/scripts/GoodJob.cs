using UnityEngine;
using System.Collections;

public class GoodJob : MonoBehaviour {
	public  GameObject Congradulate;
	private static string str="fall";
	// Use this for initialization
	void Start () {
		this.renderer.enabled = false;
	}
	void update () {
		if (str.CompareTo ("win") == 0) {
			Congradulate.renderer.enabled = true;
			Player.Destroy(Player.play);
		}
	}

	public static void OnCollisionEnter2D(string Obj){
		if (Obj.CompareTo ("Mermaid") == 0)
			str="win";
	}
}
