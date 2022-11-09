using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CopKeyCheck : MonoBehaviour
{
    public GameObject barrier;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other) {
        Debug.Log("other");
        Debug.Log(other);

        if (other.gameObject.name == "Key") {
            Debug.Log("Remove barrier");
            barrier.SetActive(false);
        }
    }
}
