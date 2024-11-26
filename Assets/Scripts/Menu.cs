using UnityEngine;
using UnityEngine.SceneManagement; // Importante para manipulação de cenas
using UnityEngine.UI; // Importante para manipulação de UI, como o botão

public class Menu : MonoBehaviour
{
    // Método para ser chamado quando o botão for pressionado
    public void TrocarCena(string cenaJogo)
    {
        // Carrega a cena especificada pelo nome
        SceneManager.LoadScene("CenaJogo");
    }
}

