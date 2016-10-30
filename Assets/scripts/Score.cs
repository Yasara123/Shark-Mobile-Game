 using UnityEngine;
//this is for scoring purpose
public class Score : MonoBehaviour
{
	
	public static int score = 0;
	// Update is called once per frame
	public static void Display () 
	{
		GUI.color = Color.white;
		GUI.Box(new Rect(450,10, 70, 30), "Score: " + score.ToString());
	}
	
	public static void UpScore()
	{
		score++;

	}
	public static void DownScore()
	{
		score--;
	}
	public static void ReScore()
	{
		score=0;
	}
	public static int GetScore()
	{
		return score;
	}
}
