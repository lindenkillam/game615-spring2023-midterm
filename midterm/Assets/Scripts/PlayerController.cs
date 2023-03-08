using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameManager gm;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float hAxis = Input.GetAxis("Horizontal");
        float vAxis = Input.GetAxis("Vertical");

        gameObject.transform.Translate(gameObject.transform.forward * Time.deltaTime * gm.moveSpeed * vAxis, Space.World);
        gameObject.transform.Rotate(0, gm.rotateSpeed * Time.deltaTime * hAxis, 0);
    }
}

/*
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // This will instantiate and launch 100 prefabs of the banana car.
            for (int i = 0; i < 100; i++)
            {
                GameObject car = Instantiate(bananaCar, gameObject.transform.position, Quaternion.identity);
                float rotXAmount = Random.Range(-89, -10);
                float rotYAmount = Random.Range(0, 360);
                car.transform.Rotate(rotXAmount, rotYAmount, 0);
                Rigidbody rb = car.GetComponent<Rigidbody>();
                rb.AddForce(car.transform.forward * 1000);

                Destroy(car, 2f);
            }
*/