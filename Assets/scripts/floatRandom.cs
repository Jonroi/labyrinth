using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class floatRandom : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        float number = Random.Range(-1f, 1f);
        Debug.Log(number);

        float codingSkills = Random.Range(0.0f, 100f);
        Debug.Log($"coding skills: {codingSkills}%");

        if (codingSkills >= 76.54f)
        {
            Debug.Log("Olet hyvä!");
        }
        else
        {
            Debug.Log("Olet loistava!");
        }
    }
}
