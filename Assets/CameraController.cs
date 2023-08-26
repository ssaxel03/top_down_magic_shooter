using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] private Camera camera;
    [SerializeField] private float cameraSpeed;
    [SerializeField] private float mouseBias;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 playerPos = player.position;
        Vector3 mousePos = camera.ScreenToWorldPoint(Input.mousePosition);

        Vector3 targetPos = (playerPos + mousePos * mouseBias) / (1 + mouseBias);

        Vector3 newPos = Vector3.Lerp(transform.position, targetPos, cameraSpeed * Time.deltaTime);
        newPos.z = transform.position.z;

        transform.position = newPos;
        
    }
}
