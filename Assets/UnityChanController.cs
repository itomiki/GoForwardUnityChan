using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnityChanController : MonoBehaviour{

    //Animation_wo_suru_tame_no_component_wo_ireru
    Animator animator;

    //Unitychan_wo_idou_saseru_component_wo_ireru
    Rigidbody2D rigid2D;

    //Dimen_no_iti
    private float groundLevel = -3.0f;

    //Jump_no_sokudo_no_gensui
    private float dump = 0.8f;

    //Jump_no_sokudo
    float jumpVelocity = 20;

    //GameOver_ni_naru_iti
    private float deadLine = -9;

    // Start is called before the first frame update
    void Start(){

        //Animator_no_component_wo_syutokusuru
        this.animator = GetComponent<Animator>();
        //Rigidbody2D_no_component_wo_syutoku
        this.rigid2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update(){
        //Animator_no_prameter_wo_tyousei_suru
        this.animator.SetFloat("Horizontal", 1);

        //Tyakuti_siteiruka_douka_wo_siraberu
        bool isGround = (transform.position.y > this.groundLevel) ? false : true;
        this.animator.SetBool("isGround", isGround);

        //Jump_joutai_no_tokiniha_volume_wo_0_ni_suru
        GetComponent<AudioSource>().volume = (isGround) ? 1 : 0;

        //Tyakuti-joutai_de_click_sareta_baai
        if(Input.GetMouseButton(0) && isGround){
            //Up-houkou_no_tikara_wo_kakeru
            this.rigid2D.velocity = new Vector2(0, this.jumpVelocity);
        }

        //Click_wo_yametara_Up-houkou_heno_sokudo_wo_gensoku_suru
        if(Input.GetMouseButton(0) == false){
            if(this.rigid2D.velocity.y > 0){
                this.rigid2D.velocity *= this.dump;
            }
        }

        //DeadLine_wo_koeta_baai_gameover_ni_suru
        if(transform.position.x < this.deadLine){
            //UIController_no_GameOver-kansuu_wo_yobidasite_gamenjou_ni_GameOver_to_hyouji_suru
            GameObject.Find("Canvas").GetComponent<UIController>().GameOver();

            //UnityChan_wo_haki_suru
            Destroy(gameObject);
        }
    }
}
