using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIController : MonoBehaviour{

    //GameOverText
    private GameObject gameOverText;

    //Soukou-kyori_Text
    private GameObject runLenghText;

    //Hassitta-kyori
    private float len = 0;

    //Hasiru_sokudo
    private float speed = 5f;

    //GameOver_no_hantei
    private bool isGameOver = false;

    // Start is called before the first frame update
    void Start(){
        //Scene-view_kara_objecto_no_jittai_wo_kensakusuru
        this.gameOverText = GameObject.Find("GameOver");
        this.runLenghText = GameObject.Find("RunLength");
    }

    // Update is called once per frame
    void Update(){
        if(this.isGameOver == false){
            //Hasitta_kyori_wo_kousin_suru
            this.len += this.speed * Time.deltaTime;

            //Hasitta_kyori_wo_hyouji_suru
            this.runLenghText.GetComponent<Text>().text = "Distance: " + len.ToString("F2") + "m";
        }

        //GameOver_ni_natta_baai
        if(this.isGameOver == true){
            //Click_saretara_scene_wo_load_suru
            if(Input.GetMouseButtonDown(0)){
                //SampleScene_wo_yomikomu
                SceneManager.LoadScene("SampleScene2");
            }
        }
    }

    public void GameOver(){
        //Gameover_ni_natta_tokini_gamenjou_ni_Game Over_wo_hyouji_suru
        this.gameOverText.GetComponent<Text>().text = "Game Over";
        this.isGameOver = true;
    }
}
