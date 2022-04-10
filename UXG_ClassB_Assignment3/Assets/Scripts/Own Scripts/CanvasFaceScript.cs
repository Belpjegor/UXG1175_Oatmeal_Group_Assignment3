using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.AddressableAssets;
using UnityEngine.UI;

public class CanvasFaceScript : MonoBehaviour
{
    List<Character> characters;

    public int charaRefID;

    public Image faceShape;
    public Image leftEye;
    public Image rightEye;
    public Image nose;
    public Image mouth;

    //to call individual parts of character
    private static AsyncOperationHandle<Sprite> loadFace;
    private static AsyncOperationHandle<Sprite> loadLefteye;
    private static AsyncOperationHandle<Sprite> loadRighteye;
    private static AsyncOperationHandle<Sprite> loadNose;
    private static AsyncOperationHandle<Sprite> loadMouth;

    public void SetCharaFace(Character cHara)
    {

        //get character face shape from Character script
        PartShape charaShape = cHara.GetShape();
        // Common.DebugLog(cHara.GetName() + "charaShape " + charaShape.GetDisplayName()); //need to add GetDisplayName();
        if (charaShape != null)
        {
            //load face sprite
            loadFace = Addressables.LoadAssetAsync<Sprite>(string.Format("Assets/Images/shape_{0}.png", charaShape.GetAssetName()));
            loadFace.Completed += (sp) =>
            {
                //result of LoadAssetAsync
                faceShape.sprite = sp.Result;
                faceShape.color = cHara.GetColour();
            };
        }

        //get character eye shape from Character script
        PartEyes charaEyes = cHara.GetEyes();
        // Common.DebugLog(cHara.GetName() + "charaEyes " + charaEyes.GetDisplayName()); //need to add GetDisplayName();
        if (charaEyes != null)
        {
            //load left eye sprite
            loadLefteye = Addressables.LoadAssetAsync<Sprite>(string.Format("Assets/Images/lefteye_{0}.png", charaEyes.GetAssetName()));
            loadLefteye.Completed += (sp) =>
            {
                //result of LoadAssetAsync
                leftEye.sprite = sp.Result;
            };

            //load right eye sprite
            loadRighteye = Addressables.LoadAssetAsync<Sprite>(string.Format("Assets/Images/righteye_{0}.png", charaEyes.GetAssetName()));
            loadRighteye.Completed += (sp) =>
            {
                //result of LoadAssetAsync
                rightEye.sprite = sp.Result;
            };
        }

        //get character nose shape from Character script
        PartNose charaNose = cHara.GetNose();
        // Common.DebugLog(cHara.GetName() + "charaNose " + charaNose.GetDisplayName()); //need to add GetDisplayName();
        if (charaNose != null)
        {
            //load nose sprite
            loadNose = Addressables.LoadAssetAsync<Sprite>(string.Format("Assets/Images/nose_{0}.png", charaNose.GetAssetName()));
            loadNose.Completed += (sp) =>
            {
                //result of LoadAssetAsync
                nose.sprite = sp.Result;
            };
        }

        PartMouth charaMouth = cHara.GetMouth();
            // Common.DebugLog(cHara.GetName() + "charaMouth " + charaMouth.GetDisplayName()); //need to add GetDisplayName();
            if (charaMouth != null)
            {
                //load nose sprite
                loadMouth = Addressables.LoadAssetAsync<Sprite>(string.Format("Assets/Images/mouth_{0}.png", charaMouth.GetAssetName()));
                loadMouth.Completed += (sp) =>
                {
                    //result of LoadAssetAsync
                    mouth.sprite = sp.Result;
                };
            }
    }
    private void Awake()
    {
        characters = Game.GetCharacterList();
    }

    private void Update()
    {
        float progress = 0;
        if (loadFace.IsValid())
        {
            progress = (loadFace.PercentComplete + loadLefteye.PercentComplete + loadRighteye.PercentComplete + loadNose.PercentComplete + loadMouth.PercentComplete) / 4f;
        }
        if (progress > 0 && progress < 1f)
        {
            Common.DebugLog("face" + progress);
        }

        SetCharaFace(characters[charaRefID]);
    }
}