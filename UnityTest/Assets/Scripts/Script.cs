using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Julia {
    public class Script : MonoBehaviour
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }

        public string getVicky()
        {
            return "Vicky";
        }

        public Vector3 ChangesPosition(int X, int Y, int Z)
        {
            return new Vector3(X,Y,Z);
        }

        // Start is called before the first frame update
        void Start()
        {
            
        }

        // Update is called once per frame
        void Update()
        {
            
        }


    }
}
