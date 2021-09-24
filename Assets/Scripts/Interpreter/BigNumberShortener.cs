
using UnityEngine;

public class BigNumberShortener : MonoBehaviour
{
    public string GetShortTextNumber(int number)
    {
        string result = number.ToString();
        
        if (number > 1000000000) result = (number / 10000).ToString("F") + "B";
        else if (number > 1000000) result = (number / 10000).ToString("F") + "M";
        else if (number > 1000) result = (number / 1000).ToString("F") + "K";

        return result;
    }
}
