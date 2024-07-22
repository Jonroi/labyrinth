using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class listRandom : MonoBehaviour
{
    List<string> list = new List<string> { "25", "50", "75", "100" };

    // Start is called before the first frame update
    void Start()
    {
        string number = list[Random.Range(0, list.Count)];
        Debug.Log(number);

        while (list.Count > 1)
        {
            string delete = list[Random.Range(0, list.Count)];
            list.Remove(delete);
        }
        Debug.Log("Jäljelle jäänyt alkio: " + list[0]);
    }
}
