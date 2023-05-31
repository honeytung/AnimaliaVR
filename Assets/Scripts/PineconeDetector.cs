using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PineconeDetector : MonoBehaviour {
    [SerializeField] GameObject successUI;
    [SerializeField] AudioSource audioSource;
    [SerializeField] GameObject homePosition;
    [SerializeField] GameObject[] pinecones;


    bool isActive;
    bool isInRange;

    // Start is called before the first frame update
    void Start() {
        isActive = false;
        isInRange = false;
        successUI.SetActive(isActive);
    }

    // Update is called once per frame
    void Update() {

        if(!isInRange) {
            foreach(GameObject pinecone in pinecones) {
                if(Vector3.Distance(homePosition.transform.position, pinecone.transform.position) < 1) {
                    isInRange = true;
                }
                else {
                    isInRange = false;
                    break;
                }
            }

            if(isInRange) {
                isActive = true;
                successUI.SetActive(isActive);
                audioSource.Play();
            }
        }
        else {
            if (OVRInput.GetUp(OVRInput.Button.One)) {
                SceneManager.LoadScene(0);
            }
        }
    }
}
