using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour {
    void Update() {
        if (OVRInput.GetUp(OVRInput.Button.One)) {
            LoadNextScene();
        }
    }

    void LoadNextScene() {
        Scene scene = SceneManager.GetActiveScene();
        int nextLevelBuildIndex = 1 - scene.buildIndex;
        SceneManager.LoadScene(nextLevelBuildIndex);
    }
}
