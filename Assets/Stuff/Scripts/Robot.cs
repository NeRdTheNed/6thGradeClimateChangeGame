using UnityEngine;
using System.Collections;

public class Robot : MonoBehaviour {
    public float sideForce = 50f;
    public float length = 10;
    public bool right;
    public bool left;
    public bool work = true;
    public string wallName = "Walls";


    // Use this for initialization
    void Start () {
        right = true;
    }

    // Update is called once per frame
    void Update () {
        if (work == true) {
            RaycastHit2D hitLeft = Physics2D.Raycast(transform.position, -Vector2.right, length);
            RaycastHit2D hitRight = Physics2D.Raycast(transform.position, Vector2.right, length);

            if (hitRight.collider.tag == wallName) {
                right = false;
                left = true;
                Debug.Log("Wall to the right!");
            }

            if (hitLeft.collider.tag == wallName) {
                right = true;
                left = false;
                Debug.Log("Wall to the left!");
            }

            if (right == true) {
                rigidbody2D.AddForce (new Vector2 (sideForce, 0));
            }

            if (left == true) {
                rigidbody2D.AddForce (new Vector2 (-sideForce, 0));
            }
        }
    }
}

