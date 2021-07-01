using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class smew : MonoBehaviour
{


    public Rigidbody rb;
    public GameObject Target;
    public float speed;
    private Vector3 point;
    private bool dragging = false;
    private float distance;
    public bool x = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    void OnMouseDown()
    {
        distance = Vector3.Distance(transform.position, Camera.main.transform.position);
        /*
         if (x == true)
        {
            dragging = true;
            
        }
        
        else
        {
            dragging = false;   
        }
        x = !x;
         
         */
        
        dragging = true;

      



        //dragging = true;
    }
    void OnMouseUp()
    {
    
        dragging = false;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (dragging)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            Vector3 rayPoint = ray.GetPoint(distance);
            transform.position = rayPoint;
        }
 
        //x = !x;
        //Vector3 Dir = Target.transform.position - gameObject.transform.position;
        //rb.AddForce(Dir.normalized * speed);
    }
}