using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class script : MonoBehaviour {

	public void  ChangeScene(int changeTheScene)
	{
		SceneManager.LoadScene (changeTheScene);

	}


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
