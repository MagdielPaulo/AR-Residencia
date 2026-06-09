using UnityEngine;

public class ExtintorController : MonoBehaviour
{
    [Header("Referências do Modelo 3D")]

    [Tooltip("Transform do extintor — usado para manipular escala")]
    [SerializeField] private Transform extintorTransform;

    [Tooltip("MeshRenderer do extintor — usado para alternar visibilidade")]
    [SerializeField] private MeshRenderer extintorRenderer;

    [Header("Parâmetros de Manipulação")]

    [Tooltip("Escala mínima aplicada quando o Slider está em 0")]
    [SerializeField] private float escalaMinima = 0.5f;

    [Tooltip("Escala máxima aplicada quando o Slider está em 1")]
    [SerializeField] private float escalaMaxima = 2f;

    public void AlterarEscala(float valor)
    {
        
        valor = Mathf.Clamp01(valor);

        
        float novaEscala = Mathf.Lerp(escalaMinima, escalaMaxima, valor);

        
        extintorTransform.localScale = new Vector3(novaEscala, novaEscala, novaEscala);
    }

    public void AlternarVisibilidade(bool visivel)
    {
        extintorRenderer.enabled = visivel;
    }

    public void ResetarExtintor()
    {
        extintorTransform.localScale = Vector3.one;
        extintorRenderer.enabled = true;
    }

    [ContextMenu("Teste: Escala Mínima (0)")]
    private void TestarEscalaMinima() => AlterarEscala(0f);

    [ContextMenu("Teste: Escala Máxima (1)")]
    private void TestarEscalaMaxima() => AlterarEscala(1f);

    [ContextMenu("Teste: Escala Média (0.5)")]
    private void TestarEscalaMedia() => AlterarEscala(0.5f);

    [ContextMenu("Teste: Esconder")]
    private void TestarEsconder() => AlternarVisibilidade(false);

    [ContextMenu("Teste: Mostrar")]
    private void TestarMostrar() => AlternarVisibilidade(true);

    [ContextMenu("Teste: Resetar")]
    private void TestarResetar() => ResetarExtintor();
}