using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace interface2
{
    public class BoxGreen : MonoBehaviour, IColor
    {
        public string GetName()
        {
            return "GREEN";
        }
    }
}
