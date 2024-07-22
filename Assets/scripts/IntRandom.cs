using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomRange : MonoBehaviour
{
    int randomNumber;
    int minusluku;
    List<string> coin = new List<string> {"heads", "tales"};
    // Start is called before the first frame update
    void Start()
    {
        randomNumber = Random.Range(1, 1001);
        Debug.Log(randomNumber);

        minusluku = Random.Range(-10, -5);
        Debug.Log(minusluku);

        int CoinIndex = Random.Range(0,coin.Count);
        Debug.Log(coin[CoinIndex]);

            int number = 0;
        int increments = 0;
        
        while (number < 100)
        {
            int add = Random.Range(1, 7);
            number += add;
            increments++;
        }
        
        Debug.Log("number is incremented " + increments + " times, since it was less than 100."); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
