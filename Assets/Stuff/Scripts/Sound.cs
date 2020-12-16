using UnityEngine;
using System.Collections;

public class Sound : MonoBehaviour {
    public string nameThe;
    public string nameThe2;
    public bool onSound = false;

    public bool makeSound = true;

    private AudioSource theSound;

    // Use this for initialization
    void Start () {
        theSound = GetComponent<AudioSource>();
        theSound.enabled = false;
    }

    // Update is called once per frame
    void Update () {
        GameObject go1 = GameObject.Find(nameThe);
        onSound = go1.GetComponent<SwitchOther>().on;
        GameObject go2 = GameObject.Find(nameThe2);
        makeSound = go2.GetComponent<Pause>().soundEffectsOn;

        if (makeSound == false) {
            theSound.mute = true;
        } else {
            theSound.mute = false;
        }

        if (onSound == false) {
            theSound.enabled = true;
        }
    }
}
