using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextBehavior : MonoBehaviour {

	public Text text;

	private enum States {
		tutorial,inicio,caminando, objetos, sombras, dox, r, f, c, robar, artefacto, plantas_1,
		plantas_2, vulpis, godales, silmes
	};

	private States myState;

	// Use this for initialization
	void Start () {
		myState = States.tutorial;
	}

	// Update is called once per frame
	void Update () {
		print (myState);
		if 		(myState == States.tutorial)	{tutorial();} 
		else if (myState == States.inicio) 		{inicio();} 
		else if (myState == States.caminando) 	{caminando();} 
		else if (myState == States.objetos) 	{objetos();} 
		else if (myState == States.sombras) 	{sombras();}
		else if (myState == States.dox)		 	{dox();} 
		else if (myState == States.r) 			{r();}
		else if (myState == States.f) 			{f();} 
		else if (myState == States.c) 			{c();}
		else if (myState == States.robar) 		{robar();}
		else if (myState == States.artefacto) 	{artefacto();} 
		else if (myState == States.plantas_1) 	{plantas_1();} 
		else if (myState == States.plantas_2) 	{plantas_2();}
		else if (myState == States.vulpis)		{vulpis();}
		else if (myState == States.godales) 	{godales();} 
		else if (myState == States.silmes) 		{silmes ();}
	}

	void tutorial(){ 
		text.text = "presiona la barra espaciadora para ver el siguiente texto";
		if(Input.GetKeyDown(KeyCode.Space)) {myState = States.inicio;}
	}

	void inicio(){
		text.text = "Entras por la puerta a un largo corredor sin ventanas. Está iluminado artificialmente por luz cuya fuente no logras identificar." +
			"No parece haber nada en la habitación, excepto por Miriam." +
			"No sabes cuánto tiempo llevan caminando, pero tus piernas están cansadas y tus pies duelen. \'Oye Miriam...\n";
		if (Input.GetKeyDown (KeyCode.Space)) {myState = States.caminando;}

	}

	void caminando(){
		text.text = "adfasdfsafdsdfas" +
			"Presiona O para ver los objetos de la habitación" +
			"Presiona S para ver las sombras de la habitación";
		if (Input.GetKeyDown (KeyCode.O)) {myState = States.objetos;}

	}

	void objetos(){
		text.text = "adfasdfsafdsdfas" +
			"Go";
	}

	void sombras(){
		text.text = "adfasdfsafdsdfas" +
			"Go";
	}

	void dox(){
		text.text = "adfasdfsafdsdfas" +
			"Go";
	}

	void r(){
		text.text = "adfasdfsafdsdfas" +
			"Go";
	}

	void f(){
		text.text = "adfasdfsafdsdfas" +
			"Go";

	}

	void c(){
		text.text = "adfasdfsafdsdfas" +
			"Go";
	}

	void robar(){
		text.text = "adfasdfsafdsdfas" +
			"Go";
	}

	void artefacto(){
		text.text = "adfasdfsafdsdfas" +
			"Go";
	}

	void plantas(){
		text.text = "adfasdfsafdsdfas" +
			"Go";
	}

	void plantas_1(){
		text.text = "adfasdfsafdsdfas" +
			"Go";
	}

	void plantas_2(){
		text.text = "adfasdfsafdsdfas" +
			"Go";
	}

	void vulpis(){
		text.text = "adfasdfsafdsdfas" +
			"Go";
	}

	void godales(){
		text.text = "adfasdfsafdsdfas" +
			"Go";
	}

	void silmes(){
		text.text = "adfasdfsafdsdfas" +
			"Go";
	}
}
