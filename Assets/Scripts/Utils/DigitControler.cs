using System.Collections.Generic;
using UnityEngine;

public class DigitControler : MonoBehaviour
{
    [Header("reference")]
    [SerializeField] private GameObject[] digits;
    [Header("Editor")]
    [SerializeField] private int digit;

    private int digitAct = 0;

    public void SetDigit(int digit)
    {
        if (digit < 0 || digit > 9)
            return;

        digits[digitAct].SetActive(false);
        digits[digit].SetActive(true);
        this.digit = digitAct = digit;
    }

    public void HideDigit()
    {
        digits[digitAct].SetActive(false);
        digit = digitAct = 0;
    }

    public static void SetNumber(IList<DigitControler> digits, int number)
    {
        int numberDump = number;
        int i0 = digits.Count - 1;

        Debug.Log($"SetNumber {numberDump}");

        for (int i = i0; i >= 0; i--)
        {
            var digitCntl = digits[i];
            int digit;

            Debug.Log($"SetNumber {numberDump} {i} {digitCntl.transform.parent.name}", digitCntl);

            if (numberDump == 0)
            {
                if (i != i0)
                {
                    digitCntl.HideDigit();

                    continue;
                }
                else
                    digit = 0;
            }
            else
            {
                digit = numberDump % 10;

                numberDump = numberDump / 10;
            }
            digitCntl.SetDigit(digit);
        }
    }

    private void OnValidate()
    {
        SetDigit(digit);
    }
}
