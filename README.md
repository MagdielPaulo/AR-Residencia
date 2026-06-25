# AR-Residencia

---

## Sobre

Projeto de **Realidade Aumentada** desenvolvido em Unity, com alvo nos dispositivos **Meta Quest 2 e Quest 3**. A aplicação utiliza o recurso de **Passthrough** para sobrepor conteúdo 3D ao ambiente físico real, explorando o pipeline completo de XR — da modelagem dos assets no Blender até o build final em `.apk` para o dispositivo.

Repositório construído ao longo da residência em RA, servindo como base técnica de estudo e validação do fluxo de trabalho Unity + Blender para hardware autônomo Meta Quest.

---

## Tech Stack

| Camada | Tecnologia |
|--------|-----------|
| Engine | Unity 6.3 LTS |
| Linguagem | C# |
| XR SDK | Meta XR Core SDK · Building Blocks · Depth API |
| Frameworks | AR Foundation · OpenXR Plugin · Oculus XR |
| Modelagem 3D | Blender (mesh, UV unwrapping, PBR) |
| Texturas | AmbientCG (PBR) |
| Versionamento | Git + Git LFS |
| Build | Android · IL2CPP · ARM64 |

---

## Estrutura

```
AR-Residencia/
├── .github/            # Workflows e configurações do repositório
├── .vscode/            # Configurações do editor
├── Assets/             # Cenas, scripts, modelos e materiais
├── Packages/           # Manifesto de pacotes Unity
├── ProjectSettings/    # Configurações do projeto e build
├── .gitattributes      # Regras de Git LFS (assets binários)
├── .gitignore          # Padrão Unity + pastas locais
└── .vsconfig           # Componentes do Visual Studio
```

> A pasta `Builds/` e os fontes `BlenderSource/` são ignorados pelo versionamento.

---

## Pipeline de Desenvolvimento

```
[Blender]  ──►  modelagem · UV unwrap · material PBR · export FBX
                                │
                                ▼
[Unity]    ──►  import asset · cena AR · XR Origin · Passthrough
                                │
                                ▼
[Build]    ──►  Android · IL2CPP · ARM64  ──►  ar-residencia.apk
                                │
                                ▼
[Quest]    ──►  deploy via ADB · teste no dispositivo
```

---

## Configuração de Build

| Parâmetro | Valor |
|-----------|-------|
| Platform | Android |
| Scripting Backend | IL2CPP |
| Target Architecture | ARM64 |
| Minimum API Level | Android 10 (API 29) |
| XR Plugin | OpenXR / Oculus |

---

## Como Rodar

```bash
# clonar o repositório (com suporte a Git LFS)
git lfs install
git clone https://github.com/MagdielPaulo/AR-Residencia.git
```

1. Abrir o projeto no **Unity Hub** (versão 6.3 LTS).
2. Aguardar a importação dos pacotes XR.
3. Conferir **Build Settings → Android** e o **XR Plug-in Management**.
4. Conectar o **Meta Quest** com modo desenvolvedor ativado.
5. **Build & Run** para gerar e instalar o `.apk` no dispositivo.

---

## Status do Projeto

- [x] Setup do repositório com Git LFS
- [x] Configuração de build Android
- [x] Cena base AR com Passthrough
- [x] Modelagem 3D e pipeline de exportação
- [x] Geração do `.apk`
- [ ] Testes em dispositivo físico (Quest 2/3)

---

Magdiel Paulo · [@MagdielPaulo](https://github.com/MagdielPaulo) — Maceió, Alagoas, Brasil
