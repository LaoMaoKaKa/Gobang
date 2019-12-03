using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class AddBtn : MonoBehaviour {

    public GameObject Btn;
    public RectTransform Re;
    
	// Use this for initialization
	void Start () {
      
  
        for (int i = 0; i < 15; i++)
        {
            for (int j = 0; j < 15; j++)
            {
                GameObject s = Instantiate(Btn, transform);
                Re = s.GetComponent<RectTransform>();
                Re.localPosition = new Vector3(29.5f*j-(29.5f*14/2)-2,29.5f*i- (29.5f * 14 / 2)+22, 0);
                s.GetComponent<Btn>().SetBtnXY(j,i);
                PointSx Sx = new PointSx();
                Sx.x = j;
                Sx.y = i;
                Sx.Point= new Vector3(29.5f * j - (29.5f * 14 / 2)-2 , 29.5f * i - (29.5f * 14 / 2) + 22, 0);
                Gamemanager.Ins.PoinsAdd(i,j,Sx);
            }
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
