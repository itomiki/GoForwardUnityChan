using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundController : MonoBehaviour{

    //Scroll_sokudo
    private float scrollSpeed = -1;
    //Haikei_syuuryou_iti
    private float deadLine = -16;
    //Haikei_kaisi_iti
    private float startLine = 15.8f;

    // Start is called before the first frame update
    void Start(){
        
    }

    // Update is called once per frame
    void Update(){
        //Haikei_wo_idou_suru
        transform.Translate(this.scrollSpeed * Time.deltaTime, 0, 0);

        //Gamen-gai_ni_detara_gamen-migihasi_ni_idou_suru
        if(transform.position.x < this.deadLine){
            transform.position = new Vector2(this.startLine, 0);
        }
    }
}
