using UnityEngine;
using UnityEngine.SceneManagement; // Importante para manipula��o de cenas
using UnityEngine.UI; // Importante para manipula��o de UI, como o bot�o

public class Menu : MonoBehaviour
{
    // M�todo para ser chamado quando o bot�o for pressionado
    public void TrocarCena(string cenaJogo)
    {
        // Carrega a cena especificada pelo nome
        SceneManager.LoadScene("CenaJogo");
    }
}

