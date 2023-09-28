using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spinner : MonoBehaviour
{
    [SerializeField] float xAxis = 0;
    [SerializeField] float yAxis = 0;
    [SerializeField] float zAxis = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(xAxis,yAxis,zAxis);
    }
}
