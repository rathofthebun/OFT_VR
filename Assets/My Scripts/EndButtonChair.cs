using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;
using UnityEngine.SceneManagement;

public class EndButtonChair : MonoBehaviour
{
    private GameObject object1;

    private FirstPersonController speed;
  

    void Update()
    {
        speed = FindObjectOfType<FirstPersonController>();
        object1 = GameObject.Find("chFolding.A_LOD0");



        if (Input.GetKeyDown("1"))
        {
            speed.m_WalkSpeed = 0f;
            float distance = Vector3.Distance(object1.transform.position, transform.position);
            MeshRenderer m = object1.GetComponent<MeshRenderer>();
            m.enabled = true;
            print("Distance to Chair: " + distance);
        }

    }
}