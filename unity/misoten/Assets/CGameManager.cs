using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CGameManager : MonoBehaviour {
    void Quit() {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#elif UNITY_STANDALONE
      UnityEngine.Application.Quit();
#endif
    }
    private void Start() {
        Application.targetFrameRate = 60;
    }
    void Update() {
        if (Input.GetKey(KeyCode.Escape)) Quit();
    }
}
