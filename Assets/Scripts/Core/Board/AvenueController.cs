using UnityEngine;

public class AvenueController : MonoBehaviour
{
    [Header("Options")]
    [SerializeField] private Material blockMaterial;
    [Header("reference")]
    [SerializeField] private MeshRenderer blockRenderer;

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
