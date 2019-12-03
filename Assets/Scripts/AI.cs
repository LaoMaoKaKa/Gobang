using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI : MonoBehaviour {

    public GameObject WriteChess;
    //  private int[,] PlayerWeight;
    //  private int[,] EnemyWeight;
    private List<Weight> PlayerWeight = new List<Weight>();
    private List<Weight> EnemyWeight = new List<Weight>();
    private RectTransform Re;
    private Vector3 ChessPoint = new Vector3(0, 0, 0);
    private List<Vector3> RanPoints = new List<Vector3>();

    private int WriteX = 0;
    private int WriteY = 0;
    private GameObject WinPhoto;
    // private List<>
    // Use this for initialization
    void Start () {
        WinPhoto = Resources.Load<GameObject>("Win/WriteWin");
    }

    // Update is called once per frame
    void Update() {
        if (Input.GetKeyDown(KeyCode.Space)) {
            Selecte();
        }
	}
    public void Selecte()
    {
      ///////
        RanPoints.Clear();
        for (int i = 0; i < 15; i++)
        {
            for (int j = 0; j < 15; j++)
            {
                if (Gamemanager.Ins._Points[j,i].Type==PointType.Null) {
                    RanPoints.Add(new Vector3(29.5f * j - (29.5f * 14 / 2)-2, 29.5f * i - (29.5f * 14 / 2)+22, 0));
                }             
                if (j==14&&i==14)
                {               
                    ChessPoint = RanPoints[Random.Range(0, RanPoints.Count)];
                    for (int k = 0; k <15; k++)
                    {
                        for (int l = 0; l < 15; l++)
                        {
                              if (ChessPoint == new Vector3(29.5f * (Gamemanager.Ins._Points[l,k].x) - (29.5f * 14 / 2)-2, 29.5f * (Gamemanager.Ins._Points[l, k].y) - (29.5f * 14 / 2)+22, 0)) {
                                WriteX = k;
                                WriteY = l;                              
                             }
                        }
                    }
                }
            }
        }
        ////////////////////
        for (int i = 0; i < 15; i++)
        {
            for (int j = 0; j < 15; j++)
            {
                if (Gamemanager.Ins._Points[j, i].Type == PointType.Null)
                {
                    JsCan2AndNone(j, i, PointType.Break);
                }
            }
        }
        ////////////////////
        for (int i = 0; i < 15; i++)
        {
            for (int j = 0; j < 15; j++)
            {
                if (Gamemanager.Ins._Points[j, i].Type == PointType.Null)
                {
                    JsCan2AndNone(j, i, PointType.Write);
                }
            }
        }
        ////////////////////
        for (int i = 0; i < 15; i++)
        {
            for (int j = 0; j < 15; j++)
            {
                if (Gamemanager.Ins._Points[j, i].Type == PointType.Null)
                {
                    JsCan3AndTwoOne(j, i, PointType.Break);
                }
            }
        }
        ////////////////////
        for (int i = 0; i < 15; i++)
        {
            for (int j = 0; j < 15; j++)
            {
                if (Gamemanager.Ins._Points[j, i].Type == PointType.Null)
                {
                    JsCan3AndTwoOne(j, i, PointType.Write);
                }
            }
        }
        ////////////////////
        for (int i = 0; i < 15; i++)
        {
            for (int j = 0; j < 15; j++)
            {
                if (Gamemanager.Ins._Points[j, i].Type == PointType.Null)
                {
                    JsCan3AndNone(j, i, PointType.Break);
                }
            }
        }
        ////////////////////
        for (int i = 0; i < 15; i++)
        {
            for (int j = 0; j < 15; j++)
            {
                if (Gamemanager.Ins._Points[j, i].Type == PointType.Null)
                {
                    JsCan3AndNone(j, i, PointType.Write);
                }
            }
        }
        ////////////////////
        for (int i = 0; i < 15; i++)
        {
            for (int j = 0; j < 15; j++)
            {
                if (Gamemanager.Ins._Points[j, i].Type == PointType.Null)
                {
                    JsCan4AndThree(j, i, PointType.Break);
                }
            }
        }
        ////////////////////
        for (int i = 0; i < 15; i++)
        {
            for (int j = 0; j < 15; j++)
            {
                if (Gamemanager.Ins._Points[j, i].Type == PointType.Null)
                {
                    JsCan4AndThree(j, i, PointType.Write);
                }
            }
        }
        ///////////////////
        for (int i = 0; i < 15; i++)
        {
            for (int j = 0; j < 15; j++)
            {
                if (Gamemanager.Ins._Points[j, i].Type == PointType.Null)
                {
                    JsCan4And1NoneAnd1None(j, i, PointType.Break);
                }
            }
        }
        ///////////////////
        for (int i = 0; i < 15; i++)
        {
            for (int j = 0; j < 15; j++)
            {
                if (Gamemanager.Ins._Points[j, i].Type == PointType.Null)
                {
                    JsCan4And1NoneAnd1None(j, i, PointType.Write);
                }
            }
        }
        ///////////////////
        for (int i = 0; i < 15; i++)
        {
            for (int j = 0; j < 15; j++)
            {
                if (Gamemanager.Ins._Points[j, i].Type == PointType.Null)
                {
                    JsCan4AndTwoOne(j, i, PointType.Break);
                }
            }
        }
        ///////////////////
        for (int i = 0; i < 15; i++)
        {
            for (int j = 0; j < 15; j++)
            {
                if (Gamemanager.Ins._Points[j, i].Type == PointType.Null)
                {
                    JsCan4AndTwoOne(j, i, PointType.Write);
                }
            }
        }
        ///////////////////
        for (int i = 0; i < 15; i++)
        {
            for (int j = 0; j < 15; j++)
            {
                if (Gamemanager.Ins._Points[j, i].Type == PointType.Null)
                {
                    JsCan4AndNone(j, i, PointType.Break);
                }
            }
        }
        ///////////////////
        for (int i = 0; i < 15; i++)
        {
            for (int j = 0; j < 15; j++)
            {
                if (Gamemanager.Ins._Points[j, i].Type == PointType.Null)
                {
                    JsCan4AndNone(j, i, PointType.Write);
                }
            }
        }
        ///////////////////
        for (int i = 0; i < 15; i++)
        {
            for (int j = 0; j < 15; j++)
            {
                if (Gamemanager.Ins._Points[j,i].Type==PointType.Null){
                    JsCan5(j,i,PointType.Break);                       
                }
            }
        }
        //////////////////////////
        for (int i = 0; i < 15; i++)
        {
            for (int j = 0; j < 15; j++)
            {
                if (Gamemanager.Ins._Points[j, i].Type == PointType.Null)
                {
                    JsCan5(j, i, PointType.Write);
                }
            }
        }
        ////////////////////
        Xq();

        
    }
    void Xq() {
        GameObject s = Instantiate(WriteChess, transform);
        Re = s.GetComponent<RectTransform>();
        Re.localPosition = ChessPoint;
        Gamemanager.Ins.SetPointTpye(PointType.Write,WriteX,WriteY);
        Debug.Log(WriteX + "," + WriteY);
    }
    void JsCan5(int x, int y,PointType Type)
    {
        int CountX = 1;
        int CountY = 1;
        int CountUpLeft = 1;
        int CountUpRight = 1;
        
        for (int i = 1; i < 15; i++)
        {
            if (x + i < 15)
            {
                if (Gamemanager.Ins._Points[x + i, y].Type == Type)
                {
                    CountX++;
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
            if (x - i >= 0)
            {
                if (Gamemanager.Ins._Points[x - i, y].Type == Type)
                {
                    CountX++;
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
        /////////////
        for (int i = 1; i < 15; i++)
        {
            if (y + i < 15)
            {
                if (Gamemanager.Ins._Points[x, y + i].Type == Type)
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
                if (Gamemanager.Ins._Points[x, y - i].Type == Type)
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
            if (x - i >= 0 && y + i < 15)
            {
                if (Gamemanager.Ins._Points[x - i, y + i].Type == Type)
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
            if (x + i < 15 && y - i >= 0)
            {
                if (Gamemanager.Ins._Points[x + i, y - i].Type == Type)
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
            if (x + i < 15 && y + i < 15)
            {
                if (Gamemanager.Ins._Points[x + i, y + i].Type == Type)
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
            if (x - i >= 0 && y - i >= 0)
            {
                if (Gamemanager.Ins._Points[x - i, y - i].Type == Type)
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

        if (CountX >= 5 || CountY >= 5 || CountUpLeft >= 5 || CountUpRight >= 5)
        {        
            ChessPoint = new Vector3(29.5f * x - (29.5f * 14 / 2)-2, 29.5f * y - (29.5f * 14 / 2)+22, 0);
            WriteX = x;
            WriteY = y;
            if (Type==PointType.Write) {
                  Gamemanager.Ins.IsWinSet(2);
                GameObject.Find("Canvas/OverPlane/Bg/BqWinHint").SetActive(true);
                GameObject.Find("Canvas/OverPlane/Bg").SetActive(true);

                //Instantiate(WinPhoto, GameObject.Find("Canvas").transform);
            }
            //  Gamemanager.Ins.IsWinSet(2);
            // Instantiate(WinPhoto, GameObject.Find("Canvas").transform);
        }
    }
    void JsCan4AndNone(int x,int y,PointType Type) {
        int CountX = 1;
        int CountY = 1;
        int CountUpLeft = 1;
        int CountUpRight = 1;

        for (int i = 1; i < 15; i++)
        {
            if (x + i < 15)
            {
                if (Gamemanager.Ins._Points[x + i, y].Type == Type)
                {
                    CountX++;
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
            if (x - i >= 0)
            {
                if (Gamemanager.Ins._Points[x - i, y].Type == Type)
                {
                    CountX++;
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
        /////////////
        for (int i = 1; i < 15; i++)
        {
            if (y + i < 15)
            {
                if (Gamemanager.Ins._Points[x, y + i].Type == Type)
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
                if (Gamemanager.Ins._Points[x, y - i].Type == Type)
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
            if (x - i >= 0 && y + i < 15)
            {
                if (Gamemanager.Ins._Points[x - i, y + i].Type == Type)
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
            if (x + i < 15 && y - i >= 0)
            {
                if (Gamemanager.Ins._Points[x + i, y - i].Type == Type)
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
            if (x + i < 15 && y + i < 15)
            {
                if (Gamemanager.Ins._Points[x + i, y + i].Type == Type)
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
            if (x - i >= 0 && y - i >= 0)
            {
                if (Gamemanager.Ins._Points[x - i, y - i].Type == Type)
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
        if (CountX == 4)
        {
            int CountNone = 0;
            for (int i = 1; i < 15; i++)
            {
                if (x + i < 15)
                {
                    if (Gamemanager.Ins._Points[x + i, y].Type == PointType.Null)
                    {
                        CountNone++;
                        break;
                    }
                    else if (Gamemanager.Ins._Points[x + i, y].Type == Type)
                    {

                    }
                    else {
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
                if (x - i >= 0)
                {
                    if (Gamemanager.Ins._Points[x - i, y].Type == PointType.Null)
                    {
                        CountNone++;
                        break;
                    }
                    else if (Gamemanager.Ins._Points[x - i, y].Type == Type)
                    {

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
            if (CountNone>=2) {
                ChessPoint = new Vector3(29.5f * x - (29.5f * 14 / 2)-2, 29.5f * y - (29.5f * 14 / 2)+22, 0);
                WriteX = x;
                WriteY = y;
            }
        }
        if (CountY == 4)
        {
            int CountNone = 0;
            for (int i = 1; i < 15; i++)
            {
                if (y + i < 15)
                {
                    if (Gamemanager.Ins._Points[x, y+i].Type == PointType.Null)
                    {
                        CountNone++;
                        break;
                    }
                    else if (Gamemanager.Ins._Points[x, y+i].Type == Type)
                    {

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
                    if (Gamemanager.Ins._Points[x, y-i].Type == PointType.Null)
                    {
                        CountNone++;
                        break;
                    }
                    else if (Gamemanager.Ins._Points[x , y-i].Type == Type)
                    {

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
            if (CountNone >= 2)
            {
                ChessPoint = new Vector3(29.5f * x - (29.5f * 14 / 2)-2, 29.5f * y - (29.5f * 14 / 2)+22, 0);
                WriteX = x;
                WriteY = y;
            }
        }
        if (CountUpLeft == 4)
        {
            int CountNone = 0;
            for (int i = 1; i < 15; i++)
            {
                if (x - i >= 0 && y + i < 15)
                {
                    if (Gamemanager.Ins._Points[x-i, y + i].Type == PointType.Null)
                    {
                        CountNone++;
                        break;
                    }
                    else if (Gamemanager.Ins._Points[x - i, y + i].Type == Type)
                    {

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
                if (x + i < 15 && y - i >= 0)
                {
                    if (Gamemanager.Ins._Points[x+i, y - i].Type == PointType.Null)
                    {
                        CountNone++;
                        break;
                    }
                    else if (Gamemanager.Ins._Points[x+i, y - i].Type == Type)
                    {

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
            if (CountNone >= 2)
            {
                ChessPoint = new Vector3(29.5f * x - (29.5f * 14 / 2)-2, 29.5f * y - (29.5f * 14 / 2)+22, 0);
                WriteX = x;
                WriteY = y;
            }
        }
        if (CountUpRight == 4)
        {
            int CountNone = 0;
            for (int i = 1; i < 15; i++)
            {
                if (x + i <15 && y + i < 15)
                {
                    if (Gamemanager.Ins._Points[x + i, y + i].Type == PointType.Null)
                    {
                        CountNone++;
                        break;
                    }
                    else if (Gamemanager.Ins._Points[x + i, y + i].Type == Type)
                    {

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
                    if (Gamemanager.Ins._Points[x - i, y - i].Type == PointType.Null)
                    {
                        CountNone++;
                        break;
                    }
                    else if (Gamemanager.Ins._Points[x - i, y - i].Type == Type)
                    {

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
            if (CountNone >= 2)
            {
                ChessPoint = new Vector3(29.5f * x - (29.5f * 14 / 2)-2, 29.5f * y - (29.5f * 14 / 2)+22, 0);
                WriteX = x;
                WriteY = y;
            }
        }

    }
    void JsCan4And1NoneAnd1None(int x, int y, PointType Type)
    {
        int CountX = 1;
        int CountY = 1;
        int CountUpLeft = 1;
        int CountUpRight = 1;

        for (int i = 1; i < 15; i++)
        {
            if (x + i < 15)
            {
                if (Gamemanager.Ins._Points[x + i, y].Type == Type)
                {
                    CountX++;
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
            if (x - i >= 0)
            {
                if (Gamemanager.Ins._Points[x - i, y].Type == Type)
                {
                    CountX++;
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
        /////////////
        for (int i = 1; i < 15; i++)
        {
            if (y + i < 15)
            {
                if (Gamemanager.Ins._Points[x, y + i].Type == Type)
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
                if (Gamemanager.Ins._Points[x, y - i].Type == Type)
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
            if (x - i >= 0 && y + i < 15)
            {
                if (Gamemanager.Ins._Points[x - i, y + i].Type == Type)
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
            if (x + i < 15 && y - i >= 0)
            {
                if (Gamemanager.Ins._Points[x + i, y - i].Type == Type)
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
            if (x + i < 15 && y + i < 15)
            {
                if (Gamemanager.Ins._Points[x + i, y + i].Type == Type)
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
            if (x - i >= 0 && y - i >= 0)
            {
                if (Gamemanager.Ins._Points[x - i, y - i].Type == Type)
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
        if (CountX == 4)
        {
            int CountNone = 0;
            for (int i = 1; i < 15; i++)
            {
                if (x + i < 15)
                {
                    if (Gamemanager.Ins._Points[x + i, y].Type == PointType.Null)
                    {
                        CountNone++;
                        break;
                    }
                    else if (Gamemanager.Ins._Points[x + i, y].Type == Type)
                    {

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
                if (x - i >= 0)
                {
                    if (Gamemanager.Ins._Points[x - i, y].Type == PointType.Null)
                    {
                        CountNone++;
                        break;
                    }
                    else if (Gamemanager.Ins._Points[x - i, y].Type == Type)
                    {

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
            if (CountNone >= 1)
            {
                ChessPoint = new Vector3(29.5f * x - (29.5f * 14 / 2)-2, 29.5f * y - (29.5f * 14 / 2)+22, 0);
                WriteX = x;
                WriteY = y;
            }
        }
        if (CountY == 4)
        {
            int CountNone = 0;
            for (int i = 1; i < 15; i++)
            {
                if (y + i < 15)
                {
                    if (Gamemanager.Ins._Points[x, y + i].Type == PointType.Null)
                    {
                        CountNone++;
                        break;
                    }
                    else if (Gamemanager.Ins._Points[x, y + i].Type == Type)
                    {

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
                    if (Gamemanager.Ins._Points[x, y - i].Type == PointType.Null)
                    {
                        CountNone++;
                        break;
                    }
                    else if (Gamemanager.Ins._Points[x, y - i].Type == Type)
                    {

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
            if (CountNone >= 1)
            {
                ChessPoint = new Vector3(29.5f * x - (29.5f * 14 / 2)-2, 29.5f * y - (29.5f * 14 / 2)+22, 0);
                WriteX = x;
                WriteY = y;
            }
        }
        if (CountUpLeft == 4)
        {
            int CountNone = 0;
            for (int i = 1; i < 15; i++)
            {
                if (x - i >= 0 && y + i < 15)
                {
                    if (Gamemanager.Ins._Points[x - i, y + i].Type == PointType.Null)
                    {
                        CountNone++;
                        break;
                    }
                    else if (Gamemanager.Ins._Points[x - i, y + i].Type == Type)
                    {

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
                if (x + i < 15 && y - i >= 0)
                {
                    if (Gamemanager.Ins._Points[x + i, y - i].Type == PointType.Null)
                    {
                        CountNone++;
                        break;
                    }
                    else if (Gamemanager.Ins._Points[x + i, y - i].Type == Type)
                    {

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
            if (CountNone >= 1)
            {
                ChessPoint = new Vector3(29.5f * x - (29.5f * 14 / 2)-2, 29.5f * y - (29.5f * 14 / 2)+22, 0);
                WriteX = x;
                WriteY = y;
            }
        }
        if (CountUpRight == 4)
        {
            int CountNone = 0;
            for (int i = 1; i < 15; i++)
            {
                if (x + i < 15 && y + i < 15)
                {
                    if (Gamemanager.Ins._Points[x + i, y + i].Type == PointType.Null)
                    {
                        CountNone++;
                        break;
                    }
                    else if (Gamemanager.Ins._Points[x + i, y + i].Type == Type)
                    {

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
                if (x - i >= 0 && y - i >= 0)
                {
                    if (Gamemanager.Ins._Points[x - i, y - i].Type == PointType.Null)
                    {
                        CountNone++;
                        break;
                    }
                    else if (Gamemanager.Ins._Points[x - i, y - i].Type == Type)
                    {

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
            if (CountNone >= 1)
            {
                ChessPoint = new Vector3(29.5f * x - (29.5f * 14 / 2)-2, 29.5f * y - (29.5f * 14 / 2)+22, 0);
                WriteX = x;
                WriteY = y;
            }
        }

    }
    void JsCan4AndTwoOne(int x, int y, PointType Type)
    {
        int CountX = 1;
        int CountY = 1;
        int CountUpLeft = 1;
        int CountUpRight = 1;
        int AllCount = 0;
        for (int i = 1; i < 15; i++)
        {
            if (x + i < 15)
            {
                if (Gamemanager.Ins._Points[x + i, y].Type == Type)
                {
                    CountX++;
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
            if (x - i >= 0)
            {
                if (Gamemanager.Ins._Points[x - i, y].Type == Type)
                {
                    CountX++;
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
        /////////////
        for (int i = 1; i < 15; i++)
        {
            if (y + i < 15)
            {
                if (Gamemanager.Ins._Points[x, y + i].Type == Type)
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
                if (Gamemanager.Ins._Points[x, y - i].Type == Type)
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
            if (x - i >= 0 && y + i < 15)
            {
                if (Gamemanager.Ins._Points[x - i, y + i].Type == Type)
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
            if (x + i < 15 && y - i >= 0)
            {
                if (Gamemanager.Ins._Points[x + i, y - i].Type == Type)
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
            if (x + i < 15 && y + i < 15)
            {
                if (Gamemanager.Ins._Points[x + i, y + i].Type == Type)
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
            if (x - i >= 0 && y - i >= 0)
            {
                if (Gamemanager.Ins._Points[x - i, y - i].Type == Type)
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
        if (CountX == 4)
        {
            int CountNone = 0;
            for (int i = 1; i < 15; i++)
            {
                if (x + i < 15)
                {
                    if (Gamemanager.Ins._Points[x + i, y].Type == PointType.Null)
                    {
                        CountNone++;
                        break;
                    }
                    else if (Gamemanager.Ins._Points[x + i, y].Type == Type)
                    {

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
                if (x - i >= 0)
                {
                    if (Gamemanager.Ins._Points[x - i, y].Type == PointType.Null)
                    {
                        CountNone++;
                        break;
                    }
                    else if (Gamemanager.Ins._Points[x - i, y].Type == Type)
                    {

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
            if (CountNone >=1)
            {
                AllCount++;
            }
        }
        if (CountY == 4)
        {
            int CountNone = 0;
            for (int i = 1; i < 15; i++)
            {
                if (y + i < 15)
                {
                    if (Gamemanager.Ins._Points[x, y + i].Type == PointType.Null)
                    {
                        CountNone++;
                        break;
                    }
                    else if (Gamemanager.Ins._Points[x, y + i].Type == Type)
                    {

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
                    if (Gamemanager.Ins._Points[x, y - i].Type == PointType.Null)
                    {
                        CountNone++;
                        break;
                    }
                    else if (Gamemanager.Ins._Points[x, y - i].Type == Type)
                    {

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
            if (CountNone >= 1)
            {
                AllCount++;
            }
        }
        if (CountUpLeft == 4)
        {
            int CountNone = 0;
            for (int i = 1; i < 15; i++)
            {
                if (x - i >= 0 && y + i < 15)
                {
                    if (Gamemanager.Ins._Points[x - i, y + i].Type == PointType.Null)
                    {
                        CountNone++;
                        break;
                    }
                    else if (Gamemanager.Ins._Points[x - i, y + i].Type == Type)
                    {

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
                if (x + i < 15 && y - i >= 0)
                {
                    if (Gamemanager.Ins._Points[x + i, y - i].Type == PointType.Null)
                    {
                        CountNone++;
                        break;
                    }
                    else if (Gamemanager.Ins._Points[x + i, y - i].Type == Type)
                    {

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
            if (CountNone >= 1)
            {
                AllCount++;
            }
        }
        if (CountUpRight == 4)
        {
            int CountNone = 0;
            for (int i = 1; i < 15; i++)
            {
                if (x + i < 15 && y + i < 15)
                {
                    if (Gamemanager.Ins._Points[x + i, y + i].Type == PointType.Null)
                    {
                        CountNone++;
                        break;
                    }
                    else if (Gamemanager.Ins._Points[x + i, y + i].Type == Type)
                    {

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
                if (x - i >= 0 && y - i >= 0)
                {
                    if (Gamemanager.Ins._Points[x - i, y - i].Type == PointType.Null)
                    {
                        CountNone++;
                        break;
                    }
                    else if (Gamemanager.Ins._Points[x - i, y - i].Type == Type)
                    {

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
            if (CountNone >= 1)
            {
                AllCount++;
               
            }
        }
        if (AllCount>=2) {
            ChessPoint = new Vector3(29.5f * x - (29.5f * 14 / 2)-2, 29.5f * y - (29.5f * 14 / 2)+22, 0);
            WriteX = x;
            WriteY = y;
        }
    }
    void JsCan4AndThree(int x, int y, PointType Type)
    {
        int CountX = 1;
        int CountY = 1;
        int CountUpLeft = 1;
        int CountUpRight = 1;
        int AllCount = 0;
        for (int i = 1; i < 15; i++)
        {
            if (x + i < 15)
            {
                if (Gamemanager.Ins._Points[x + i, y].Type == Type)
                {
                    CountX++;
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
            if (x - i >= 0)
            {
                if (Gamemanager.Ins._Points[x - i, y].Type == Type)
                {
                    CountX++;
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
        /////////////
        for (int i = 1; i < 15; i++)
        {
            if (y + i < 15)
            {
                if (Gamemanager.Ins._Points[x, y + i].Type == Type)
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
                if (Gamemanager.Ins._Points[x, y - i].Type == Type)
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
            if (x - i >= 0 && y + i < 15)
            {
                if (Gamemanager.Ins._Points[x - i, y + i].Type == Type)
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
            if (x + i < 15 && y - i >= 0)
            {
                if (Gamemanager.Ins._Points[x + i, y - i].Type == Type)
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
            if (x + i < 15 && y + i < 15)
            {
                if (Gamemanager.Ins._Points[x + i, y + i].Type == Type)
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
            if (x - i >= 0 && y - i >= 0)
            {
                if (Gamemanager.Ins._Points[x - i, y - i].Type == Type)
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
        if (CountX == 4)
        {
            int CountNone = 0;
            for (int i = 1; i < 15; i++)
            {
                if (x + i < 15)
                {
                    if (Gamemanager.Ins._Points[x + i, y].Type == PointType.Null)
                    {
                        CountNone++;
                        break;
                    }
                    else if (Gamemanager.Ins._Points[x + i, y].Type == Type)
                    {

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
                if (x - i >= 0)
                {
                    if (Gamemanager.Ins._Points[x - i, y].Type == PointType.Null)
                    {
                        CountNone++;
                        break;
                    }
                    else if (Gamemanager.Ins._Points[x - i, y].Type == Type)
                    {

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
            if (CountNone >= 1)
            {
                AllCount++;
            }
        }
        else if (CountX == 3)
        {
            int CountNone = 0;
            for (int i = 1; i < 15; i++)
            {
                if (x + i < 15)
                {
                    if (Gamemanager.Ins._Points[x + i, y].Type == PointType.Null)
                    {
                        CountNone++;
                        break;
                    }
                    else if (Gamemanager.Ins._Points[x + i, y].Type == Type)
                    {

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
                if (x - i >= 0)
                {
                    if (Gamemanager.Ins._Points[x - i, y].Type == PointType.Null)
                    {
                        CountNone++;
                        break;
                    }
                    else if (Gamemanager.Ins._Points[x - i, y].Type == Type)
                    {

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
            if (CountNone >=2)
            {
                AllCount++;
            }
        }
        if (CountY == 4)
        {
            int CountNone = 0;
            for (int i = 1; i < 15; i++)
            {
                if (y + i < 15)
                {
                    if (Gamemanager.Ins._Points[x, y + i].Type == PointType.Null)
                    {
                        CountNone++;
                        break;
                    }
                    else if (Gamemanager.Ins._Points[x, y + i].Type == Type)
                    {

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
                    if (Gamemanager.Ins._Points[x, y - i].Type == PointType.Null)
                    {
                        CountNone++;
                        break;
                    }
                    else if (Gamemanager.Ins._Points[x, y - i].Type == Type)
                    {

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
            if (CountNone >= 1)
            {
                AllCount++;
            }
        }
        else if (CountY == 3)
        {
            int CountNone = 0;
            for (int i = 1; i < 15; i++)
            {
                if (y + i < 15)
                {
                    if (Gamemanager.Ins._Points[x, y + i].Type == PointType.Null)
                    {
                        CountNone++;
                        break;
                    }
                    else if (Gamemanager.Ins._Points[x, y + i].Type == Type)
                    {

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
                    if (Gamemanager.Ins._Points[x, y - i].Type == PointType.Null)
                    {
                        CountNone++;
                        break;
                    }
                    else if (Gamemanager.Ins._Points[x, y - i].Type == Type)
                    {

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
            if (CountNone >= 2)
            {
                AllCount++;
            }
        }
        if (CountUpLeft == 4)
        {
            int CountNone = 0;
            for (int i = 1; i < 15; i++)
            {
                if (x - i >= 0 && y + i < 15)
                {
                    if (Gamemanager.Ins._Points[x - i, y + i].Type == PointType.Null)
                    {
                        CountNone++;
                        break;
                    }
                    else if (Gamemanager.Ins._Points[x - i, y + i].Type == Type)
                    {

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
                if (x + i < 15 && y - i >= 0)
                {
                    if (Gamemanager.Ins._Points[x + i, y - i].Type == PointType.Null)
                    {
                        CountNone++;
                        break;
                    }
                    else if (Gamemanager.Ins._Points[x + i, y - i].Type == Type)
                    {

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
            if (CountNone >= 1)
            {
                AllCount++;
            }
        }
        else if (CountUpLeft == 3)
        {
            int CountNone = 0;
            for (int i = 1; i < 15; i++)
            {
                if (x - i >= 0 && y + i < 15)
                {
                    if (Gamemanager.Ins._Points[x - i, y + i].Type == PointType.Null)
                    {
                        CountNone++;
                        break;
                    }
                    else if (Gamemanager.Ins._Points[x - i, y + i].Type == Type)
                    {

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
                if (x + i < 15 && y - i >= 0)
                {
                    if (Gamemanager.Ins._Points[x + i, y - i].Type == PointType.Null)
                    {
                        CountNone++;
                        break;
                    }
                    else if (Gamemanager.Ins._Points[x + i, y - i].Type == Type)
                    {

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
            if (CountNone >= 2)
            {
                AllCount++;
            }
        }
        if (CountUpRight == 4)
        {
            int CountNone = 0;
            for (int i = 1; i < 15; i++)
            {
                if (x + i < 15 && y + i < 15)
                {
                    if (Gamemanager.Ins._Points[x + i, y + i].Type == PointType.Null)
                    {
                        CountNone++;
                        break;
                    }
                    else if (Gamemanager.Ins._Points[x + i, y + i].Type == Type)
                    {

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
                if (x - i >= 0 && y - i >= 0)
                {
                    if (Gamemanager.Ins._Points[x - i, y - i].Type == PointType.Null)
                    {
                        CountNone++;
                        break;
                    }
                    else if (Gamemanager.Ins._Points[x - i, y - i].Type == Type)
                    {

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
            if (CountNone >= 1)
            {
                AllCount++;

            }
        }
        else if (CountUpRight == 3)
        {
            int CountNone = 0;
            for (int i = 1; i < 15; i++)
            {
                if (x + i < 15 && y + i < 15)
                {
                    if (Gamemanager.Ins._Points[x + i, y + i].Type == PointType.Null)
                    {
                        CountNone++;
                        break;
                    }
                    else if (Gamemanager.Ins._Points[x + i, y + i].Type == Type)
                    {

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
                if (x - i >= 0 && y - i >= 0)
                {
                    if (Gamemanager.Ins._Points[x - i, y - i].Type == PointType.Null)
                    {
                        CountNone++;
                        break;
                    }
                    else if (Gamemanager.Ins._Points[x - i, y - i].Type == Type)
                    {

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
            if (CountNone >= 2)
            {
                AllCount++;

            }
        }
        if (AllCount >= 2)
        {
            ChessPoint = new Vector3(29.5f * x - (29.5f * 14 / 2)-2, 29.5f * y - (29.5f * 14 / 2)+22, 0);
            WriteX = x;
            WriteY = y;
        }
     
    }

    /// <summary>
    /// ***
    /// </summary>
    /// <param name="x"></param>
    /// <param name="y"></param>
    /// <param name="Type"></param>
    void JsCan3AndTwo(int x, int y, PointType Type)
    {
        int CountX = 1;
        int CountY = 1;
        int CountUpLeft = 1;
        int CountUpRight = 1;
        int AllCount = 0;
        for (int i = 1; i < 15; i++)
        {
            if (x + i < 15)
            {
                if (Gamemanager.Ins._Points[x + i, y].Type == Type)
                {
                    CountX++;
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
            if (x - i >= 0)
            {
                if (Gamemanager.Ins._Points[x - i, y].Type == Type)
                {
                    CountX++;
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
        /////////////
        for (int i = 1; i < 15; i++)
        {
            if (y + i < 15)
            {
                if (Gamemanager.Ins._Points[x, y + i].Type == Type)
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
                if (Gamemanager.Ins._Points[x, y - i].Type == Type)
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
            if (x - i >= 0 && y + i < 15)
            {
                if (Gamemanager.Ins._Points[x - i, y + i].Type == Type)
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
            if (x + i < 15 && y - i >= 0)
            {
                if (Gamemanager.Ins._Points[x + i, y - i].Type == Type)
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
            if (x + i < 15 && y + i < 15)
            {
                if (Gamemanager.Ins._Points[x + i, y + i].Type == Type)
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
            if (x - i >= 0 && y - i >= 0)
            {
                if (Gamemanager.Ins._Points[x - i, y - i].Type == Type)
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
        if (CountX == 3)
        {
            int CountNone = 0;
            for (int i = 1; i < 15; i++)
            {
                if (x + i < 15)
                {
                    if (Gamemanager.Ins._Points[x + i, y].Type == PointType.Null)
                    {
                        CountNone++;
                        break;
                    }
                    else if (Gamemanager.Ins._Points[x + i, y].Type == Type)
                    {

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
                if (x - i >= 0)
                {
                    if (Gamemanager.Ins._Points[x - i, y].Type == PointType.Null)
                    {
                        CountNone++;
                        break;
                    }
                    else if (Gamemanager.Ins._Points[x - i, y].Type == Type)
                    {

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
            if (CountNone >= 1)
            {
                AllCount++;
            }
        }
        else if (CountX == 2)
        {
            int CountNone = 0;
            for (int i = 1; i < 15; i++)
            {
                if (x + i < 15)
                {
                    if (Gamemanager.Ins._Points[x + i, y].Type == PointType.Null)
                    {
                        CountNone++;
                        break;
                    }
                    else if (Gamemanager.Ins._Points[x + i, y].Type == Type)
                    {

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
                if (x - i >= 0)
                {
                    if (Gamemanager.Ins._Points[x - i, y].Type == PointType.Null)
                    {
                        CountNone++;
                        break;
                    }
                    else if (Gamemanager.Ins._Points[x - i, y].Type == Type)
                    {

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
            if (CountNone >= 2)
            {
                AllCount++;
            }
        }
        if (CountY == 3)
        {
            int CountNone = 0;
            for (int i = 1; i < 15; i++)
            {
                if (y + i < 15)
                {
                    if (Gamemanager.Ins._Points[x, y + i].Type == PointType.Null)
                    {
                        CountNone++;
                        break;
                    }
                    else if (Gamemanager.Ins._Points[x, y + i].Type == Type)
                    {

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
                    if (Gamemanager.Ins._Points[x, y - i].Type == PointType.Null)
                    {
                        CountNone++;
                        break;
                    }
                    else if (Gamemanager.Ins._Points[x, y - i].Type == Type)
                    {

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
            if (CountNone >= 1)
            {
                AllCount++;
            }
        }
        else if (CountY == 2)
        {
            int CountNone = 0;
            for (int i = 1; i < 15; i++)
            {
                if (y + i < 15)
                {
                    if (Gamemanager.Ins._Points[x, y + i].Type == PointType.Null)
                    {
                        CountNone++;
                        break;
                    }
                    else if (Gamemanager.Ins._Points[x, y + i].Type == Type)
                    {

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
                    if (Gamemanager.Ins._Points[x, y - i].Type == PointType.Null)
                    {
                        CountNone++;
                        break;
                    }
                    else if (Gamemanager.Ins._Points[x, y - i].Type == Type)
                    {

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
            if (CountNone >= 2)
            {
                AllCount++;
            }
        }
        if (CountUpLeft == 3)
        {
            int CountNone = 0;
            for (int i = 1; i < 15; i++)
            {
                if (x - i >= 0 && y + i < 15)
                {
                    if (Gamemanager.Ins._Points[x - i, y + i].Type == PointType.Null)
                    {
                        CountNone++;
                        break;
                    }
                    else if (Gamemanager.Ins._Points[x - i, y + i].Type == Type)
                    {

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
                if (x + i < 15 && y - i >= 0)
                {
                    if (Gamemanager.Ins._Points[x + i, y - i].Type == PointType.Null)
                    {
                        CountNone++;
                        break;
                    }
                    else if (Gamemanager.Ins._Points[x + i, y - i].Type == Type)
                    {

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
            if (CountNone >= 1)
            {
                AllCount++;
            }
        }
        else if (CountUpLeft == 2)
        {
            int CountNone = 0;
            for (int i = 1; i < 15; i++)
            {
                if (x - i >= 0 && y + i < 15)
                {
                    if (Gamemanager.Ins._Points[x - i, y + i].Type == PointType.Null)
                    {
                        CountNone++;
                        break;
                    }
                    else if (Gamemanager.Ins._Points[x - i, y + i].Type == Type)
                    {

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
                if (x + i < 15 && y - i >= 0)
                {
                    if (Gamemanager.Ins._Points[x + i, y - i].Type == PointType.Null)
                    {
                        CountNone++;
                        break;
                    }
                    else if (Gamemanager.Ins._Points[x + i, y - i].Type == Type)
                    {

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
            if (CountNone >= 2)
            {
                AllCount++;
            }
        }
        if (CountUpRight == 3)
        {
            int CountNone = 0;
            for (int i = 1; i < 15; i++)
            {
                if (x + i < 15 && y + i < 15)
                {
                    if (Gamemanager.Ins._Points[x + i, y + i].Type == PointType.Null)
                    {
                        CountNone++;
                        break;
                    }
                    else if (Gamemanager.Ins._Points[x + i, y + i].Type == Type)
                    {

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
                if (x - i >= 0 && y - i >= 0)
                {
                    if (Gamemanager.Ins._Points[x - i, y - i].Type == PointType.Null)
                    {
                        CountNone++;
                        break;
                    }
                    else if (Gamemanager.Ins._Points[x - i, y - i].Type == Type)
                    {

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
            if (CountNone >= 1)
            {
                AllCount++;

            }
        }
        else if (CountUpRight == 2)
        {
            int CountNone = 0;
            for (int i = 1; i < 15; i++)
            {
                if (x + i < 15 && y + i < 15)
                {
                    if (Gamemanager.Ins._Points[x + i, y + i].Type == PointType.Null)
                    {
                        CountNone++;
                        break;
                    }
                    else if (Gamemanager.Ins._Points[x + i, y + i].Type == Type)
                    {

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
                if (x - i >= 0 && y - i >= 0)
                {
                    if (Gamemanager.Ins._Points[x - i, y - i].Type == PointType.Null)
                    {
                        CountNone++;
                        break;
                    }
                    else if (Gamemanager.Ins._Points[x - i, y - i].Type == Type)
                    {

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
            if (CountNone >= 2)
            {
                AllCount++;

            }
        }
        if (AllCount >= 2)
        {
            ChessPoint = new Vector3(29.5f * x - (29.5f * 14 / 2)-2, 29.5f * y - (29.5f * 14 / 2)+22, 0);
            WriteX = x;
            WriteY = y;
        }

    }
    void JsCan3AndNone(int x, int y, PointType Type)
    {
        int CountX = 1;
        int CountY = 1;
        int CountUpLeft = 1;
        int CountUpRight = 1;

        for (int i = 1; i < 15; i++)
        {
            if (x + i < 15)
            {
                if (Gamemanager.Ins._Points[x + i, y].Type == Type)
                {
                    CountX++;
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
            if (x - i >= 0)
            {
                if (Gamemanager.Ins._Points[x - i, y].Type == Type)
                {
                    CountX++;
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
        /////////////
        for (int i = 1; i < 15; i++)
        {
            if (y + i < 15)
            {
                if (Gamemanager.Ins._Points[x, y + i].Type == Type)
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
                if (Gamemanager.Ins._Points[x, y - i].Type == Type)
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
            if (x - i >= 0 && y + i < 15)
            {
                if (Gamemanager.Ins._Points[x - i, y + i].Type == Type)
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
            if (x + i < 15 && y - i >= 0)
            {
                if (Gamemanager.Ins._Points[x + i, y - i].Type == Type)
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
            if (x + i < 15 && y + i < 15)
            {
                if (Gamemanager.Ins._Points[x + i, y + i].Type == Type)
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
            if (x - i >= 0 && y - i >= 0)
            {
                if (Gamemanager.Ins._Points[x - i, y - i].Type == Type)
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
        if (CountX == 3)
        {
            int CountNone = 0;
            for (int i = 1; i < 15; i++)
            {
                if (x + i < 15)
                {
                    if (Gamemanager.Ins._Points[x + i, y].Type == PointType.Null)
                    {
                        CountNone++;
                        break;
                    }
                    else if (Gamemanager.Ins._Points[x + i, y].Type == Type)
                    {

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
                if (x - i >= 0)
                {
                    if (Gamemanager.Ins._Points[x - i, y].Type == PointType.Null)
                    {
                        CountNone++;
                        break;
                    }
                    else if (Gamemanager.Ins._Points[x - i, y].Type == Type)
                    {

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
            if (CountNone >= 2)
            {
                ChessPoint = new Vector3(29.5f * x - (29.5f * 14 / 2)-2, 29.5f * y - (29.5f * 14 / 2)+22, 0);
                WriteX = x;
                WriteY = y;
            }
        }
        if (CountY == 3)
        {
            int CountNone = 0;
            for (int i = 1; i < 15; i++)
            {
                if (y + i < 15)
                {
                    if (Gamemanager.Ins._Points[x, y + i].Type == PointType.Null)
                    {
                        CountNone++;
                        break;
                    }
                    else if (Gamemanager.Ins._Points[x, y + i].Type == Type)
                    {

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
                    if (Gamemanager.Ins._Points[x, y - i].Type == PointType.Null)
                    {
                        CountNone++;
                        break;
                    }
                    else if (Gamemanager.Ins._Points[x, y - i].Type == Type)
                    {

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
            if (CountNone >= 2)
            {
                ChessPoint = new Vector3(29.5f * x - (29.5f * 14 / 2)-2, 29.5f * y - (29.5f * 14 / 2)+22, 0);
                WriteX = x;
                WriteY = y;
            }
        }
        if (CountUpLeft == 3)
        {
            int CountNone = 0;
            for (int i = 1; i < 15; i++)
            {
                if (x - i >= 0 && y + i < 15)
                {
                    if (Gamemanager.Ins._Points[x - i, y + i].Type == PointType.Null)
                    {
                        CountNone++;
                        break;
                    }
                    else if (Gamemanager.Ins._Points[x - i, y + i].Type == Type)
                    {

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
                if (x + i < 15 && y - i >= 0)
                {
                    if (Gamemanager.Ins._Points[x + i, y - i].Type == PointType.Null)
                    {
                        CountNone++;
                        break;
                    }
                    else if (Gamemanager.Ins._Points[x + i, y - i].Type == Type)
                    {

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
            if (CountNone >= 2)
            {
                ChessPoint = new Vector3(29.5f * x - (29.5f * 14 / 2)-2, 29.5f * y - (29.5f * 14 / 2)+22, 0);
                WriteX = x;
                WriteY = y;
            }
        }
        if (CountUpRight == 3)
        {
            int CountNone = 0;
            for (int i = 1; i < 15; i++)
            {
                if (x + i < 15 && y + i < 15)
                {
                    if (Gamemanager.Ins._Points[x + i, y + i].Type == PointType.Null)
                    {
                        CountNone++;
                        break;
                    }
                    else if (Gamemanager.Ins._Points[x + i, y + i].Type == Type)
                    {

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
                if (x - i >= 0 && y - i >= 0)
                {
                    if (Gamemanager.Ins._Points[x - i, y - i].Type == PointType.Null)
                    {
                        CountNone++;
                        break;
                    }
                    else if (Gamemanager.Ins._Points[x - i, y - i].Type == Type)
                    {

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
            if (CountNone >= 2)
            {
                ChessPoint = new Vector3(29.5f * x - (29.5f * 14 / 2)-2, 29.5f * y - (29.5f * 14 / 2)+22, 0);
                WriteX = x;
                WriteY = y;
            }
        }

    }
    void JsCan3AndTwoOne(int x, int y, PointType Type)
    {
        int CountX = 1;
        int CountY = 1;
        int CountUpLeft = 1;
        int CountUpRight = 1;
        int AllCount = 0;
        for (int i = 1; i < 15; i++)
        {
            if (x + i < 15)
            {
                if (Gamemanager.Ins._Points[x + i, y].Type == Type)
                {
                    CountX++;
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
            if (x - i >= 0)
            {
                if (Gamemanager.Ins._Points[x - i, y].Type == Type)
                {
                    CountX++;
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
        /////////////
        for (int i = 1; i < 15; i++)
        {
            if (y + i < 15)
            {
                if (Gamemanager.Ins._Points[x, y + i].Type == Type)
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
                if (Gamemanager.Ins._Points[x, y - i].Type == Type)
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
            if (x - i >= 0 && y + i < 15)
            {
                if (Gamemanager.Ins._Points[x - i, y + i].Type == Type)
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
            if (x + i < 15 && y - i >= 0)
            {
                if (Gamemanager.Ins._Points[x + i, y - i].Type == Type)
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
            if (x + i < 15 && y + i < 15)
            {
                if (Gamemanager.Ins._Points[x + i, y + i].Type == Type)
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
            if (x - i >= 0 && y - i >= 0)
            {
                if (Gamemanager.Ins._Points[x - i, y - i].Type == Type)
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
        if (CountX ==3)
        {
            int CountNone = 0;
            for (int i = 1; i < 15; i++)
            {
                if (x + i < 15)
                {
                    if (Gamemanager.Ins._Points[x + i, y].Type == PointType.Null)
                    {
                        CountNone++;
                        break;
                    }
                    else if (Gamemanager.Ins._Points[x + i, y].Type == Type)
                    {

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
                if (x - i >= 0)
                {
                    if (Gamemanager.Ins._Points[x - i, y].Type == PointType.Null)
                    {
                        CountNone++;
                        break;
                    }
                    else if (Gamemanager.Ins._Points[x - i, y].Type == Type)
                    {

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
            if (CountNone >= 1)
            {
                AllCount++;
            }
        }
        if (CountY == 3)
        {
            int CountNone = 0;
            for (int i = 1; i < 15; i++)
            {
                if (y + i < 15)
                {
                    if (Gamemanager.Ins._Points[x, y + i].Type == PointType.Null)
                    {
                        CountNone++;
                        break;
                    }
                    else if (Gamemanager.Ins._Points[x, y + i].Type == Type)
                    {

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
                    if (Gamemanager.Ins._Points[x, y - i].Type == PointType.Null)
                    {
                        CountNone++;
                        break;
                    }
                    else if (Gamemanager.Ins._Points[x, y - i].Type == Type)
                    {

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
            if (CountNone >= 1)
            {
                AllCount++;
            }
        }
        if (CountUpLeft == 3)
        {
            int CountNone = 0;
            for (int i = 1; i < 15; i++)
            {
                if (x - i >= 0 && y + i < 15)
                {
                    if (Gamemanager.Ins._Points[x - i, y + i].Type == PointType.Null)
                    {
                        CountNone++;
                        break;
                    }
                    else if (Gamemanager.Ins._Points[x - i, y + i].Type == Type)
                    {

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
                if (x + i < 15 && y - i >= 0)
                {
                    if (Gamemanager.Ins._Points[x + i, y - i].Type == PointType.Null)
                    {
                        CountNone++;
                        break;
                    }
                    else if (Gamemanager.Ins._Points[x + i, y - i].Type == Type)
                    {

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
            if (CountNone >= 1)
            {
                AllCount++;
            }
        }
        if (CountUpRight == 3)
        {
            int CountNone = 0;
            for (int i = 1; i < 15; i++)
            {
                if (x + i < 15 && y + i < 15)
                {
                    if (Gamemanager.Ins._Points[x + i, y + i].Type == PointType.Null)
                    {
                        CountNone++;
                        break;
                    }
                    else if (Gamemanager.Ins._Points[x + i, y + i].Type == Type)
                    {

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
                if (x - i >= 0 && y - i >= 0)
                {
                    if (Gamemanager.Ins._Points[x - i, y - i].Type == PointType.Null)
                    {
                        CountNone++;
                        break;
                    }
                    else if (Gamemanager.Ins._Points[x - i, y - i].Type == Type)
                    {

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
            if (CountNone >= 1)
            {
                AllCount++;

            }
        }
        if (AllCount >= 2)
        {
            ChessPoint = new Vector3(29.5f * x - (29.5f * 14 / 2)-2, 29.5f * y - (29.5f * 14 / 2)+22, 0);
            WriteX = x;
            WriteY = y;
        }
    }
    void JsCan2AndNone(int x, int y, PointType Type)
    {
        int CountX = 1;
        int CountY = 1;
        int CountUpLeft = 1;
        int CountUpRight = 1;

        for (int i = 1; i < 15; i++)
        {
            if (x + i < 15)
            {
                if (Gamemanager.Ins._Points[x + i, y].Type == Type)
                {
                    CountX++;
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
            if (x - i >= 0)
            {
                if (Gamemanager.Ins._Points[x - i, y].Type == Type)
                {
                    CountX++;
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
        /////////////
        for (int i = 1; i < 15; i++)
        {
            if (y + i < 15)
            {
                if (Gamemanager.Ins._Points[x, y + i].Type == Type)
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
                if (Gamemanager.Ins._Points[x, y - i].Type == Type)
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
            if (x - i >= 0 && y + i < 15)
            {
                if (Gamemanager.Ins._Points[x - i, y + i].Type == Type)
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
            if (x + i < 15 && y - i >= 0)
            {
                if (Gamemanager.Ins._Points[x + i, y - i].Type == Type)
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
            if (x + i < 15 && y + i < 15)
            {
                if (Gamemanager.Ins._Points[x + i, y + i].Type == Type)
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
            if (x - i >= 0 && y - i >= 0)
            {
                if (Gamemanager.Ins._Points[x - i, y - i].Type == Type)
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
        if (CountX >= 2)
        {
            int CountNone = 0;
            for (int i = 1; i < 15; i++)
            {
                if (x + i < 15)
                {
                    if (Gamemanager.Ins._Points[x + i, y].Type == PointType.Null)
                    {
                        CountNone++;
                        break;
                    }
                    else if (Gamemanager.Ins._Points[x + i, y].Type == Type)
                    {

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
                if (x - i >= 0)
                {
                    if (Gamemanager.Ins._Points[x - i, y].Type == PointType.Null)
                    {
                        CountNone++;
                        break;
                    }
                    else if (Gamemanager.Ins._Points[x - i, y].Type == Type)
                    {

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
            if (CountNone >= 2)
            {
                ChessPoint = new Vector3(29.5f * x - (29.5f * 14 / 2)-2, 29.5f * y - (29.5f * 14 / 2)+22, 0);
                WriteX = x;
                WriteY = y;
            }
        }
        if (CountY >= 2)
        {
            int CountNone = 0;
            for (int i = 1; i < 15; i++)
            {
                if (y + i < 15)
                {
                    if (Gamemanager.Ins._Points[x, y + i].Type == PointType.Null)
                    {
                        CountNone++;
                        break;
                    }
                    else if (Gamemanager.Ins._Points[x, y + i].Type == Type)
                    {

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
                    if (Gamemanager.Ins._Points[x, y - i].Type == PointType.Null)
                    {
                        CountNone++;
                        break;
                    }
                    else if (Gamemanager.Ins._Points[x, y - i].Type == Type)
                    {

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
            if (CountNone >= 2)
            {
                ChessPoint = new Vector3(29.5f * x - (29.5f * 14 / 2)-2, 29.5f * y - (29.5f * 14 / 2)+22, 0);
                WriteX = x;
                WriteY = y;
            }
        }
        if (CountUpLeft >= 2)
        {
            int CountNone = 0;
            for (int i = 1; i < 15; i++)
            {
                if (x - i >= 0 && y + i < 15)
                {
                    if (Gamemanager.Ins._Points[x - i, y + i].Type == PointType.Null)
                    {
                        CountNone++;
                        break;
                    }
                    else if (Gamemanager.Ins._Points[x - i, y + i].Type == Type)
                    {

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
                if (x + i < 15 && y - i >= 0)
                {
                    if (Gamemanager.Ins._Points[x + i, y - i].Type == PointType.Null)
                    {
                        CountNone++;
                        break;
                    }
                    else if (Gamemanager.Ins._Points[x + i, y - i].Type == Type)
                    {

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
            if (CountNone >= 2)
            {
                ChessPoint = new Vector3(29.5f * x - (29.5f * 14 / 2)-2, 29.5f * y - (29.5f * 14 / 2)+22, 0);
                WriteX = x;
                WriteY = y;
            }
        }
        if (CountUpRight >= 2)
        {
            int CountNone = 0;
            for (int i = 1; i < 15; i++)
            {
                if (x + i < 15 && y + i < 15)
                {
                    if (Gamemanager.Ins._Points[x + i, y + i].Type == PointType.Null)
                    {
                        CountNone++;
                        break;
                    }
                    else if (Gamemanager.Ins._Points[x + i, y + i].Type == Type)
                    {

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
                if (x - i >= 0 && y - i >= 0)
                {
                    if (Gamemanager.Ins._Points[x - i, y - i].Type == PointType.Null)
                    {
                        CountNone++;
                        break;
                    }
                    else if (Gamemanager.Ins._Points[x - i, y - i].Type == Type)
                    {

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
            if (CountNone >= 2)
            {
                ChessPoint = new Vector3(29.5f * x - (29.5f * 14 / 2)-2, 29.5f * y - (29.5f * 14 / 2)+22, 0);
                WriteX = x;
                WriteY = y;
            }
        }

    }
}












/*
玩家：（4子）下一步5子----（3子+无边）下一步4子无边-----下一步存在双3子+无边----下一步3子无边--------
       2子+无边-----3子+单边----- 下一步存在2子无边

--------------------------------------------------------------------------------------------------

AI：（4子）下一步5子-----（3子）下一步4子+无边------（3子）下一步双4子单边------（3子）下一步4子+单边-----
     下一步双3子+无边----下一步双3子+单边----下一步3子无边-----下一步双2子无边

LE：（4子）下一步5子----（3子+无边）下一步4子无边-----下一步存在双3子+无边-----2子+无边-----3子+单边------


LE2:
*/
