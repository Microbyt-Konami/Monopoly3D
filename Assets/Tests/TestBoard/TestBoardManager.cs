using UnityEngine;

public class TestBoardManager : MonoBehaviour
{
    [SerializeField] private BoardController boardController;
    [SerializeField] private Board boardData;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        boardController.SetBoardData(boardData);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
