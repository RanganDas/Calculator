using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class calc : MonoBehaviour
{
    [SerializeField] InputField field1, field2;
    [SerializeField] Text text_view;
    public AudioSource sound;
    private bool isField1Active = true; // flag to keep track of active input field

    public void add()
    {
        sound.Play();
        float num1= float.Parse(field1.text);
        float num2= float.Parse(field2.text);
        float ans=num1+num2;
        text_view.text=""+ans;
    }
    
    public void sub()
    {
        sound.Play();
        float num1= float.Parse(field1.text);
        float num2= float.Parse(field2.text);
        float ans=num1-num2;
        text_view.text=""+ans;
    }
    
    public void mul()
    {
        sound.Play();
        float num1= float.Parse(field1.text);
        float num2= float.Parse(field2.text);
        float ans=num1*num2;
        text_view.text=""+ans;
    }

    public void div()
    {
        sound.Play();
        float num1= float.Parse(field1.text);
        float num2= float.Parse(field2.text);
        float ans=num1/num2;
        text_view.text=""+ans;
    }
    
    public void mod()
    {
        sound.Play();
        float num1= float.Parse(field1.text);
        float num2= float.Parse(field2.text);
        float ans=num1%num2;
        text_view.text=""+ans;
    }
    
    public void ac()
    {
        sound.Play();
        field1.text="";
        field2.text="";
    }

    public void AppendNumber(string number)
{
    if (field1.isFocused)
    {
        field1.text += number;
    }
    else if (field2.isFocused)
    {
        field2.text += number;
    }
}

    public void SetActiveField()
    {
        // Toggle active input field flag
        isField1Active = !isField1Active;
    }
    
    public void One()
    {
        AppendNumber("1");
    }
    
    public void Two()
    {
        AppendNumber("2");
    }
    
    public void Three()
    {
        AppendNumber("3");
    }
    
    public void Four()
    {
        AppendNumber("4");
    }
    
    public void Five()
    {
        AppendNumber("5");
    }
    
    public void Six()
    {
        AppendNumber("6");
    }
    
    public void Seven()
    {
        AppendNumber("7");
    }
    
    public void Eight()
    {
        AppendNumber("8");
    }
    
    public void Nine()
    {
        AppendNumber("9");
    }
    
    public void Zero()
    {
        AppendNumber("0");
    }
}
