using System.Runtime.InteropServices.ComTypes;
using UnityEngine;

namespace KID
{
    public class UnityChan : MonoBehaviour
    {
        private Animator ani;

        private void Start()
        {
            ani = GetComponent<Animator>();
        }

        private void Update()
        {
            Move();
        }

        /// <summary>
        /// 移動：按下 W 走路，放開恢復
        /// </summary>
        private void Move()
        {
            if (Input.GetKeyDown(KeyCode.W))
            {
                ani.SetBool("走路開關", true);
            }
            else if (Input.GetKeyUp(KeyCode.W))
            {
                ani.SetBool("走路開關", false);
            }
        }
    }
}
