using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class NewEmptyCSharpScript : MonoBehaviour
{
    void Start()
    {
        print("Hello, World!");
        Destroy(gameObject, 5f);
    }
    void Update()
    {
        print("crikets");
    }
}

