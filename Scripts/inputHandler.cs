using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class inputHandler : MonoBehaviour
{
    [SerializeField] private InputField inputField1;
    [SerializeField] private InputField inputField2;

    private bool inputField1Selected;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            if (inputField1Selected)
            {
                inputField2.Select();
                inputField2.ActivateInputField();
                inputField1Selected = false;
            }
            else
            {
                inputField1.Select();
                inputField1.ActivateInputField();
                inputField1Selected = true;
            }
        }
    }

    public void OnNumButtonPressed(int num)
    {
        if (inputField1Selected)
        {
            inputField1.text += num.ToString();
        }
        else
        {
            inputField2.text += num.ToString();
        }
    }
}
