using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Espacio3d : MonoBehaviour
{

    //Public Atributes
    public Transform SolTransform;
    public Transform TierraTransform;
    public Transform LunaTransform;


   
    public float speedRotationSol= 20f;
    public float speedRotationTierra= 20f;
    public float speedRotationLuna= 50f;

   

    // Start is called before the first frame update
    void Start()
    {




    }

    // Update is called once per frame
    void Update()
    {


        SolTransform.Rotate(0, speedRotationSol * Time.deltaTime, 0);
        TierraTransform.Rotate(0, speedRotationTierra * Time.deltaTime, 0);
        LunaTransform.Rotate(0, speedRotationLuna * Time.deltaTime, 0);


        TierraTransform.RotateAround(SolTransform.position, Vector3.up, speedRotationTierra * Time.deltaTime );
                                                                        
                                                                        
        LunaTransform.RotateAround(TierraTransform.position, Vector3.up,speedRotationLuna *  Time.deltaTime );

       
    }
}
