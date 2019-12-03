using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public enum PointType
{
    Null,
    Break,
    Write
}

public class Gamemanager : MonoBehaviour {
    private static Gamemanager ins;
    public static Gamemanager Ins {
        get {
            if (ins==null) {
                ins = GameObject.Find("Gamemanager").GetComponent<Gamemanager>();
            }
            return ins;
        }
    }
    private PointSx[,] Points=new PointSx[15,15];
    public PointSx[,] _Points {
        get {
            return Points;
        }
    }
    public void PoinsAdd(int a,int b,PointSx c) {
        Points[a, b] = c;
    }
    public void SetPointTpye(PointType c,int a,int b) {
        Points[a, b].Type = c;
    }

    private int  IsWin = 0;
    public int _IsWin {
        get {
            return IsWin;
        }
    }
    public void IsWinSet(int c) {
        IsWin = c;
    }
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
       /* if (Input.GetKeyDown(KeyCode.Space))
        {
            for (int i = 0; i < 200000; i++)
            {
                Debug.Log(i);
            }
        }*/

      /*  if (Input.GetKeyDown(KeyCode.Space)) {
            for (int i = 0; i < 15; i++)
            {
                for (int j = 0; j < 15; j++)
                {
                    Debug.Log(Points[i,j].Point +"  " + Points[i, j].Type + "  " + Points[i, j].x + "," + Points[i, j].y);
                   // Debug.Log(Points[i, j].Type);
                }
            }
        }*/
	}
}
