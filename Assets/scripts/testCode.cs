using System.Collections;
using System.Collections.Generic;
using UnityEngine;
   
public class testCode : MonoBehaviour
{  // Start is called before the first frame update

    private void Start()
    {
        float A = 2.0f;
        float B = 3.0f;
        float C = A * B;
        float D = A + B + C;
        C -= 2;
        A = 5.0f;
        if (D > (A + C))
        {
            B *= 5;
        }
        for (int i = 0; i < 10; i++)
        {
            A += 1;
        }
        void nimi()
        {
            Debug.Log("Joni Roine.");
        }
        nimi();
        Debug.Log(A);
        Debug.Log(B);
        Debug.Log(C);
        Debug.Log(D);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
