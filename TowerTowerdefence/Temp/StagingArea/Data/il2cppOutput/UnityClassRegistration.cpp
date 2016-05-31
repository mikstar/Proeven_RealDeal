struct ClassRegistrationContext;
void InvokeRegisterStaticallyLinkedModuleClasses(ClassRegistrationContext& context)
{
	// Do nothing (we're in stripping mode)
}

void RegisterStaticallyLinkedModulesGranular()
{
	void RegisterModule_Animation();
	RegisterModule_Animation();

	void RegisterModule_Audio();
	RegisterModule_Audio();

	void RegisterModule_ParticleSystem();
	RegisterModule_ParticleSystem();

	void RegisterModule_Physics();
	RegisterModule_Physics();

	void RegisterModule_Physics2D();
	RegisterModule_Physics2D();

	void RegisterModule_TextRendering();
	RegisterModule_TextRendering();

	void RegisterModule_UI();
	RegisterModule_UI();

	void RegisterModule_IMGUI();
	RegisterModule_IMGUI();

}

void RegisterAllClasses()
{
	//Total: 77 classes
	//0. Mesh
	void RegisterClass_Mesh();
	RegisterClass_Mesh();

	//1. NamedObject
	void RegisterClass_NamedObject();
	RegisterClass_NamedObject();

	//2. EditorExtension
	void RegisterClass_EditorExtension();
	RegisterClass_EditorExtension();

	//3. Renderer
	void RegisterClass_Renderer();
	RegisterClass_Renderer();

	//4. Component
	void RegisterClass_Component();
	RegisterClass_Component();

	//5. TrailRenderer
	void RegisterClass_TrailRenderer();
	RegisterClass_TrailRenderer();

	//6. LineRenderer
	void RegisterClass_LineRenderer();
	RegisterClass_LineRenderer();

	//7. GUILayer
	void RegisterClass_GUILayer();
	RegisterClass_GUILayer();

	//8. Behaviour
	void RegisterClass_Behaviour();
	RegisterClass_Behaviour();

	//9. Texture
	void RegisterClass_Texture();
	RegisterClass_Texture();

	//10. Texture2D
	void RegisterClass_Texture2D();
	RegisterClass_Texture2D();

	//11. RenderTexture
	void RegisterClass_RenderTexture();
	RegisterClass_RenderTexture();

	//12. RectTransform
	void RegisterClass_RectTransform();
	RegisterClass_RectTransform();

	//13. Transform
	void RegisterClass_Transform();
	RegisterClass_Transform();

	//14. Shader
	void RegisterClass_Shader();
	RegisterClass_Shader();

	//15. TextAsset
	void RegisterClass_TextAsset();
	RegisterClass_TextAsset();

	//16. Material
	void RegisterClass_Material();
	RegisterClass_Material();

	//17. Sprite
	void RegisterClass_Sprite();
	RegisterClass_Sprite();

	//18. Camera
	void RegisterClass_Camera();
	RegisterClass_Camera();

	//19. MonoBehaviour
	void RegisterClass_MonoBehaviour();
	RegisterClass_MonoBehaviour();

	//20. Light
	void RegisterClass_Light();
	RegisterClass_Light();

	//21. GameObject
	void RegisterClass_GameObject();
	RegisterClass_GameObject();

	//22. ParticleSystem
	void RegisterClass_ParticleSystem();
	RegisterClass_ParticleSystem();

	//23. Rigidbody
	void RegisterClass_Rigidbody();
	RegisterClass_Rigidbody();

	//24. Collider
	void RegisterClass_Collider();
	RegisterClass_Collider();

	//25. SphereCollider
	void RegisterClass_SphereCollider();
	RegisterClass_SphereCollider();

	//26. Collider2D
	void RegisterClass_Collider2D();
	RegisterClass_Collider2D();

	//27. AudioClip
	void RegisterClass_AudioClip();
	RegisterClass_AudioClip();

	//28. SampleClip
	void RegisterClass_SampleClip();
	RegisterClass_SampleClip();

	//29. AudioSource
	void RegisterClass_AudioSource();
	RegisterClass_AudioSource();

	//30. AudioBehaviour
	void RegisterClass_AudioBehaviour();
	RegisterClass_AudioBehaviour();

	//31. Animator
	void RegisterClass_Animator();
	RegisterClass_Animator();

	//32. DirectorPlayer
	void RegisterClass_DirectorPlayer();
	RegisterClass_DirectorPlayer();

	//33. Font
	void RegisterClass_Font();
	RegisterClass_Font();

	//34. Canvas
	void RegisterClass_Canvas();
	RegisterClass_Canvas();

	//35. CanvasGroup
	void RegisterClass_CanvasGroup();
	RegisterClass_CanvasGroup();

	//36. CanvasRenderer
	void RegisterClass_CanvasRenderer();
	RegisterClass_CanvasRenderer();

	//37. MeshRenderer
	void RegisterClass_MeshRenderer();
	RegisterClass_MeshRenderer();

	//38. SpriteRenderer
	void RegisterClass_SpriteRenderer();
	RegisterClass_SpriteRenderer();

	//39. RuntimeAnimatorController
	void RegisterClass_RuntimeAnimatorController();
	RegisterClass_RuntimeAnimatorController();

	//40. PreloadData
	void RegisterClass_PreloadData();
	RegisterClass_PreloadData();

	//41. Cubemap
	void RegisterClass_Cubemap();
	RegisterClass_Cubemap();

	//42. Texture3D
	void RegisterClass_Texture3D();
	RegisterClass_Texture3D();

	//43. LevelGameManager
	void RegisterClass_LevelGameManager();
	RegisterClass_LevelGameManager();

	//44. GameManager
	void RegisterClass_GameManager();
	RegisterClass_GameManager();

	//45. TimeManager
	void RegisterClass_TimeManager();
	RegisterClass_TimeManager();

	//46. GlobalGameManager
	void RegisterClass_GlobalGameManager();
	RegisterClass_GlobalGameManager();

	//47. AudioManager
	void RegisterClass_AudioManager();
	RegisterClass_AudioManager();

	//48. InputManager
	void RegisterClass_InputManager();
	RegisterClass_InputManager();

	//49. Physics2DSettings
	void RegisterClass_Physics2DSettings();
	RegisterClass_Physics2DSettings();

	//50. GraphicsSettings
	void RegisterClass_GraphicsSettings();
	RegisterClass_GraphicsSettings();

	//51. MeshFilter
	void RegisterClass_MeshFilter();
	RegisterClass_MeshFilter();

	//52. QualitySettings
	void RegisterClass_QualitySettings();
	RegisterClass_QualitySettings();

	//53. PhysicsManager
	void RegisterClass_PhysicsManager();
	RegisterClass_PhysicsManager();

	//54. MeshCollider
	void RegisterClass_MeshCollider();
	RegisterClass_MeshCollider();

	//55. BoxCollider
	void RegisterClass_BoxCollider();
	RegisterClass_BoxCollider();

	//56. AnimationClip
	void RegisterClass_AnimationClip();
	RegisterClass_AnimationClip();

	//57. Motion
	void RegisterClass_Motion();
	RegisterClass_Motion();

	//58. TagManager
	void RegisterClass_TagManager();
	RegisterClass_TagManager();

	//59. AudioListener
	void RegisterClass_AudioListener();
	RegisterClass_AudioListener();

	//60. Avatar
	void RegisterClass_Avatar();
	RegisterClass_Avatar();

	//61. AnimatorController
	void RegisterClass_AnimatorController();
	RegisterClass_AnimatorController();

	//62. ScriptMapper
	void RegisterClass_ScriptMapper();
	RegisterClass_ScriptMapper();

	//63. DelayedCallManager
	void RegisterClass_DelayedCallManager();
	RegisterClass_DelayedCallManager();

	//64. RenderSettings
	void RegisterClass_RenderSettings();
	RegisterClass_RenderSettings();

	//65. MonoScript
	void RegisterClass_MonoScript();
	RegisterClass_MonoScript();

	//66. MonoManager
	void RegisterClass_MonoManager();
	RegisterClass_MonoManager();

	//67. FlareLayer
	void RegisterClass_FlareLayer();
	RegisterClass_FlareLayer();

	//68. PlayerSettings
	void RegisterClass_PlayerSettings();
	RegisterClass_PlayerSettings();

	//69. CapsuleCollider
	void RegisterClass_CapsuleCollider();
	RegisterClass_CapsuleCollider();

	//70. SkinnedMeshRenderer
	void RegisterClass_SkinnedMeshRenderer();
	RegisterClass_SkinnedMeshRenderer();

	//71. BuildSettings
	void RegisterClass_BuildSettings();
	RegisterClass_BuildSettings();

	//72. ResourceManager
	void RegisterClass_ResourceManager();
	RegisterClass_ResourceManager();

	//73. LightmapSettings
	void RegisterClass_LightmapSettings();
	RegisterClass_LightmapSettings();

	//74. ParticleSystemRenderer
	void RegisterClass_ParticleSystemRenderer();
	RegisterClass_ParticleSystemRenderer();

	//75. LightProbes
	void RegisterClass_LightProbes();
	RegisterClass_LightProbes();

	//76. RuntimeInitializeOnLoadManager
	void RegisterClass_RuntimeInitializeOnLoadManager();
	RegisterClass_RuntimeInitializeOnLoadManager();

}
