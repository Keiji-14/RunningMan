using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public float speed;
    public float scoreNum;
    public float position;
    private int jumpCount;
    private int stage;
    private int coin;
    private float countTime = 3.0f;

    [SerializeField] float jumpPower;
    [SerializeField] float speedUp_Border;
    [SerializeField] GameObject goalEffect;

    [Header("Flag")]
    public bool stageClearFlag = false;
    public bool stageDeadFlag = false;
    public bool endlessDeadFlag = false;

    [Header("SE")]
    public AudioClip jumpSE;
    public AudioClip hitSE;
    public AudioClip getSE;
    public AudioClip goalSE;

    [Header("Collider")]
    public BoxCollider2D col;

    [Header("Pause")]
    public Pause pause;
    
    Rigidbody2D body;
    Animator anim;
    AudioSource audioSource;

    void Start()
    {
        // コンポーネントの取得
        body = GetComponent<Rigidbody2D>();
        anim = gameObject.GetComponent<Animator>();
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        stage = PlayerPrefs.GetInt("STAGE", 0);
        scoreNum = body.position.x * 10;
        position = body.position.x;
        countTime -= Time.deltaTime;

        // カウントダウン
        if (countTime <= 0.0f){
            speed += 0.5f;
            anim.SetBool("Move", true);
            // 最初のスピードは10f
            if (scoreNum < speedUp_Border) 
            {
                speed = 10f;
            }

            // 一定のスコアごとにスピードが上がる
            for (int i = 1; i < 5; i++)
            {
                if (scoreNum > speedUp_Border * i)
                {
                    speed = 10 + i;
                }
            }

            // 死ぬまではジャンプが出来る
            if (!stageDeadFlag && !endlessDeadFlag)
            {
                if (!pause.pauseNow)
                {
                    if (Input.GetMouseButtonDown(0))
                    {
                        jumpCount += 1;
                        if (jumpCount < 2)
                        {
                            body.AddForce(transform.up * jumpPower);
                            audioSource.PlayOneShot(jumpSE);
                        }
                    }
                }
            }
            // ステージモードでのゲームクリアの処理
            if (stageClearFlag)
            {
                speed = 0.0f;
                stage = stage + 1;
                PlayerPrefs.SetInt("NEXT", stage);
                Invoke("StageGameClearChangeScene", 4.0f);
            }
            // ステージモードでのゲームオーバーの処理
            if (stageDeadFlag)
            {
                speed = 0.0f;
                col.enabled = false;
                Invoke("StageGameOverChangeScene", 2.0f);
            }
            // エンドレスモードでのゲームオーバーの処理
            if (endlessDeadFlag)
            {
                speed = 0.0f;
                col.enabled = false;
                Invoke("EndlessChangeScene", 2.0f);
            }
            // 地面に設置したらジャンプが再使用出来る様になる
            if (body.velocity.y == 0){
                jumpCount = 0;
            }
        }
    }

    // 壁やコインの衝突判定処理
    public void OnCollisionEnter2D(Collision2D collision)
    {
        // ステージモードのゴールに衝突した時の処理
        if (collision.gameObject.CompareTag("Goal"))
        {
            goalEffect.SetActive(true);
            audioSource.PlayOneShot(goalSE);
            stageClearFlag = true;
        }
        // ステージモードの壁に衝突した時の処理
        if (collision.gameObject.CompareTag("StageGame Wall"))
        {
            anim.SetBool("Dead", true);
            audioSource.PlayOneShot(hitSE);
            stageDeadFlag = true;
        }
        // エンドレスモードの壁に衝突した時の処理
        if (collision.gameObject.CompareTag("EndlessGame Wall"))
        {
            anim.SetBool("Dead", true);
            audioSource.PlayOneShot(hitSE);
            endlessDeadFlag = true;
        }
        // コインに衝突した時の処理
        if (collision.gameObject.CompareTag("Coin"))
        {
            coin = PlayerPrefs.GetInt("COIN", 0);
            coin += 1;
            audioSource.PlayOneShot(getSE);
            collision.gameObject.SetActive(false);
            PlayerPrefs.SetInt("COIN", coin);
        }
    }

    // ステージモードのゲームクリア画面に遷移
    void StageGameClearChangeScene()
    {
        SceneManager.LoadScene("StageGameClearScenes");
    }

    // ステージモードのゲームオーバー画面に遷移
    void StageGameOverChangeScene()
    {
        SceneManager.LoadScene("StageGameOverScenes");
    }

    // エンドレスモードのゲームオーバー画面に遷移
    void EndlessChangeScene()
    {
        SceneManager.LoadScene("EndlessGameOverScenes");
    }

    // 移動の処理
    private void FixedUpdate() {
        body.velocity = new Vector2(speed, body.velocity.y);
    }
}
