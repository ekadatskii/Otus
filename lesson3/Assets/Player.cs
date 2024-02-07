using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public Transform cameraTransform;
    public Transform myTransform;
    private Camera cam;

    public void Awake()
    {
        myTransform = GetComponent<Transform>();
        cam = Camera.main;
    }
    // Start is called before the first frame update
    void Start()
    {
    }

    private Vector3 currentInput = new();
    public float _speed;
    // Update is called once per frame
    void Update()
    {
        currentInput = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        currentInput += currentInput * Time.deltaTime * _speed;
        transform.position += currentInput;
    }

    private void OnEnable()
    {
    }
}
