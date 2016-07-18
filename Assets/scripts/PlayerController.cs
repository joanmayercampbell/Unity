using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
    
	
	// Update is called once per frame
	
        public Rigidbody rb;
        public float speed;
        public bool[] CubeOrder = new bool[10];

        void Start()
    {
        rb = GetComponent<Rigidbody>();
        for (int i=0;i < CubeOrder.Length;i++)
        {
            CubeOrder[i] = false;
        }
    }

    void FixedUpdate()
    {

        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 force = new Vector3(moveHorizontal, 0, moveVertical);

        rb.AddForce(force*speed);

    } 

    bool checkBoxOrder(int index)
    {
        bool inOrder = true;  
        
        if (index == 1)
        {
            return inOrder;
        }

        int i;
        for (i=0; i< index;i++)
        {
            if (CubeOrder[i] == false)
            {
                break;
            }
        }

        if (i == index - 1)
        {
            return inOrder;
        }
        else
        {
            return false;
        }
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Cube1"))
        {
            if (checkBoxOrder(1))
            {
                other.gameObject.SetActive(false);
                CubeOrder[0] = true;
            }
        }
    
        if (other.gameObject.CompareTag("Cube2"))
        {
            if (checkBoxOrder(2))
            {
                other.gameObject.SetActive(false);
                CubeOrder[1] = true;
            }
        }
        if (other.gameObject.CompareTag("Cube3"))
        {
            if (checkBoxOrder(3))
            {
                other.gameObject.SetActive(false);
                CubeOrder[2] = true;
            }
        }
        if (other.gameObject.CompareTag("Cube4"))
        {
            if (checkBoxOrder(4))
            {
                other.gameObject.SetActive(false);
                CubeOrder[3] = true;
            }
        }
        if (other.gameObject.CompareTag("Cube5"))
        {
            if (checkBoxOrder(5))
            {
                other.gameObject.SetActive(false);
                CubeOrder[4] = true;
            }
        }
        if (other.gameObject.CompareTag("Cube6"))
        {
            if (checkBoxOrder(6))
            {
                other.gameObject.SetActive(false);
                CubeOrder[5] = true;
            }
        }
        if (other.gameObject.CompareTag("Cube7"))
        {
            if (checkBoxOrder(7))
            {
                other.gameObject.SetActive(false);
                CubeOrder[6] = true;
            }
        }
        if (other.gameObject.CompareTag("Cube8"))
        {
            if (checkBoxOrder(8))
            {
                other.gameObject.SetActive(false);
                CubeOrder[7] = true;
            }
        }
        if (other.gameObject.CompareTag("Cube9"))
        {
            if (checkBoxOrder(9))
            {
                other.gameObject.SetActive(false);
                CubeOrder[8] = true;
            }
        }
        if (other.gameObject.CompareTag("Cube10"))
        {
            if (checkBoxOrder(10))
            {
                other.gameObject.SetActive(false);
                CubeOrder[9] = true;
            }
        }
    }
	
}
