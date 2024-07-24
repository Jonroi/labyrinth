using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    // Start is called before the first frame update
    public float counter = 0;

    // Update is called once per frame
    void Update()
    {
        counter += Time.deltaTime;
        if (counter >= 10f)
        {
            Debug.Log("BOOOM!!!");
            counter = 0f;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            StartCoroutine(SpacePressedCoroutine());
        }
    }

    private IEnumerator SpacePressedCoroutine()
    {
        yield return new WaitForSeconds(2f);
        Debug.Log("Space pressed!");
    }
}
