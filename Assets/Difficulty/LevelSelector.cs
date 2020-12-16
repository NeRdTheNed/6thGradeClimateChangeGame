using UnityEngine;
using System.Collections;

public class LevelSelector : MonoBehaviour {

    public bool level1 = false;
    public bool level2 = false;
    public bool level3 = false;

    public string levelName;

    public string name1;
    public string name2;
    public string name3;

    public bool debug = false;

    void Awake() {
        DontDestroyOnLoad(transform.gameObject);
    }

    // Use this for initialization
    void Start () {
    }

    // Update is called once per frame
    void FixedUpdate () {
        if (Application.loadedLevel == 0) {
            level1 = false;
            level2 = false;
            level3 = false;
        }

        if (Application.loadedLevel == 1) {
            if (level1 == true) {
                Application.LoadLevel(levelName);

                if (debug == true) {
                    print ("Hi door 1!");
                }
            }

            if (level2 == true) {
                Application.LoadLevel(levelName);

                if (debug == true) {
                    print ("Hi door 2!");
                }
            }

            if (level3 == true) {
                Application.LoadLevel(levelName);

                if (debug == true) {
                    print ("Hi door 3!");
                }
            }

            GameObject go1 = GameObject.Find(name1);
            GameObject go2 = GameObject.Find(name2);
            GameObject go3 = GameObject.Find(name3);
            level1 = (go1.GetComponent<DoormoveDif>().levelDoor == true);
            level2 = (go2.GetComponent<DoormoveDif>().levelDoor == true);
            level3 = (go3.GetComponent<DoormoveDif>().levelDoor == true);
        }
    }
}
