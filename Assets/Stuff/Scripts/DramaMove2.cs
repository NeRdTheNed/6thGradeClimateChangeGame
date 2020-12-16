using UnityEngine;
using System.Collections;

public class DramaMove2 : MonoBehaviour {

    public float moveByX;
    public float moveByY;
    public float moveX = 0.0f;
    public float moveY = 0.0f;
    public bool movedX = false;
    public bool movedY = false;
    public string moveTo;

    // Use this for initialization
    void Start () {
    }

    // Update is called once per frame
    void FixedUpdate () {
        if (transform.position.x >= moveX) {
            movedX = true;
        } else {
            transform.Translate(moveByX, 0, 0);
        }

        if (transform.position.y <= moveY) {
            movedY = true;
        } else {
            transform.Translate(0, moveByY, 0);
        }

        if (movedX == true && movedY == true) {
            Application.LoadLevel(moveTo);
        }
    }
}
