using UnityEngine;

public class Target : MonoBehaviour
{

    private Rigidbody targetRb;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        targetRb = GetComponent<Rigidbody>();
        targetRb.AddForce(Vector3.up * Random.Range(12, 16), ForceMode.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
