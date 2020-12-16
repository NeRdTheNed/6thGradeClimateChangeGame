using UnityEngine;
using System.Collections;
//In Gtk#, create widgets that inherit Gtk.Bin and they will show up in the designer's toolbox for easy reuse.

public class Doormove3 : MonoBehaviour {
    public float distance = 0.1f;
    public string moveTo;
    public bool debug = false;

    public Sprite sprite1;
    public Sprite sprite2;
    public string name1;
    public string name2;
    public string name3;
    public string name4;
    public string name5;
    public string name6;
    public string name7;
    public string name8;
    public bool onDoor = false;
    public bool onDoor1 = false;
    public bool onDoor2 = false;
    public bool onDoor3 = false;
    public bool onDoor4 = false;
    public bool onDoor5 = false;
    public bool onDoor6 = false;
    public bool onDoor7 = false;
    public bool onDoor8 = false;
    private SpriteRenderer spriteRenderer;

    public string thingDetected = "Player";

    // Use this for initialization
    void Start () {
        spriteRenderer = GetComponent<SpriteRenderer>();
        onDoor = false;
    }

    // Update is called once per frame
    void Update () {
        GameObject go1 = GameObject.Find(name1);
        GameObject go2 = GameObject.Find(name2);
        GameObject go3 = GameObject.Find(name3);
        GameObject go4 = GameObject.Find(name4);
        GameObject go5 = GameObject.Find(name5);
        GameObject go6 = GameObject.Find(name6);
        GameObject go7 = GameObject.Find(name7);
        GameObject go8 = GameObject.Find(name8);
        onDoor1 = (go1.GetComponent<SwitchOther>().on == false);
        onDoor2 = (go2.GetComponent<SwitchOther>().on == false);
        onDoor3 = (go3.GetComponent<SwitchOther>().on == false);
        onDoor4 = (go4.GetComponent<SwitchOther>().on == false);
        onDoor5 = (go5.GetComponent<SwitchOther>().on == false);
        onDoor6 = (go6.GetComponent<SwitchOther>().on == false);
        onDoor7 = (go7.GetComponent<SwitchOther>().on == false);
        onDoor8 = (go8.GetComponent<SwitchOther>().on == false);

        if (onDoor1 == true && onDoor2 == true && onDoor3 == true && onDoor4 == true && onDoor5 == true && onDoor6 == true && onDoor7 == true && onDoor8 == true) {
            onDoor = true;
        }

        if (spriteRenderer.sprite == null) {
            spriteRenderer.sprite = sprite1;
        }

        if (onDoor == true) {
            spriteRenderer.sprite = sprite2;
            RaycastHit2D hit = Physics2D.Raycast(transform.position, -Vector2.right, distance);

            if ((hit.collider != null) && (hit.collider.tag == thingDetected)) {
                Application.LoadLevel(moveTo);

                if (debug == true) {
                    Debug.Log("Hi door!");
                }
            }
        }
    }
}
