using UnityEngine;
using System.Collections;

public class JellyFish : MonoBehaviour {

	public Vector2 velocity = new Vector2(-3, -1);
	public float range = 6;
	
	// Use this for initialization
	void Start()
	{
		rigidbody2D.velocity = velocity;
		transform.position = new Vector3(transform.position.x, transform.position.y - range * Random.value, transform.position.z);
	}
	void OnCollisionEnter2D(Collision2D other)
	{
		Player.OnCollisionEnter2D("Jelly");
		//disappear ();
	}
//	void disappear()
	//{	
	//	Destroy(this.gameObject, 0.1f);
	//}
}
