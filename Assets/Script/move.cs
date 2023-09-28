using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Threading;
using UnityEngine;


public class move : MonoBehaviour
{
    public float Movespeed = 10f;

    // Start is called before the first frame update
    void Start()
    {
        PrintAwal();
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
    }

    void PrintAwal()
    {
        Debug.Log("Selamat Datang");
        Debug.Log("mainkan dengan Keyboard WSAD");
        Debug.Log("Jangan tabrak tembok");
    }

    void MovePlayer()
    {
        float xvalue = Input.GetAxis("Horizontal") * Time.deltaTime * Movespeed;
        float zvalue = Input.GetAxis("Vertical") * Time.deltaTime * Movespeed;
        transform.Translate(xvalue, 0, zvalue);
    }
}
