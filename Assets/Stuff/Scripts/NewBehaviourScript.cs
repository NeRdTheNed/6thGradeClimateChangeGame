using UnityEngine;
using System.Collections;
//If you have 'slash_slashTODO:' and other task comments in your code, they will show up in the task list. You can customize it with your own like '//THINK:' or '//RESEARCH:'.
//Search pads can be 'pinned' so that their results are not lost when further searches are performed.
//The 'override' keyword in C# activates code completion that can stub out overrides for virtual and abstract members from base classes and implementations of members in the interfaces that the class implements.
//Suggest a tip of the day by emailing monodevelop-list@lists.ximian.com.
//The 'Rename' context menu command for code identifiers will automatically find and correct all references.
//When C# Smart Indentation is enabled, the Tab key re-indents the current line.

public class NewBehaviourScript : MonoBehaviour {
    public float upForce = 80.0f;
    public float sideForce = 75.0f;
    public string rightKeyMove = "right";
    public string leftKeyMove = "left";
    public string upKeyMove = "up";
    public string downKeyMove = "down";
    public float minusUp = 5;
    public float jumpNum = 2;

    public float upMoveNow;
    public bool check1;
    public bool check2 = false;

    public bool check3 = false;

    public bool work = true;

    public float computeJumpNum;
    public float test = 0;

    public float distance = 0.1f;
    // Use this for initialization
    void Start () {
        if (work == true) {
            computeJumpNum = (jumpNum - test);
        }
    }

    // Update is called once per frame
    void Update () {
        RaycastHit2D hit = Physics2D.Raycast(transform.position, -Vector2.up, distance);

        if (hit.collider != null) {
            computeJumpNum = (jumpNum - test);
        }
    }

    void FixedUpdate () {
        if (work == true) {
            if (check1 == false) {
                upMoveNow = upForce;
                check1 = true;
            }

            if (Input.GetKey (rightKeyMove)) {
                GetComponent<Rigidbody2D>().AddForce (new Vector2 (sideForce, 0));
            }

            if (Input.GetKey (leftKeyMove)) {
                GetComponent<Rigidbody2D>().AddForce (new Vector2 (-sideForce, 0));
            }

            //Jump num decraese
            //Jump reset

            if (Input.GetKey (upKeyMove) && computeJumpNum >= 0) {
                GetComponent<Rigidbody2D>().AddForce (new Vector2 (0, upMoveNow));
            }

            if ((Input.GetKey (upKeyMove)) == true && (check2 == false) == true) {
                upMoveNow = upMoveNow - minusUp;

                if (upMoveNow <= 0) {
                    upMoveNow = 0;
                }
            }

            if (Input.GetKeyUp (upKeyMove)) {
                upMoveNow = upForce;
            }

            if ((Input.GetKeyDown (upKeyMove)) == true && (check3 == false) == true) {
                computeJumpNum--;

                if (computeJumpNum <= -1) {
                    computeJumpNum = -1;
                }
            }

            //Math.Abs
            if (Input.GetKey (downKeyMove)) {
                float down;
                down = (upForce - 20);

                if (down <= 0) {
                    down = 0;
                }

                GetComponent<Rigidbody2D>().AddForce (new Vector2 (0, -down));
            }
        }
    }
}
