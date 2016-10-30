using UnityEngine;

public class Player : MonoBehaviour
{	public static GameObject play;
	// The force which is added when the player jumps
	// This can be changed in the Inspector window
	public Vector2 forward = new Vector2(200, 0);
	public Vector2 up = new Vector2(0, 200);
	public Vector2 down = new Vector2(0, -200);
	public Vector2 back = new Vector2(-200, 0);
	public Vector2 push = new Vector2(500, 0);

	// Update is called once per frame
	void Update ()
	{ var speed =( float ) 0.04;
		// Jump
		/*
		if (Input.GetKeyUp("6"))
		{
			rigidbody2D.velocity = Vector2.zero;
			rigidbody2D.AddForce(forward);
		}
		if (Input.GetKeyUp("4"))
		{
			rigidbody2D.velocity = Vector2.zero;
			rigidbody2D.AddForce(back);
		}
		if (Input.GetKeyUp("8"))
		{
			rigidbody2D.velocity = Vector2.zero;
			rigidbody2D.AddForce(up);
			
		}
		if (Input.GetKeyUp("2"))
		{
			rigidbody2D.velocity = Vector2.zero;
			rigidbody2D.AddForce(down);
		}*/


		if (Input.touchCount > 0 && 
		    Input.GetTouch(0).phase == TouchPhase.Moved) {
			
			// Get movement of the finger since last frame
			var touchDeltaPosition=(Vector2) Input.GetTouch(0).deltaPosition;
			
			// Move object across XY plane
			transform.Translate ((float)touchDeltaPosition.x * speed, 
			                     (float)touchDeltaPosition.y * speed, (float)0.0);
		}
		// Die by being off screen
		Vector2 screenPosition = Camera.main.WorldToScreenPoint(transform.position);
		if (screenPosition.y > Screen.height || screenPosition.y < 0)
		{ 
			Die();
		}
	}
	
	// Die by collision
	public static void OnCollisionEnter2D(string Obj)
	{	Mermaid.OnCollisionEnter2D("Player"); 
		//ShellStart.OnCollisionEnter2D("shell"); 
		if (Obj.CompareTo ("Blue") == 0) {
			Score.UpScore ();
			Score.UpScore ();
		} else if (Obj.CompareTo ("Yellow") == 0) {
			Score.UpScore ();
		}else if (Obj.CompareTo ("Pearl") == 0) {
				Score.UpScore ();
			    Score.UpScore ();
				Score.UpScore ();
				Score.UpScore ();
				Score.UpScore ();
				Score.UpScore ();
		} else if (Obj.CompareTo ("Jelly") == 0) {
			Die ();
		}
	}
	
	static void Die()
	{	
		Application.LoadLevel(Application.loadedLevel);
		Score.ReScore ();
	}
}