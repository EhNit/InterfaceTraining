using UnityEngine;
using UnityEngine.UI;
namespace interface2
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
            var color_name = collision.gameObject.GetComponentInChildren<IColor>();
            text.text = color_name.GetName() + "BOX!";
        }
    }
}
