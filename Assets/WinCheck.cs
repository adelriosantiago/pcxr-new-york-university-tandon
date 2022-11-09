using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinCheck : MonoBehaviour
{
    public GameObject winText;

    // Start is called before the first frame update
    void Start()
    {
        winText.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other) {
        Debug.Log("other");
        Debug.Log(other);

        if (other.gameObject.CompareTag("MainCamera")) {
            winText.SetActive(true);
        }
    }
}
