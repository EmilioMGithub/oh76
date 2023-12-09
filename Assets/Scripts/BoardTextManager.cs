using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class BoardTextManager : MonoBehaviour
{
    private int[,] gameBoard;
    [SerializeField] private int x;
    [SerializeField] private int y;
    [SerializeField]  private TextMeshProUGUI DisText;

    private void Start()
    {
        DisText = gameObject.GetComponent<TextMeshProUGUI>();
    }
    public void Init(int[,] gameBoard)
    {
        DisText = gameObject.GetComponent<TextMeshProUGUI>();
        this.gameBoard = gameBoard;
        DisText.text = gameBoard[x, y].ToString();
    }

}
