using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBall : MonoBehaviour
{
    public GameObject prefab;
    public float spawnSpeed = 5;
    private float Reload;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Reload = Mathf.Max(0, Reload - Time.deltaTime);
        if (
            OVRInput.GetDown(OVRInput.Button.SecondaryIndexTrigger)
            ||
            (
                OVRInput.Get(OVRInput.Button.SecondaryIndexTrigger)
                &&
                OVRInput.Get(OVRInput.Button.SecondaryHandTrigger)
                &&
                Reload <= 0
            )
        )
        {
            Reload = 0.075f;
            OVRInput.SetControllerVibration(100, 0.03f, OVRInput.Controller.RTouch);
            var spawnedBall = Instantiate(prefab, transform.position, Quaternion.identity);
            var spawnedBallRB = spawnedBall.GetComponent<Rigidbody>();
            spawnedBallRB.velocity = transform.forward * spawnSpeed;
        }
    }
}
