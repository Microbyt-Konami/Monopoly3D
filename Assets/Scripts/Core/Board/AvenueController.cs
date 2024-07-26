using UnityEngine;
using TMPro;
using System;

public class AvenueController : MonoBehaviour
{
    [Header("reference")]
    [SerializeField] private GameObject box;
    [SerializeField] private MeshRenderer blockRenderer;
    [SerializeField] private TextMeshPro textTitle;
    [SerializeField] private MoneyController moneyController;
    [Header("Editor")]
    [SerializeField] private Avenue avenue;

    public void SetAvenue(Avenue avenue)
    {
        this.avenue = avenue;
        blockRenderer.sharedMaterial = avenue?.blockMaterial;
        textTitle.text = avenue?.Title;
        moneyController.SetNumber(avenue?.Money ?? 0);
    }

    private void OnValidate()
    {
        SetAvenue(avenue);
    }
}
