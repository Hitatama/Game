using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    [SerializeField] float waktuJatuh = 5f;
    MeshRenderer renderobjek;
    Rigidbody rigidbody;

    // Start is called before the first frame update
    void Start()
    {
        renderobjek = GetComponent<MeshRenderer>();
        rigidbody = GetComponent<Rigidbody>();

        renderobjek.enabled = false;
        rigidbody.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > waktuJatuh)
        {
            renderobjek.enabled = true;
            rigidbody.useGravity = true;
        }
    }
}
