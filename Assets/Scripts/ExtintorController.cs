using UnityEngine;

public class ExtintorController : MonoBehaviour
{
    [Header("Referências do Modelo 3D")]

    [Tooltip("Transform do extintor usado para manipular escala e posição")]
    [SerializeField] private Transform extintorTransform;

    [Tooltip("MeshRenderer do extintor usado para alternar visibilidade")]
    [SerializeField] private MeshRenderer extintorRenderer;

    [Header("Parâmetros de Manipulação")]

    [Tooltip("Escala mínima aplicada quando o Slider está em 0")]
    [SerializeField] private float escalaMinima = 0.5f;

    [Tooltip("Escala máxima aplicada quando o Slider está em 1")]
    [SerializeField] private float escalaMaxima = 2f;

    public void AlterarEscala(float valor)
    {
        
    }

    public void AlternarVisibilidade(bool visivel)
    {
        
    }

    public void ResetarExtintor()
    {
      
    }
}