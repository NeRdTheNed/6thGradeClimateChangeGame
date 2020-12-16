using UnityEngine;
using System.Collections;

public class ButtonController : MonoBehaviour {
    public static ButtonController Instance;

    void Awake() {
        if (Instance) {
            DestroyImmediate(gameObject);
        } else {
            DontDestroyOnLoad(gameObject);
            Instance = this;
        }
    }
}