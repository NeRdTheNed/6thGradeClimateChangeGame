using UnityEngine;
using System.Collections;
//In Gtk#, create widgets that inherit Gtk.Bin and they will show up in the designer's toolbox for easy reuse.

public class Doormove : MonoBehaviour {
    public float distance = 0.1f;
    public string moveTo;
    public bool debug = false;
    public string thingDetected = "Player";
    // Use this for initialization
    void Start () {
    }

    // Update is called once per frame
    void Update () {
        RaycastHit2D hit = Physics2D.Raycast(transform.position, -Vector2.right, distance);

        if ((hit.collider != null) && (hit.collider.tag == thingDetected)) {
            Application.LoadLevel(moveTo);

            if (debug == true) {
                Debug.Log("Hi door!");
            }
        }
    }
}
