using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeGenerator : MonoBehaviour{

    //Cube_no_prefab
    public GameObject cubePrefab;

    //Jikan-keisoku-you_no_hensuu
    private float delta = 0;

    //Cube_no_seisei-kankaku
    private float span = 1.0f;

    //Cube_no_seisei_iti_X-zahyou
    private float genPosX = 12;

    //Cube_no_seisei_iti_offset_Y
    private float offsetY = 0.3f;
    //Cube_no_tate-houkou_no_kankaku
    private float spaceY = 6.9f;

    //Cube_no_seisei_iti_offset_X
    private float offsetX = 0.5f;
    //Cube_no_yoko-houkou_no_kankaku
    private float spaceX = 0.4f;

    //Cube_no_seisei_kosuu_no_jougen
    private int maxBlockNum = 4;

    // Start is called before the first frame update
    void Start(){
        
    }

    // Update is called once per frame
    void Update(){
        this.delta += Time.deltaTime;

        //span-byou_ijou_no_jikan_ga_keika_sitaka_wo_siraberu
        if(this.delta > this.span){
            this.delta = 0;
            //Seisei_suru_cube_no_kazu_wo_random_ni_kimeru
            int n = Random.Range(1, maxBlockNum + 1);

            //Sitei_sita_kazu_dake_cube_wo_seisei_suru
            for(int i = 0; i < n; i++){
                //Cube_no_seisei
                GameObject go = Instantiate(cubePrefab);
                go.transform.position = new Vector2(this.genPosX, this.offsetY + (i * this.spaceY));
                //Debug.Log(this.offsetY + i * this.spaceY);
            }
            //Tugi_no_Cube_madeno_seisei_jikan_wo_kimeru
            this.span = this.offsetX + this.spaceX * n;
        }
    }
}
