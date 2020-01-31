using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace IconicDesignStudios.Controller
{
    [RequireComponent(typeof(Rigidbody))]
    [RequireComponent(typeof(IDS_RBPlayer_Inputs))]
    public class IDS_RBPlayer_Controller : MonoBehaviour
    {
        public float playerSpeed = 15f;
        public float playerRotationSpeed = 75f;

        private Rigidbody rb;
        private IDS_RBPlayer_Inputs input;

        // Start is called before the first frame update
        void Start()
        {
            rb = GetComponent<Rigidbody>();
            input = GetComponent<IDS_RBPlayer_Inputs>();
        }

        // Update is called once per frame
        void FixedUpdate()
        {
            if (rb && input)
            {
                HandleMovement();
            }
        }

        protected virtual void HandleMovement()
        {
            Vector3 wantedPosition = transform.position + (transform.forward * input.ForwardInput * playerSpeed * Time.deltaTime);
            rb.MovePosition(wantedPosition);

            Quaternion wantedRotation = transform.rotation * Quaternion.Euler(Vector3.up * (playerRotationSpeed * input.RotationInput * Time.deltaTime));
            rb.MoveRotation(wantedRotation);
        }

    }
}