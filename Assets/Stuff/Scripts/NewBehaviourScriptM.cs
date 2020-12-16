using UnityEngine;
using System.Collections;
//The command-line program 'mdtool' can be used to build MD solutions and generate Makefiles, among other things.
//Double-click on an editor tab to hide all pads, maximising the editing space. Double-click again to restore the previous state.
//Add XML documentation comments, which start with '///', and they will show up in tool tips and code completion.

public class NewBehaviourScriptM : MonoBehaviour {
    public float distance = 0.1f;
    public bool debug = false;
    // Use this for initialization
    void Start () {
    }

    // Update is called once per frame
    void Update () {
        bool onGround = Physics.Raycast(transform.position, Vector3.down, distance);

        if (onGround == true && debug == true) {
            Debug.Log("It worked!");
        }
    }
}
