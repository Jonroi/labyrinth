using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputExample : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");

        if (Input.GetKeyDown(KeyCode.A))
        {
            Debug.Log("a:ta painettu");
        }

        if (Input.GetKey(KeyCode.LeftShift) && Input.GetKey(KeyCode.A))
        {
            Debug.Log("shift + a painettu");
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("space:a painettu");
        }

        if (horizontalInput > 0)
        {
            Debug.Log("horizontal: " + horizontalInput);
        }

        if (Input.GetKeyDown(KeyCode.Keypad1))
        {
            Debug.Log("Pad 1");
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            Debug.Log("Kaksi");
        }

        if (Input.GetKeyDown(KeyCode.F) && !Input.GetKey(KeyCode.G))
        {
            Debug.Log("F painettu ilman G");
        }
    }
}
