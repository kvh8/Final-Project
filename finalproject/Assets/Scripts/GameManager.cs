using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameManager : MonoBehaviour
{
    [SerializeField]
    private GameObject[] textPrefabs, textPosition, backgroundPosition, backgroundPrefab;
    [SerializeField]
    private GameObject  welcome;
    [SerializeField]
    private Button option1, option2, start;

    // [SerializeField]

    private GameObject clone;
    private bool op1 = false;
    private bool op2 = false;
    private bool isPlaying = false;
    private int numberOfPrefabs;
    private int textPositionPointer;
    private int backgroundPositionPointer;

    int index = 0;


    // Start is called before the first frame update
    void Start()
    {
        resetGame();

        GameObject clone1 = Instantiate(welcome, textPosition[textPositionPointer].transform);

        start.onClick.AddListener(delegate
        {
            Destroy(clone1);
            start.gameObject.SetActive(false);
            option1.gameObject.SetActive(true);
            option2.gameObject.SetActive(true);

            startGame();
        });
    }
    void startGame()
    {


        //Instantiates every prefab onto a transform
        for (int i = 0; i < numberOfPrefabs; i++)
        {
            clone = Instantiate(textPrefabs[i], textPosition[textPositionPointer].transform);
            clone = Instantiate(backgroundPrefab[i], backgroundPosition[backgroundPositionPointer].transform);
            textPosition[textPositionPointer].SetActive(false);
            backgroundPosition[backgroundPositionPointer].SetActive(false);
            textPositionPointer++;
            backgroundPositionPointer++;
        }

        //shows the first text option
        textPosition[index].SetActive(true);
        backgroundPosition[index].SetActive(true);

        option1.onClick.AddListener(delegate
        {
            textPosition[index].SetActive(false);
            backgroundPosition[index].SetActive(false);
            Option1();
        });

        option2.onClick.AddListener(delegate
        {
            textPosition[index].SetActive(false);
            backgroundPosition[index].SetActive(false);
            Option2();
        });


    }

    void Option1()
    {
        index = (2 * index) + 1;
        textPosition[index].SetActive(true);
        backgroundPosition[index].SetActive(true);
        startGame();
    }


    void Option2()
    {
        index = (2 * index) + 2;
        textPosition[index].SetActive(true);
        backgroundPosition[index].SetActive(true);
        startGame();
    }



    private void resetGame()
    {
        textPositionPointer = 0;
        backgroundPositionPointer = 0;
        numberOfPrefabs = textPrefabs.Length;
        option1.gameObject.SetActive(false);
        option2.gameObject.SetActive(false);
        start.gameObject.SetActive(true);
        isPlaying = true;

    }




    
}

