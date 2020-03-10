using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gunControll2 : MonoBehaviour
{
    private Rigidbody rb;
    public GameObject gunCubeSpawn;
    private Vector3 gunCubeSpawnPos;

    private Quaternion gunCubeSpawnRot;
    public GameObject bullet;
    private GameObject bulletInst;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void Update()
    {
        if (Input.GetKeyDown("9"))
        {
            shoot();
        }
    }

    void shoot()
    {
        Rigidbody rbBullet;
        //get GunCube Pos and Rotation
        gunCubeSpawnPos = gunCubeSpawn.transform.position;
        gunCubeSpawnRot = gunCubeSpawn.transform.rotation;
        //Instatiate
        bulletInst = Instantiate(bullet, gunCubeSpawnPos, gunCubeSpawnRot) as GameObject;
        //add force
        rbBullet = bulletInst.GetComponent<Rigidbody>();
        Debug.Log(rbBullet);
        rbBullet.AddForce(this.transform.up * 2f, ForceMode.Impulse);
    }
}
