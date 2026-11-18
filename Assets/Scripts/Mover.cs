using System;
using Unity.VisualScripting;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] float moveSpeed = 10f;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        PrintInstructions();
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
    }

    void PrintInstructions()
    {
        Debug.Log("Bem vindo ao jogo!");
        Debug.Log("Mova-se usando wasd");
        Debug.Log("Tente não ser atingido nem atingir os obstaculos para ganhar");
    }

    void MovePlayer()
    {
         float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
         float yValue = 0;
         float zValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed ;

        transform.Translate(xValue,yValue,zValue); //metodo que faz mover o jogador a todo instante
        
    }
}
