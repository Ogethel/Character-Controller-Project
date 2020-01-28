using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace IconicDesignStudios.Controller
{
    [RequireComponent(typeof(Rigidbody))]
    [RequireComponent(typeof(IDS_RBPlayer_Inputs))]
    public class IDS_RBPlayer_Controller : MonoBehaviour
    {
        private Rigidbody rb;
        private IDS_RBPlayer_Inputs input;

        // Start is called before the first frame update
        void Start()
        {
            rb = GetComponent<Rigidbody>();
            input = GetComponent<IDS_RBPlayer_Inputs>();
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}