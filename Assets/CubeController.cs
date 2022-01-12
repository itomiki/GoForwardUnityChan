using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour{

    //Cube_no_idou-sokudo
    private float speed = -12;

    //Syoumetu_iti
    private float deadLine = -10;

    // Start is called before the first frame update
    void Start(){
        
    }

    // Update is called once per frame
    void Update(){
        //Cube_wo_idou_saseru
        transform.Translate(this.speed * Time.deltaTime, 0, 0);

        //Gamen-gai_ni_detara_haki_suru
        if(transform.position.x < this.deadLine){
            Destroy(gameObject);
        }
    }

	//Koukaon_wo_narasu_tameno_syoutotu_hantei
	void OnCollisionEnter2D(Collision2D other){
        //Ground-object_or_CubePrefab_ni_syoutotu_sita_toki_koukaon_wo_narasu
		if(other.gameObject.tag == "GroundTag" || other.gameObject.tag == "CubeTag"){
			GetComponent<AudioSource>().Play();
		}
	}
}
