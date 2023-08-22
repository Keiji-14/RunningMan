using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitlePlayer : MonoBehaviour
{
    private int changeCount = 0;
    private bool jump1 = false;
    private bool jump2 = false;

    [Header("Start Position")]
    public float reStartX;
    public float reStartY;

    [Header("Move")]
    [SerializeField] float speed;
    [SerializeField] float jumpPower;

    [Header("Jump Position")]
    [SerializeField] float jumpPos1;
    [SerializeField] float jumpPos2;

    Rigidbody2D body;
    Animator anim;

    void Start()
    {
        body = GetComponent<Rigidbody2D>();
        anim = gameObject.GetComponent<Animator>();
    }

    // �^�C�g����ʂ̃v���C���[�̓����̏����i4�p�^�[�������[�v�j
    void Update()
    {
        // �������[�V�����ɐݒ�
        anim.SetBool("Move", true);

        // �p�^�[�����n�߂ɖ߂�
        if (changeCount > 3)
        {
            changeCount = 0;
        }

        switch (changeCount)
        {
            case 0:
                // �ݒ肵���ʒu�ɒ������璵�˂�
                if (Mathf.Floor(this.transform.position.x) == jumpPos1)
                {
                    if (!jump1)
                    {
                        jump1 = true;
                        jump2 = false;
                        body.AddForce(transform.up * jumpPower);
                    }
                }
                if (Mathf.Floor(this.transform.position.x) == jumpPos2)
                {
                    if (!jump2)
                    {
                        jump1 = false;
                        jump2 = true;
                        body.AddForce(transform.up * jumpPower);
                    }
                }
                break;
            case 1:
                if (Mathf.Floor(this.transform.position.x) == jumpPos1)
                {
                    if (!jump1)
                    {
                        jump1 = true;
                        jump2 = false;
                        body.AddForce(transform.up * jumpPower);
                    }
                }
                break;
            case 2:
                if (Mathf.Floor(this.transform.position.x) == jumpPos2)
                {
                    if (!jump2)
                    {
                        jump1 = false;
                        jump2 = true;
                        body.AddForce(transform.up * jumpPower);
                    }
                }
                break;
            case 3:  
                break;
        }
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        // �ǂɏՓ˂����珉���ʒu�ɖ߂�
        if (collision.gameObject.CompareTag("ReStart Wall"))
        {
            changeCount += 1;
            transform.position = new Vector2(reStartX, reStartY);
        }
    }

    // �ړ��̏���
    private void FixedUpdate()
    {
        body.velocity = new Vector2(speed, body.velocity.y);
    }
}
