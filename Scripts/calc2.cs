using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class calc2 : MonoBehaviour
{
    [SerializeField] Text inputText1;
    [SerializeField] Text inputText2;
    [SerializeField] Text resultText;

    private float num1 = 0f;
    private float num2 = 0f;

    private void Start()
    {
        // Set the first input field as the selected one
        EventSystem.current.SetSelectedGameObject(inputText1.gameObject);
    }

    public void OnNumButtonPressed(int num)
    {
        Debug.Log("Button " + num + " pressed");
        GameObject selected = EventSystem.current.currentSelectedGameObject;

        if (selected == inputText1.gameObject)
        {
            inputText1.text += ""+num;
        }
        else if (selected == inputText2.gameObject)
        {
            inputText2.text += ""+num;
        }
    }

    public void OnAddButtonPressed()
    {
        if (float.TryParse(inputText1.text, out num1) && float.TryParse(inputText2.text, out num2))
        {
            float result = num1 + num2;
            resultText.text = result.ToString();
        }
        else
        {
            resultText.text = "Invalid input";
        }
    }

    public void OnSubtractButtonPressed()
    {
        if (float.TryParse(inputText1.text, out num1) && float.TryParse(inputText2.text, out num2))
        {
            float result = num1 - num2;
            resultText.text = result.ToString();
        }
        else
        {
            resultText.text = "Invalid input";
        }
    }

    public void OnMultiplyButtonPressed()
    {
        if (float.TryParse(inputText1.text, out num1) && float.TryParse(inputText2.text, out num2))
        {
            float result = num1 * num2;
            resultText.text = result.ToString();
        }
        else
        {
            resultText.text = "Invalid input";
        }
    }

    public void OnDivideButtonPressed()
    {
        if (float.TryParse(inputText1.text, out num1) && float.TryParse(inputText2.text, out num2))
        {
            if (num2 == 0)
            {
                resultText.text = "Cannot divide by zero";
            }
            else
            {
                float result = num1 / num2;
                resultText.text = result.ToString();
            }
        }
        else
        {
            resultText.text = "Invalid input";
        }
    }

    public void OnClearButtonPressed()
    {
        inputText1.text = "";
        inputText2.text = "";
        resultText.text = "";
    }
}
