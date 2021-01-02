using UnityEngine;
using UnityEngine.UI;
namespace interface1
{
    public class Plane : MonoBehaviour
    {
        Text text;
        private void Start()
        {
            this.text = GameObject.Find("Text").GetComponent<Text>();
        }

        private void OnCollisionEnter(Collision collision)
        {
            text.text = "Collision!";
        }
    }
}
