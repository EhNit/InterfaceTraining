using UnityEngine;
namespace interface2
{
    public class BoxRed : MonoBehaviour, IColor
    {
        public string GetName()
        {
            return "RED";
        }
    }
}
