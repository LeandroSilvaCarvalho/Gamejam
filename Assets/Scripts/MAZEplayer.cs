using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MAZEplayer : MonoBehaviour
{
    //动画组件
    private Animator ani;
    //刚体组件
    private Rigidbody2D rBody;

    // Start is called before the first frame update
    void Start()
    {
        //获取两个组件
        ani = GetComponent<Animator>();
        rBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

        //获取水平轴
        float horizontal = Input.GetAxisRaw("Horizontal");


        //获取垂直轴
        float vertical = Input.GetAxisRaw("Vertical");

        //左右
        if (horizontal != 0)
        {


            ani.SetFloat("Vertical", 0);
            ani.SetFloat("Horizontal", horizontal);

        }
        //上下
        if (vertical != 0)
        {

            ani.SetFloat("Horizontal", 0);
            ani.SetFloat("Vertical", vertical);
        }
        //切换
        Vector2 dir = new Vector2(horizontal, vertical);
        ani.SetFloat("Speed", dir.magnitude);


        //变速

        if (Input.GetKey(KeyCode.LeftShift))
        {
            rBody.velocity = dir * 6f;
        }
        else
        {
            rBody.velocity = dir * 3f;
        }

    }
}