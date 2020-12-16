using UnityEngine;
using System.Collections;

public class LOSEMOVE : MonoBehaviour {

    public string moveTo;
    public int timer11 = 0;
    public int timerEnd = 30;

    // Use this for initialization
    void Start () {
    }

    // Update is called once per frame
    void FixedUpdate () {
        timer11 ++;

        if (timer11 == timerEnd | timer11 >= timerEnd) {
            Application.LoadLevel(moveTo);
        }
    }
}
