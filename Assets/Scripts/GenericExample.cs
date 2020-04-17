using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenericExample : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Evaluate("Hello world");
        Evaluate(120);
        Evaluate(gameObject);

    }

    private void Evaluate<T>(T suppliedValue)
    {
        Debug.LogFormat("The type of {0} is {1}", suppliedValue, typeof(T));
    }
}
