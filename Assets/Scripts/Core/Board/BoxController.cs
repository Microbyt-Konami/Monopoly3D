using UnityEngine;

public class BoxController : MonoBehaviour
{
    [Header("reference")]
    [SerializeField] private AvenueController avenueController;

    public void SetAvenueData(Avenue avenue)
    {
        avenueController?.SetAvenue(avenue);
    }
}
