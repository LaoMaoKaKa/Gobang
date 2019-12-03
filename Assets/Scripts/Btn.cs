using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Btn : MonoBehaviour {
    private GameObject BlackChess;
    private GameObject WriteChess;
    private RectTransform Re;
    private int Btnx = 0;
    private int Btny = 0;
    private GameObject AI;
    private GameObject WinPhoto;
    // Use this for initialization
    void Start() {
        BlackChess = Resources.Load<GameObject>("Chess/Hq");
        WriteChess = Resources.Load<GameObject>("Chess/Bq");
        WinPhoto = Resources.Load<GameObject>("Win/BlackWin");
        AI = GameObject.Find("Canvas/AI");
    }

    // Update is called once per frame
    void Update() {

    }
    public void XqBtn() {
        if (Gamemanager.Ins._IsWin==0) {
            if (Gamemanager.Ins._Points[Btnx, Btny].Type == PointType.Null)
            {
                GameObject Chess = Instantiate(BlackChess, transform);
                Re = Chess.GetComponent<RectTransform>();
                Re.localPosition = new Vector3(0, 0, 0);
                Gamemanager.Ins.SetPointTpye(PointType.Break, Btnx, Btny);

                Js(Btnx, Btny);

                if (Gamemanager.Ins._IsWin == 0) {
                    AI.GetComponent<AI>().Selecte();
                }
                
            }

        }
    }
    public void SetBtnXY(int a, int b) {
        Btnx = a;
        Btny = b;
    }
    void Js(int x, int y) {
        int CountX = 1;
        int CountY = 1;
        int CountUpLeft = 1;
        int CountUpRight = 1;
        for (int i = 1; i < 15; i++)
        {
            if (x + i < 15)
            {
                if (Gamemanager.Ins._Points[x + i, y].Type == PointType.Break)
                {
                    CountX++;
                }
                else
                {
                    break;
                }
            }
            else {
                break;
            }

        }
        for (int i = 1; i < 15; i++)
        {
            if (x - i >= 0)
            {
                if (Gamemanager.Ins._Points[x - i, y].Type == PointType.Break)
                {
                    CountX++;
                }
                else
                {
                    break;
                }
            }
            else {
                break;
            }
        }
        /////////////
        for (int i = 1; i < 15; i++)
        {
            if (y + i < 15)
            {
                if (Gamemanager.Ins._Points[x, y + i].Type == PointType.Break)
                {
                    CountY++;
                }
                else
                {
                    break;
                }
            }
            else
            {
                break;
            }

        }
        for (int i = 1; i < 15; i++)
        {
            if (y - i >= 0)
            {
                if (Gamemanager.Ins._Points[x, y - i].Type == PointType.Break)
                {
                    CountY++;
                }
                else
                {
                    break;
                }
            }
            else
            {
                break;
            }
        }
        ////////////////
        for (int i = 1; i < 15; i++)
        {
            if (x-i>=0&&y+i<15)
            {
                if (Gamemanager.Ins._Points[x - i, y+i].Type == PointType.Break)
                {
                    CountUpLeft++;
                }
                else
                {
                    break;
                }
            }
            else
            {
                break;
            }

        }
        for (int i = 1; i < 15; i++)
        {
            if (x + i <15 && y-i >=0)
            {
                if (Gamemanager.Ins._Points[x + i, y-i].Type == PointType.Break)
                {
                    CountUpLeft++;
                }
                else
                {
                    break;
                }
            }
            else
            {
                break;
            }
        }
        ///////////////////////////
        for (int i = 1; i < 15; i++)
        {
            if (x + i <15 && y+i<15)
            {
                if (Gamemanager.Ins._Points[x + i, y + i].Type == PointType.Break)
                {
                    CountUpRight++;
                }
                else
                {
                    break;
                }
            }
            else
            {
                break;
            }

        }
        for (int i = 1; i < 15; i++)
        {
            if (x - i >=0 && y - i >= 0)
            {
                if (Gamemanager.Ins._Points[x - i, y - i].Type == PointType.Break)
                {
                    CountUpRight++;
                }
                else
                {
                    break;
                }
            }
            else
            {
                break;
            }
        }
        //////////////

        if (CountX >= 5||CountY>=5||CountUpLeft>=5||CountUpRight>=5) {
            Gamemanager.Ins.IsWinSet(1);
            GameObject.Find("Canvas/OverPlane/Bg/HqWinHint").SetActive(true);
            GameObject.Find("Canvas/OverPlane/Bg").SetActive(true);
            // Instantiate(WinPhoto,GameObject.Find("Canvas").transform);
            //  Debug.Log("恭喜玩家获得胜利！");
            /* 
             if (CountX>=5) {
                  Debug.Log("CountX"+CountX);
              }
              if (CountY >= 5)
              {
                  Debug.Log("CountY" + CountY);
              }
              if (CountUpLeft >= 5)
              {
                  Debug.Log("CountUpLeft" + CountUpLeft);
              }
              if (CountUpRight >= 5)
              {
                  Debug.Log("CountUpRight" + CountUpRight);
              }
              */
        }
    }
}
