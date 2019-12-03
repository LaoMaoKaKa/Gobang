using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class S2Btn : MonoBehaviour {
    public GameObject BqWin;
    public GameObject WinPlane;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void FhBtn() {
        SceneManager.LoadScene("Sta");
    }
    public void AgainBtn()
    {
        SceneManager.LoadScene("S2");
    }
    public void RsBtn() {
        Gamemanager.Ins.IsWinSet(2);
        BqWin.SetActive(true);
        WinPlane.SetActive(true);
    }
}
