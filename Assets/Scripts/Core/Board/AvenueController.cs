using UnityEngine;
using TMPro;
using System;

public class AvenueController : MonoBehaviour
{
    [Header("Options")]
    [SerializeField] private Material blockMaterial;
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
        blockRenderer.sharedMaterial = avenue.blockMaterial;
        textTitle.text = avenue.Title;
        //textMoney.text = avenue.Money.ToString();
    }

    public void SetAvenueCurrent() => SetAvenue(avenue);

    private void Awake()
    {
        blockRenderer.sharedMaterial = blockMaterial;
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    //void Start()
    //{

    //}

    // Update is called once per frame
    //void Update()
    //{

    //}
}
