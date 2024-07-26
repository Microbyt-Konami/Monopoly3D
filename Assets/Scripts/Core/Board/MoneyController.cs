using UnityEngine;

public class MoneyController : MonoBehaviour
{
    [Header("reference")]
    [SerializeField] private DigitControler[] digits;
    [Header("Editor")]
    [SerializeField] private int number = 0;

    public void SetNumber(int number)
    {
        Debug.Log($"digits: {digits.Length}, number: {number}");
        DigitControler.SetNumber(digits, number);
        this.number = number;
    }

    private void OnValidate()
    {
        SetNumber(number);
    }
}
