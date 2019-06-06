using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;
using UnityEngine.SceneManagement;

public class EndButton : MonoBehaviour
{
    private GameObject object1;
    private GameObject object2;
    private GameObject object3;
    private GameObject object31;
    private GameObject object32;
    private GameObject object4;
    private FirstPersonController speed;
  

    void Update()
    {
        speed = FindObjectOfType<FirstPersonController>();
        object1 = GameObject.Find("chFolding.A_LOD0");
        object2 = GameObject.Find("Soccer Ball");
        object3 = GameObject.Find("Bucket_clean");
        object31 = GameObject.Find("bucket_low");
        object32 = GameObject.Find("rings_low");
        object4 = GameObject.Find("cone_clean");


        if (Input.GetKeyDown("1"))
        {
            speed.m_WalkSpeed = 0f;
            float distance = Vector3.Distance(object1.transform.position, transform.position);
            MeshRenderer m = object1.GetComponent<MeshRenderer>();
            m.enabled = true;
            print("Distance to Chair: " + distance);
        }

        if (Input.GetKeyDown("2"))
        {
            speed.m_WalkSpeed = 0f;
            float distance = Vector3.Distance(object2.transform.position, transform.position);
            MeshRenderer m = object2.GetComponent<MeshRenderer>();
            m.enabled = true;
            print("Distance to Soccer Ball: " + distance);
        }

        if (Input.GetKeyDown("3"))
        {
            speed.m_WalkSpeed = 0f;
            float distance = Vector3.Distance(object3.transform.position, transform.position);
            MeshRenderer m = object31.GetComponent<MeshRenderer>();
            m.enabled = true;
            MeshRenderer n = object32.GetComponent<MeshRenderer>();
            n.enabled = true;
            print("Distance to Bucket: " + distance);
        }

        if (Input.GetKeyDown("4"))
        {
            speed.m_WalkSpeed = 0f;
            float distance = Vector3.Distance(object4.transform.position, transform.position);
            MeshRenderer m = object4.GetComponent<MeshRenderer>();
            m.enabled = true;
            print("Distance to Traffic Cone: " + distance);
        }

        if (Input.GetKeyDown(KeyCode.Return))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}