using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class BoardTextManager : MonoBehaviour
{
    [SerializeField] private int[,] gameBoard;
    [SerializeField] private int x;
    [SerializeField] private int y;
    [SerializeField] private TextMeshProUGUI text;

    public void Init(int[,] gameBoard)
    {
        this.gameBoard = gameBoard;
        text.text = this.gameBoard[x, y].ToString();
        if(this.gameBoard[x, y] == -1)
        {

        }
    }

}
