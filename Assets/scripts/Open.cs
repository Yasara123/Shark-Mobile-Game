using UnityEngine;
using System.Collections;

public class Open : MonoBehaviour {

		public string FirstLevel;
		public void Update(){
			//if(!Input.GetMouseButtonDown(0))
		if(Input.touchCount > 0)
				return;
			
			Application.LoadLevel(FirstLevel);
		}
		


}
