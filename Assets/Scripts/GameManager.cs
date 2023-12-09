using System.Collections;
using System.Collections.Generic;
using UnityEditor.Build.Content;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int[,] leftBoard;
    public int[,] rightBoard;
    [SerializeField] private BingoBoardManager boardLeftManager;
    // Start is called before the first frame update
    void Start()
    {
        leftBoard = BoardManager.generateBoard();
        rightBoard = BoardManager.generateBoard();
        boardLeftManager.Init();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
