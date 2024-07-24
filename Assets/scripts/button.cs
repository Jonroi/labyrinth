using UnityEngine;
using UnityEngine.UI;

public class Tes : MonoBehaviour
{
    //this is a field that contains the health, since it has [SerializeField] on it, it can be
    //initialized from the editor
    [SerializeField]
    private int _health;

    //codes in this method Start() only one when the game starts.
    private void Start()
    {
        //this line says if health didn't get initialized from the editor and it is 0 when the game starts
        //, set it to 100, other wise this line of code will be ignored.
        if (_health == 0)
        {
            _health = 100;
        }
    }

    //codes of this method Update() runs once every frame
    //for example if you play the game at 60 fps, this method runs 60 times per second.
    private void Update()
    {
        //if health is greater than 0, basically if the player/enemy is alive, run the Button() method.
        if (_health > 0)
        {
            Button();
        }
    }

    private void Button()
    {
        //if space key is pressed, decrease the health by 1
        //and convert it to string then set it to the Text component of this game object.
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _health--;
            GetComponent<Text>().text = _health.ToString();
        }
    }
}
