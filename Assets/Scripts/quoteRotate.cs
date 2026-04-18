using UnityEngine;

public class quoteRotate : MonoBehaviour
{
    GameObject mainCamera;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        foreach (GameObject myCamera in GameObject.FindGameObjectsWithTag("MainCamera"))
        {
            mainCamera = myCamera;
            break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(mainCamera.transform);
        transform.Rotate(0, 180, 0);
    }
}
