using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BingoBoardManager : MonoBehaviour
{
    [SerializeField] BoardTextManager[] boards;
    [SerializeField] GameManager gameManager;
    // Start is called before the first frame update
    public void Init()
    {
        for(int i = 0; i < boards.Length; i++)
        {
            Debug.Log("Board init " + i);
           boards[i].Init(gameManager.leftBoard);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
