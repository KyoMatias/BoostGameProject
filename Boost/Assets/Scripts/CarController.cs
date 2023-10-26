using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    //[Boolean is used as a Catch Parameter to Differentiate between NIS and Ingame Physics]
    public bool IsSequenced;
    public bool IsControlled;

    public float Gas;
    public float Brake;
    public float Steer;
    public float HP;
    public float BHP;
    public float slip;
    private float speed;
    public AnimationCurve SteerCurve;

    //[Paramters for Car Physics]
    private Rigidbody rb;
    public WheelMeshes _wheelMeshes;
    public WheelColliders _wheelCollider;

    [SerializeField] private string carname;
    // Start is called before the first frame update

    [System.Serializable]
    public class WheelMeshes 
    {
        public MeshRenderer FL;
        public MeshRenderer FR;
        public MeshRenderer BL;
        public MeshRenderer BR;
    }
    [System.Serializable]
    public class WheelColliders
    {
        public MeshRenderer FL;
        public MeshRenderer FR;
        public MeshRenderer BL;
        public MeshRenderer BR;
    }



    void Start()
    {
        IsSequenced = true;
        CheckUserControl();
        rb = gameObject.GetComponent<Rigidbody>();
    }


    void FixedUpdate()
    {
        
    }

    public void CheckUserControl()
    {
        //This Is a net to check if the user is allowed control of the vehicle physics (this is due to the model either in a cutscene)
    }

    public void ControllerOveride()
    {
        
    }
}
