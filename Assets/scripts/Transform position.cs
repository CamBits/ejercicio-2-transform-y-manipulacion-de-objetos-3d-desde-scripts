using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Transformposition: MonoBehaviour
{

    //Public Atributes
    public Transform playerTransform;
    public Vector3 punto1 = new Vector2(5, 0);


    // Start is called before the first frame update
    void Start()
    {

        print("Pos x: " + punto1.x);
        print("Pos y: " + punto1.y);



    }

    // Update is called once per frame
    void Update()
    {
        playerTransform.localPosition = punto1;

        punto1 += Vector3.right * Time.deltaTime;
    }
}
