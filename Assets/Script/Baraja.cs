using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Baraja : MonoBehaviour {

    int cantidad = 13;
    int palos = 4;

    //Naipe[] picas = new Naipe[13]; //1
    //Naipe[] treboles = new Naipe[13]; //2
    //Naipe[] corazones = new Naipe[13]; //3
    //Naipe[] diamantes = new Naipe[13]; //4

    Naipe[] carta = new Naipe[52];
       
    void Start()
    {
        initBaraja();
    }

    void initBaraja()
    {
        /*
        for (int i = 0; i < cantidad; ++i)
        {
            picas[i] = new Naipe(i+1,false,1);
            treboles[i] = new Naipe(i + 1, false, 2);
            corazones[i] = new Naipe(i + 1, false, 3);
            diamantes[i] = new Naipe(i + 1, false, 4);
        }
        */

        //Las 52 se pueden generar de un golpe con algo como
        int auxCont = 0;
        for (int i = 0; i < palos; ++i)
        {
            for (int j = 0; j < cantidad; ++j)
            {
                carta[j + auxCont ] = new Naipe(j + 1, false, i + 1);
            }
            auxCont += 13;
        }
    }

    void identiPalo() //En este método puede ir un conversore de número a palo 
    {
        //if palo = 1 Debug.log("Picas");
        //if palo = 2 Debug.log("Treboles");
    }

    private void Update()
    {
        Debug.Log("La carta elegida es: " + carta[51].valor + " de "+ carta[51].palo);
    }


}

public class Naipe {

    public int valor;
    public bool estado;
    public int palo;

    //Métodos
    public void setValor(int asignarValor)
    {
        valor = asignarValor;
    }

    public void setEdo(bool asignEstado)
    {
        estado = asignEstado;
    }

    public void setPalo(int asignPalo)
    {
        palo = asignPalo;
    }

    public int getValor()
    {
        return valor;
    }

    public bool getEdo()
    {
        return estado;
    }

    public int getPalo()
    {
        return palo;
    }

    //constructores
    public Naipe() 
    {
        valor = 1;
        estado = false;
        palo = 1;
    }

    public Naipe(int val, bool edo,int p )
    {
        valor = val;
        estado = edo;
        palo = p;
    }

}

