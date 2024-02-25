using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;

public class ClosestDino : MonoBehaviour
{

   void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject[] objects = GameObject.FindGameObjectsWithTag("Dino");
            GameObject closest = null;
            float dot = -2;

            foreach (GameObject obj in objects)
            {
                Vector3 localPoint = Camera.main.transform.InverseTransformPoint(obj.transform.position).normalized;
                Vector3 forward = Vector3.forward;
                float test = Vector3.Dot(localPoint, forward);
                
                if (test > dot)
                {
                    dot = test;
                    closest = obj;
                }
            }
            PointValues script = closest.GetComponent<PointValues>();
            int x = script.pointValue;
            if (closest != null)
            {
                pointCounter.singleton.RegisterCoin(x);
                Debug.Log(closest);
                Debug.Log(x);
            }
        }
    }
}
