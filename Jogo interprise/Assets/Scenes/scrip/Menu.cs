using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Menu : MonoBehaviour
{
    public string nomedaCena;
    public GameObject menuPanel;
    // Start is called before the first frame update
    void Start()
    {
        // Ativando painel do menu 
        menuPanel.SetActive(true);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //fun��o do bot�o start
    public void StartGame()
    {
        // Carregando Cena Game
        SceneManager.LoadScene(nomedaCena);

    }
    public void QuitGame()
    {
        //Fun��o do bot�o sair
        UnityEditor.EditorApplication.isPlaying = false;
    }
}
