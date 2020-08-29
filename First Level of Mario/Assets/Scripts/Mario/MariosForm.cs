using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MariosForm : MonoBehaviour
{
    static private int FormState = 0;
    private void Start()
    {
        if(FormState == 1)
        {
            transform.localScale = new Vector3(1.2f, 1.2f, 1);
        }
        else
        {
            transform.localScale = new Vector3(0.7f, 0.7f, 1);
        }
    }
    public void IncraseState()
    {
        FormState = 1;
        transform.localScale = new Vector3(1.2f, 1.2f, 1);
        Debug.Log("Mamy to");
    }
    public void DecraseState()
    {
        FormState = 0;
        transform.localScale = new Vector3(0.7f, 0.7f, 1);
        Debug.Log("Mamy to też");
    }
    public int GetState()
    {
        return FormState;
    }

}
