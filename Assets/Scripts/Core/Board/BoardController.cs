using UnityEngine;

public class BoardController : MonoBehaviour
{
    [Header("reference")]
    [SerializeField] private BoxController[] boxControllers;
    [Header("Editor")]
    [SerializeField] private Board boardData;

    public void SetBoardData(Board board)
    {
        boardData = board;
        foreach (var boxController in boxControllers)
        {
            var avenue = boardData?.GetAvenue(boxController.name);

            boxController.SetAvenueData(avenue);
        }
    }

    private void OnValidate()
    {
        SetBoardData(boardData);
    }
}
