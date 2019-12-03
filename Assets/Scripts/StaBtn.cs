using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class StaBtn : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void DanRenPlay() {
        SceneManager.LoadScene("S2");
    }

    public void ExitBtn() {
        Application.Quit();
    }
}
