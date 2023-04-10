using UnityEngine;
using UnityEngine.UI;

public class buttonHandler : MonoBehaviour
{
    [SerializeField] int num = 0;
    [SerializeField] calc2 calculator;

    public void OnButtonClicked()
    {
        calculator.OnNumButtonPressed(num);
    }
}
